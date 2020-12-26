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
            foreach (var elm in parent.Inventory)
                comboBoxName.Items.Add(elm.Name);
            while (true)
            {
                if (ShowDialog(parent) == DialogResult.OK)
                {
                    try
                    {
                        var item = parent.Inventory[comboBoxName.SelectedIndex];
                        if (numericCount.Value > item.Count)
                            numericCount.Value = item.Count;
                        parent.Sales.Add(new Sale(
                            item.BarCode,
                            textBoxOrganization.Text,
                            item.Name,
                            textBoxNote.Text,
                            Convert.ToDouble(textBoxCostSale.Text.Replace(',', '.')),
                            dateTimePicker.Value.Date,
                            Convert.ToInt32(numericCount.Value)));
                        parent.Transactions.Add(new Transaction(
                            item.BarCode,
                            textBoxOrganization.Text,
                            item.Name,
                            Convert.ToDouble(textBoxCostSale.Text.Replace(',', '.')),
                            Convert.ToInt32(numericCount.Value),
                            Transaction.Type.Sale,
                            parent.Sales.Last().Num));
                        return;
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Введены неверные значения");
                    }
                }
                else return;
            }
        }
    }
}
