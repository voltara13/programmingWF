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
                        parent.procurements.Add(new Procurement(
                            textBoxBarcode.Text,
                            textBoxOrganization.Text,
                            textBoxName.Text,
                            textBoxNote.Text,
                            Convert.ToDouble(textBoxCost.Text.Replace(',', '.')),
                            dateTimePicker.Value,
                            Convert.ToInt32(numericCount.Value)
                        ));
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
