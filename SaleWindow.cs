using System;
using System.Linq;
using System.Windows.Forms;

namespace programmingWF
{
    public partial class SaleWindow : Form
    {
        public SaleWindow(MainWindow parent)
        {
            InitializeComponent();
            /*Наполняем список наименований существующими в инвентаре*/
            foreach (var elm in parent.data.Inventory)
                comboBoxName.Items.Add(elm.Name);

            while (true)
            {
                if (ShowDialog(parent) == DialogResult.OK)
                {
                    try
                    {
                        if (comboBoxName.SelectedIndex == - 1)
                            throw new FormatException();
                        var item = parent.data.Inventory[comboBoxName.SelectedIndex];
                        /*Проверяем введенные данные*/
                        if (Convert.ToDouble(textBoxCostSale.Text) < 0 ||
                            Convert.ToInt32(numericCount.Value) > item.Count ||
                            textBoxOrganization.Text == "")
                            throw new FormatException();
                        /*Добавляем позицию в таблицу продажи*/
                        parent.data.Sales.Add(new Sale(
                            item.BarCode,
                            textBoxOrganization.Text,
                            item.Name,
                            textBoxNote.Text,
                            Convert.ToDouble(textBoxCostSale.Text.Replace(',', '.')),
                            dateTimePicker.Value.Date,
                            Convert.ToInt32(numericCount.Value)));
                        /*Добавляем позицию в таблицу транзакций*/
                        parent.data.Transactions.Add(new Transaction(
                            item.BarCode,
                            textBoxOrganization.Text,
                            item.Name,
                            Convert.ToDouble(textBoxCostSale.Text.Replace(',', '.')),
                            Convert.ToInt32(numericCount.Value),
                            Transaction.Type.Sale,
                            parent.data.Sales.Last().Num));
                        /*Обновляем подпись*/
                        parent.LabelChange(parent.labelSaleCount2, (parent.data.CountWaitSale += 1).ToString());
                        return;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Введены неверные значения");
                    }
                }
                else return;
            }
        }
    }
}
