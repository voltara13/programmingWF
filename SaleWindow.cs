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

            foreach (var elm in parent.data.Inventory)
                comboBoxName.Items.Add(elm.Name);

            while (true)
            {
                if (ShowDialog(parent) == DialogResult.OK)
                {
                    try
                    {
                        var item = parent.data.Inventory[comboBoxName.SelectedIndex];

                        numericCount.Maximum = item.Count;

                        if (Convert.ToDouble(textBoxCostSale.Text) < 0 || 
                            textBoxOrganization.Text == "")
                            throw new FormatException();

                        parent.data.Sales.Add(new Sale(
                            item.BarCode,
                            textBoxOrganization.Text,
                            item.Name,
                            textBoxNote.Text,
                            Convert.ToDouble(textBoxCostSale.Text.Replace(',', '.')),
                            dateTimePicker.Value.Date,
                            Convert.ToInt32(numericCount.Value)));

                        parent.data.Transactions.Add(new Transaction(
                            item.BarCode,
                            textBoxOrganization.Text,
                            item.Name,
                            Convert.ToDouble(textBoxCostSale.Text.Replace(',', '.')),
                            Convert.ToInt32(numericCount.Value),
                            Transaction.Type.Sale,
                            parent.data.Sales.Last().Num));

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
