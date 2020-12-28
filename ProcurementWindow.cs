using System;
using System.Linq;
using System.Windows.Forms;

namespace programmingWF
{
    internal partial class ProcurementWindow : Form
    {
        protected internal ProcurementWindow(MainWindow parent)
        {
            InitializeComponent();

            while (true)
            {
                if (ShowDialog(parent) == DialogResult.OK)
                {
                    try
                    {
                        /*Проверяем введенные данные*/
                        if (textBoxOrganization.Text == "" ||
                            textBoxName.Text == "" ||
                            !textBoxBarcode.Text.Any(char.IsDigit) ||
                            Convert.ToDouble(textBoxCostBuy.Text.Replace('.', ',')) < 0)
                            throw new System.FormatException();
                        /*Добавляем позицию в таблицу покупки*/
                        parent.data.Procurements.Add(new Procurement(
                            textBoxBarcode.Text,
                            textBoxOrganization.Text,
                            textBoxName.Text,
                            textBoxNote.Text,
                            Convert.ToDouble(textBoxCostBuy.Text.Replace('.', ',')),
                            dateTimePicker.Value,
                            Convert.ToInt32(numericCount.Value)));
                        /*Добавляем позицию в таблицу транзакций*/
                        parent.data.Transactions.Add(new Transaction(
                            textBoxBarcode.Text,
                            textBoxOrganization.Text,
                            textBoxName.Text,
                            Convert.ToDouble(textBoxCostBuy.Text.Replace('.', ',')),
                            Convert.ToInt32(numericCount.Value),
                            Transaction.Type.Purchase,
                            parent.data.Procurements.Last().Num));
                        /*Обновляем подпись и кнопку*/
                        parent.LabelChange(parent.labelProcurementCount2, (parent.data.CountWaitProc += 1).ToString());
                        parent.ButtonCheck();
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
