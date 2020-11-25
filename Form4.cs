using System;
using System.Windows.Forms;

namespace programmingWF
{
    [Serializable]
    public partial class Form4 : Form
    {
        public static readonly double[] memberMean = new double[4];

        public Form4()
        {
            InitializeComponent();
        }

        public bool ShowDialogForm(Form1 parrent, int index = -1)
        {
            while (true)
            {
                if (ShowDialog(parrent) == DialogResult.OK)
                {
                    try
                    {
                        memberMean[0] = Convert.ToDouble(textBoxDocScale.Text.Replace(',', '.'));
                        memberMean[1] = Convert.ToDouble(textBoxDocAngle.Text.Replace(',', '.'));
                        memberMean[2] = Convert.ToDouble(textBoxDocX.Text.Replace(',', '.'));
                        memberMean[3] = Convert.ToDouble(textBoxDocY.Text.Replace(',', '.'));
                        return true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введены неверные значения");
                    }
                }
                else return false;
            }
        }

    }
}
