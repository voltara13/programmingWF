using System;
using System.Linq;
using System.Windows.Forms;

namespace programmingWF
{
    public partial class ProcurementWindow : Form
    {
        public ProcurementWindow(MainWindow parent)
        {
            InitializeComponent();

            while (true)
            {
                if (ShowDialog(parent) == DialogResult.OK)
                {
                    try
                    {
                        if (!textBoxBarcode.Text.Any(char.IsDigit))
                            throw new System.FormatException();
                        var index = parent.Search(parent.data.Inventory, textBoxBarcode.Text);
                        if (index != - 1 && textBoxName.Text != parent.data.Inventory[index].Name)
                            throw new System.FormatException();

                        if (Convert.ToInt32(numericCount.Value) * Convert.ToDouble(textBoxCostBuy.Text) >
                            parent.data.balance)
                            throw new ArgumentException();

                        if (Convert.ToDouble(textBoxCostBuy.Text) < 0)
                            throw new FormatException();

                        parent.data.Procurements.Add(new Procurement(
                            textBoxBarcode.Text,
                            textBoxOrganization.Text,
                            textBoxName.Text,
                            textBoxNote.Text,
                            Convert.ToDouble(textBoxCostBuy.Text.Replace(',', '.')),
                            dateTimePicker.Value,
                            Convert.ToInt32(numericCount.Value)));

                        parent.data.Transactions.Add(new Transaction(
                            textBoxBarcode.Text,
                            textBoxOrganization.Text,
                            textBoxName.Text,
                            Convert.ToDouble(textBoxCostBuy.Text.Replace(',', '.')),
                            Convert.ToInt32(numericCount.Value),
                            Transaction.Type.Purchase,
                            parent.data.Procurements.Last().Num));

                        return;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Введены неверные значения");
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Недостаточно средств");
                    }
                }
                else return;
            }
        }
    }
}
