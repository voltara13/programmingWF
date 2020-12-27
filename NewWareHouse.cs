using System;
using System.Windows.Forms;

namespace programmingWF
{
    internal partial class NewWareHouse : Form
    {
        protected internal NewWareHouse(MainWindow parent)
        {
            InitializeComponent();

            while (true)
            {
                if (ShowDialog(parent) == DialogResult.OK)
                {
                    try
                    {
                        if (Convert.ToDouble(textBoxBalance.Text) < 0)
                            throw new FormatException();

                        parent.data.Balance = Convert.ToDouble(textBoxBalance.Text.Replace(',', '.'));
                        return;
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Введен неверный баланс");
                    }
                }
                else return;
            }
        }
    }
}
