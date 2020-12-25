using System;
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
                        parent.Procurements.Add(new Procurement(
                            textBoxBarcode.Text,
                            textBoxOrganization.Text,
                            textBoxName.Text,
                            textBoxNote.Text,
                            Convert.ToDouble(textBoxCostBuy.Text.Replace(',', '.')),
                            dateTimePicker.Value.Date,
                            Convert.ToInt32(numericCount.Value)));
                        parent.Transactions.Add(new Transaction(
                            textBoxBarcode.Text,
                            textBoxOrganization.Text,
                            textBoxName.Text,
                            Convert.ToDouble(textBoxCostBuy.Text.Replace(',', '.')),
                            Convert.ToInt32(numericCount.Value),
                            Transaction.Type.Purchase));
                        return;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введены неверные значения");
                    }
                }
                else return;
            }
        }
    }
}
