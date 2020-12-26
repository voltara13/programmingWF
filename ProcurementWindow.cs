using System;
using System.Linq;
using System.Windows.Forms;

namespace programmingWF
{
    public partial class ProcurementWindow : Form
    {
        protected internal void IsDigits(string str)
        {
            if (!str.Any(char.IsDigit))
                throw new System.FormatException();
        }
        public ProcurementWindow(MainWindow parent)
        {
            InitializeComponent();
            while (true)
            {
                if (ShowDialog(parent) == DialogResult.OK)
                {
                    try
                    {
                        IsDigits(textBoxBarcode.Text);
                        var index = parent.Search(parent.Inventory, textBoxBarcode.Text);
                        if (index != - 1 && textBoxName.Text != parent.Inventory[index].Name)
                            throw new System.FormatException();
                        parent.Procurements.Add(new Procurement(
                            textBoxBarcode.Text,
                            textBoxOrganization.Text,
                            textBoxName.Text,
                            textBoxNote.Text,
                            Convert.ToDouble(textBoxCostBuy.Text.Replace(',', '.')),
                            dateTimePicker.Value,
                            Convert.ToInt32(numericCount.Value)));
                        parent.Transactions.Add(new Transaction(
                            textBoxBarcode.Text,
                            textBoxOrganization.Text,
                            textBoxName.Text,
                            Convert.ToDouble(textBoxCostBuy.Text.Replace(',', '.')),
                            Convert.ToInt32(numericCount.Value),
                            Transaction.Type.Purchase,
                            parent.Procurements.Last().Num));
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
