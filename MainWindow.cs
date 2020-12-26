﻿using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace programmingWF
{
    public partial class MainWindow : Form
    {
        protected internal Data data = new Data();

        public MainWindow()
        {
            data.Procurements.CollectionChanged += CollectionChanged;
            data.Sales.CollectionChanged += CollectionChanged;
            data.Inventory.CollectionChanged += CollectionChanged;
            data.Transactions.CollectionChanged += CollectionChanged;

            new NewWareHouse(this);
            InitializeComponent();
            labelBalanceCount.Text = data.Balance + " руб.";
            labelBalanceCount.Font = LabelChange(labelBalanceCount.Text);
        }

        protected internal int Search(ObservableCollection<WareHouse> array, string criterion)
        {
            var index = 0;
            foreach (var elm in array)
                if (elm.Comparison(criterion))
                    return index;
                else index++;
            return -1;
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:

                    var newItem = e.NewItems[0] as WareHouse; 
                    newItem.GetListView(this).Items.Add(newItem.GetListViewItem());
                    labelTotalCount.Text = (data.Procurements.Count + data.Sales.Count).ToString();
                    break;

                case NotifyCollectionChangedAction.Remove:

                    var oldItem = e.OldItems[0] as WareHouse;
                    oldItem.GetListView(this).Items.RemoveAt(e.OldStartingIndex);
                    break;

                case NotifyCollectionChangedAction.Replace:

                    var newReplaceItem = e.NewItems[0] as WareHouse;
                    var items = newReplaceItem.GetListView(this).Items;
                    items[e.OldStartingIndex] = newReplaceItem.GetListViewItem();
                    break;
            }
        }

        private void buttonAddProcurement_Click(object sender, EventArgs e)
        {
            new ProcurementWindow(this);
            labelProcurementCount2.Text = (data.CountWaitProc += 1).ToString();
        }

        private void buttonCloseProcurement_Click(object sender, EventArgs e)
        {
            var item = ButtonClick(WareHouse.Status.Completed, data.Procurements, listViewProcurement);

            var indexInventory = Search(data.Inventory, item.BarCode);
            if (indexInventory != -1)
            {
                var itemInventory = data.Inventory[indexInventory];
                itemInventory.Count += item.Count;
                data.Inventory[indexInventory] = itemInventory;
            }
            else
            {
                data.Inventory.Add(new Inventory(
                    item.BarCode,
                    item.Name,
                    item.Note,
                    item.Cost,
                    item.Count));
            }

            data.Balance -= item.Count * item.Cost;

            labelBidCount.Text = data.Inventory.Count.ToString();
            labelProcurementCount1.Text = (data.CountProc += 1).ToString();
            labelProcurementCount2.Text = (data.CountWaitProc -= 1).ToString();
            labelBalanceCount.Text = data.Balance + " руб.";
            labelBalanceCount.Font = LabelChange(labelBalanceCount.Text);
            if (DateTime.Now.Date > item.DueDate.Date)
                labelProcurementCount3.Text = (data.CountOverDueProc += 1).ToString();
            buttonAddSale.Enabled = true;
        }

        private void buttonCancelProcurement_Click(object sender, EventArgs e)
        {
            ButtonClick(WareHouse.Status.Canceled, data.Procurements, listViewProcurement);
            labelProcurementCount2.Text = (data.CountWaitProc -= 1).ToString();
        }

        private void listViewProcurement_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (data.Procurements[listViewProcurement.SelectedIndices[0]].CurStatus != WareHouse.Status.Expectation) return;
                buttonCancelPurchase.Enabled = true;
                buttonClosePurchase.Enabled = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                buttonCancelPurchase.Enabled = false;
                buttonClosePurchase.Enabled = false;
            }
        }

        private void buttonAddSale_Click(object sender, EventArgs e)
        {
            new SaleWindow(this);
            labelSaleCount2.Text = (data.CountWaitSale += 1).ToString();
        }

        private void buttonCloseSale_Click(object sender, EventArgs e)
        {
            var item = ButtonClick(WareHouse.Status.Completed, data.Sales, listViewSale);

            var indexInventory = Search(data.Inventory, item.BarCode);
            if (item.Count < data.Inventory[indexInventory].Count)
            {
                var itemInventory = data.Inventory[indexInventory];
                itemInventory.Count -= item.Count;
                data.Inventory[indexInventory] = itemInventory;
            }
            else data.Inventory.RemoveAt(indexInventory);

            data.Balance += item.Count * item.Cost;

            labelBidCount.Text = data.Inventory.Count.ToString();
            labelSaleCount1.Text = (data.CountSale += 1).ToString();
            labelSaleCount2.Text = (data.CountWaitSale -= 1).ToString();
            labelBalanceCount.Text = data.Balance + " руб.";
            labelBalanceCount.Font = LabelChange(labelBalanceCount.Text);
            if (DateTime.Now.Date > item.DueDate.Date)
                labelSaleCount3.Text = (data.CountOverDueSale += 1).ToString();
            if (data.Inventory.Count == 0) buttonAddSale.Enabled = false;
        }

        private void buttonCancelSale_Click(object sender, EventArgs e)
        {
            ButtonClick(WareHouse.Status.Canceled, data.Sales, listViewSale);
            labelSaleCount2.Text = (data.CountWaitSale -= 1).ToString();
        }

        private void listViewSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (data.Sales[listViewSale.SelectedIndices[0]].CurStatus != WareHouse.Status.Expectation) return;
                buttonCancelSale.Enabled = true;
                buttonCloseSale.Enabled = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                buttonCancelSale.Enabled = false;
                buttonCloseSale.Enabled = false;
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "bin files (*.bin)|*.bin"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            using (var fs = saveFileDialog.OpenFile())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(fs, data);
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "bin files (*.bin)|*.bin"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (var fs = openFileDialog.OpenFile())
                {
                    var formatter = new BinaryFormatter();
                    data = (Data)formatter.Deserialize(fs);
                }

                foreach (var elm in data.Procurements)
                    listViewProcurement.Items.Add(elm.GetListViewItem());
                foreach (var elm in data.Sales)
                    listViewSale.Items.Add(elm.GetListViewItem());
                foreach (var elm in data.Inventory)
                    listViewInventory.Items.Add(elm.GetListViewItem());
                foreach (var elm in data.Transactions)
                    listViewTransactions.Items.Add(elm.GetListViewItem());

                data.Procurements.CollectionChanged += CollectionChanged;
                data.Sales.CollectionChanged += CollectionChanged;
                data.Inventory.CollectionChanged += CollectionChanged;
                data.Transactions.CollectionChanged += CollectionChanged;

                labelProcurementCount1.Text = data.CountProc.ToString();
                labelSaleCount1.Text = data.CountSale.ToString();
                labelProcurementCount2.Text = data.CountWaitProc.ToString();
                labelSaleCount2.Text = data.CountWaitSale.ToString();
                labelProcurementCount3.Text = data.CountOverDueProc.ToString();
                labelSaleCount3.Text = data.CountOverDueSale.ToString();
                labelBidCount.Text = data.Inventory.Count.ToString();
                labelTotalCount.Text = (data.Procurements.Count + data.Sales.Count).ToString();
                labelBalanceCount.Text = data.Balance.ToString();
                labelBalanceCount.Font = LabelChange(labelBalanceCount.Text);

                buttonAddSale.Enabled = data.Inventory.Count != 0;
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                MessageBox.Show("Неправильный файл сериализации");
            }
        }

        private Font LabelChange(string str)
        {
            return new Font(Font.Name, 100 / (str.Length / 2) > 24 ? 24 : 100 / (str.Length / 2));
        }

        private WareHouse ButtonClick(WareHouse.Status status, ObservableCollection<WareHouse> array, ListView listView)
        {
            var index = listView.SelectedIndices[0];
            var item = array[index];
            item.WareHouseSet(status, index, array);
            Transaction.TransactionSet(status, item.Num, this);
            return item;
        }
    }
}