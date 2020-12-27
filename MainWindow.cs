using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Font = System.Drawing.Font;
using Label = System.Windows.Forms.Label;

namespace programmingWF
{
    public partial class MainWindow : Form
    {
        /*Поле, в котором буду хранится сохраняемые данные*/
        protected internal Data data = new Data();
        /*Конструктор главного окна*/
        protected internal MainWindow()
        {
            InitializeComponent();
            /*Диалоговое окно создания нового склада
             или загрузки существовавшего*/
            var dialog = MessageBox.Show(
                "Загрузить склад?",
                "Добро пожаловать",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );
            if (dialog == DialogResult.No || dialog == DialogResult.Yes && !Deserialize())
            {
                new NewWareHouse(this);
                /*Добавляем наблюдаемые массивы событие-наблюдатель */
                data.Procurements.CollectionChanged += CollectionChanged;
                data.Sales.CollectionChanged += CollectionChanged;
                data.Inventory.CollectionChanged += CollectionChanged;
                data.Transactions.CollectionChanged += CollectionChanged;
            }
            /*Выравниваем столбцы в таблицах*/
            MainWindow_SizeChanged(this, EventArgs.Empty);
            LabelChange(labelBalanceCount, data.Balance + " руб.");
        }
        /*Метод обновления текста у подписи.
         Размер текста меняется в соответствии с его длиной*/
        protected internal void LabelChange(Label label, string str)
        {
            label.Text = str;
            label.Font = new Font(Font.Name,
                100 / (str.Length / 2 == 0 ? 1 : str.Length / 2) > 24 ?
                    24 :
                    100 / (str.Length / 2 == 0 ? 1 : str.Length / 2));
        }
        /*Метод обновления состояния кнопок*/
        protected internal void ButtonCheck()
        {
            buttonPurchaseExcel.Enabled = data.Procurements.Count != 0;
            buttonSaleExcel.Enabled = data.Sales.Count != 0;
            buttonInventoryExcel.Enabled = buttonAddSale.Enabled = data.Inventory.Count != 0;
            buttonTransactionExcel.Enabled = data.Transactions.Count != 0;
        }
        /*Событие-наблюдатель для
         добавления значений в таблицы формы*/
        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                /*Если произошло добавление в массив*/
                case NotifyCollectionChangedAction.Add:

                    var newItem = e.NewItems[0] as WareHouse; 
                    newItem.GetListView(this).Items.Add(newItem.GetListViewItem());
                    LabelChange(labelTotalCount, (data.Procurements.Count + data.Sales.Count).ToString());
                    break;
                /*Если произошло удаление из массива*/
                case NotifyCollectionChangedAction.Remove:

                    var oldItem = e.OldItems[0] as WareHouse;
                    oldItem.GetListView(this).Items.RemoveAt(e.OldStartingIndex);
                    break;
                /*Если произошла замена*/
                case NotifyCollectionChangedAction.Replace:

                    var newReplaceItem = e.NewItems[0] as WareHouse;
                    var items = newReplaceItem.GetListView(this).Items;
                    items[e.OldStartingIndex] = newReplaceItem.GetListViewItem();
                    break;
            }
        }

        /*События для позиций на покупку*/

        /*Открыть*/
        private void buttonAddProcurement_Click(object sender, EventArgs e)
        {
            /*Вызываем диалоговое окно покупки*/
            new ProcurementWindow(this);
        }
        /*Закрыть*/
        private void buttonCloseProcurement_Click(object sender, EventArgs e)
        {
            try
            {
                /*Изменяем состояние позиции*/
                var item = ButtonClick(WareHouse.Status.Completed, data.Procurements, listViewProcurement);
                /*Изменяем баланс*/
                data.Balance -= item.Count * item.Cost;
                /*Обновляем подписи*/
                LabelChange(labelBidCount, data.Inventory.Count.ToString());
                LabelChange(labelProcurementCount1, (data.CountProc += 1).ToString());
                LabelChange(labelProcurementCount2, (data.CountWaitProc -= 1).ToString());
                LabelChange(labelBalanceCount, data.Balance + " руб.");
                if (DateTime.Now.Date > item.DueDate.Date)
                    LabelChange(labelProcurementCount3, (data.CountOverDueProc += 1).ToString());
                /*Обновляем кнопки*/
                ButtonCheck();
            }
            /*Недостаточно средств для закрытия*/
            catch (ArgumentException)
            {
                MessageBox.Show("Недостаточно средств для закрытия сделки.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            /*Конфликт между существующим в инвентаре элементом*/
            catch (MissingPrimaryKeyException)
            {
                MessageBox.Show("Имя товара или штрихкод не совпадает с уже существующим товаром на складе.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        /*Отменить*/
        private void buttonCancelProcurement_Click(object sender, EventArgs e)
        {
            ButtonClick(WareHouse.Status.Canceled, data.Procurements, listViewProcurement);
            labelProcurementCount2.Text = (data.CountWaitProc -= 1).ToString();
        }
        /*Выбор элемента в таблице*/
        private void listViewProcurement_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /*Изменяем состояние кнопок, если выбрали позицию*/
                if (data.Procurements[listViewProcurement.SelectedIndices[0]].CurStatus != WareHouse.Status.Expectation) return;
                buttonCancelPurchase.Enabled = true;
                buttonClosePurchase.Enabled = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                /*Изменяем состояние кнопок, если не выбрали позицию*/
                buttonCancelPurchase.Enabled = false;
                buttonClosePurchase.Enabled = false;
            }
        }

        /*События для позиций на продажу*/

        /*Открыть*/
        private void buttonAddSale_Click(object sender, EventArgs e)
        {
            /*Вызываем диалоговое окно продажи*/
            new SaleWindow(this);
        }
        /*Закрыть*/
        private void buttonCloseSale_Click(object sender, EventArgs e)
        {
            try
            {
                /*Изменяем состояние позиции*/
                var item = ButtonClick(WareHouse.Status.Completed, data.Sales, listViewSale);
                /*Изменяем баланс*/
                data.Balance += item.Count * item.Cost;
                /*Обновляем подписи*/
                LabelChange(labelBidCount, data.Inventory.Count.ToString());
                LabelChange(labelSaleCount1, (data.CountSale += 1).ToString());
                LabelChange(labelSaleCount2, (data.CountWaitSale -= 1).ToString());
                LabelChange(labelBalanceCount, data.Balance + " руб.");
                if (DateTime.Now.Date > item.DueDate.Date)
                    labelSaleCount3.Text = (data.CountOverDueSale += 1).ToString();
                /*Обновляем кнопки*/
                ButtonCheck();
            }
            /*Недостаточно предметов на складе для закрытия*/
            catch (ArgumentException)
            {
                MessageBox.Show("На складе недостаточно товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /*Отменить*/
        private void buttonCancelSale_Click(object sender, EventArgs e)
        {
            ButtonClick(WareHouse.Status.Canceled, data.Sales, listViewSale);
            LabelChange(labelSaleCount2, (data.CountWaitSale -= 1).ToString());
        }
        /*Выбор элемента в таблице*/
        private void listViewSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /*Изменяем состояние кнопок, если выбрали позицию*/
                if (data.Sales[listViewSale.SelectedIndices[0]].CurStatus != WareHouse.Status.Expectation) return;
                buttonCancelSale.Enabled = true;
                buttonCloseSale.Enabled = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                /*Изменяем состояние кнопок, если не выбрали позицию*/
                buttonCancelSale.Enabled = false;
                buttonCloseSale.Enabled = false;
            }
        }

        /*Событие кнопки сохранения*/
        private void buttonExport_Click(object sender, EventArgs e)
        {
            /*Проводим сериализацию*/
            Serialize();
        }
        /*Событие кнопки загрузки*/
        private void buttonImport_Click(object sender, EventArgs e)
        {
            /*Перед загрузкой спрашиваем о надобности сохранения*/
            SaveWareHouse();
            /*Проводим десериализацию*/
            Deserialize();
        }
        /*Метод сериализации*/
        private void Serialize()
        {
            /*Диалоговое окно сохранения файла*/
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "bin files (*.bin)|*.bin"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            /*Сериализация*/
            using (var fs = saveFileDialog.OpenFile())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(fs, data);
                MessageBox.Show("Склад успешно сохранен.", "Сохранение склада", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /*Метод десериализации*/
        private bool Deserialize()
        {
            /*Диалоговое окно открытия файла*/
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "bin files (*.bin)|*.bin"
            };

            while (true)
            {
                if (openFileDialog.ShowDialog(this) != DialogResult.OK) return false;

                try
                {
                    /*Десериализация*/
                    using (var fs = openFileDialog.OpenFile())
                    {
                        var formatter = new BinaryFormatter();
                        data = (Data)formatter.Deserialize(fs);
                    }
                    /*Очищаем таблицы перед заполнением новыми элементами*/
                    listViewProcurement.Items.Clear();
                    listViewSale.Items.Clear();
                    listViewInventory.Items.Clear();
                    listViewTransactions.Items.Clear();
                    /*Наполняем таблицы новыми элементами*/
                    foreach (var elm in data.Procurements)
                        listViewProcurement.Items.Add(elm.GetListViewItem());
                    foreach (var elm in data.Sales)
                        listViewSale.Items.Add(elm.GetListViewItem());
                    foreach (var elm in data.Inventory)
                        listViewInventory.Items.Add(elm.GetListViewItem());
                    foreach (var elm in data.Transactions)
                        listViewTransactions.Items.Add(elm.GetListViewItem());
                    /*Добавляем наблюдаемые массивы событие-наблюдатель */
                    data.Procurements.CollectionChanged += CollectionChanged;
                    data.Sales.CollectionChanged += CollectionChanged;
                    data.Inventory.CollectionChanged += CollectionChanged;
                    data.Transactions.CollectionChanged += CollectionChanged;
                    /*Обновляем подписи*/
                    LabelChange(labelProcurementCount1, data.CountProc.ToString());
                    LabelChange(labelSaleCount1, data.CountSale.ToString());
                    LabelChange(labelProcurementCount2, data.CountWaitProc.ToString());
                    LabelChange(labelSaleCount2, data.CountWaitSale.ToString());
                    LabelChange(labelProcurementCount3, data.CountOverDueProc.ToString());
                    LabelChange(labelSaleCount3, data.CountOverDueSale.ToString());
                    LabelChange(labelBidCount, data.Inventory.Count.ToString());
                    LabelChange(labelTotalCount, (data.Procurements.Count + data.Sales.Count).ToString());
                    LabelChange(labelBalanceCount, data.Balance + " руб.");
                    /*Обновляем кнопки*/
                    ButtonCheck();

                    MessageBox.Show("Склад успешно загружен.", "Загрузка склада", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                /*Если произошла ошибка во время десериализации*/
                catch (System.Runtime.Serialization.SerializationException)
                {
                    MessageBox.Show("Неправильный файл сериализации");
                }
            }
        }
        /*Метод изменения состояния позиции*/
        private WareHouse ButtonClick(WareHouse.Status status, ObservableCollection<WareHouse> array, ListView listView)
        {
            var index = listView.SelectedIndices[0];
            var item = array[index];
            item.WareHouseSet(status, index, this);
            item.CurStatus = status;
            array[index] = item;
            Transaction.TransactionSet(status, item.Num, this);
            return item;
        }
        /*Событие закрытия формы*/
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*Перед закрытием спрашиваем о сохранении*/
            SaveWareHouse();
            e.Cancel = false;
        }
        /*Метод предупреждения о сохранении*/
        private void SaveWareHouse()
        {
            var dialog = MessageBox.Show(
                "Сохранить текущий склад?",
                "Предупреждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (dialog == DialogResult.Yes)
                Serialize();
        }
        /*Метод сохранения таблицы в файл Excel*/
        private void SaveExcel(ListView listView)
        {
            using (var sfd = new SaveFileDialog() { Filter = "Excel|*.xlsx", ValidateNames = true })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                var app = new Microsoft.Office.Interop.Excel.Application();
                var wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                var ws = (Worksheet)app.ActiveSheet;
                app.Visible = false;
                foreach (ListViewItem item in listViewProcurement.Items)
                {
                    for (int ia = 0; ia < listView.Columns.Count; ia++)
                        ws.Cells[1, ia + 1] = listView.Columns[ia].Text;
                }
                var i = 2;

                foreach (ListViewItem item in listView.Items)
                {
                    var k = 1;
                    foreach (ListViewItem.ListViewSubItem elm in item.SubItems)
                    {
                        ws.Cells[i, k].NumberFormat = "@";
                        ws.Cells[i, k++] = elm.Text;
                    }
                    i++;
                }
                wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                app.Quit();
                MessageBox.Show("Таблица успешно сохранена.", "Сохранение таблицы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*События для сохранения таблицы в файл Excel*/

        /*Для покупки*/
        private void buttonPurchaseExcel_Click(object sender, EventArgs e)
        {
            SaveExcel(listViewProcurement);
        }
        /*Для продажи*/
        private void buttonSaleExcel_Click(object sender, EventArgs e)
        {
            SaveExcel(listViewSale);
        }
        /*Для инвентаря*/
        private void buttonInventoryExcel_Click(object sender, EventArgs e)
        {
            SaveExcel(listViewInventory);
        }
        /*Для транзакции*/
        private void buttonTransactionExcel_Click(object sender, EventArgs e)
        {
            SaveExcel(listViewTransactions);
        }

        /*Событие изменения размера формы*/
        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            listViewProcurement.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewSale.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewInventory.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewTransactions.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}