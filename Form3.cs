using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmingWF
{
    public partial class Form3 : Form
    {
        public static readonly double[] memberMean = new double[3];
        public static readonly byte[] colorMean = new byte[4];

        public Form3()
        {
            InitializeComponent();
        }

        public void ShowDialogForm(Form1 parrent, int index = -1)
        {
            while (true)
            {
                if (ShowDialog(parrent) == DialogResult.OK)
                {
                    try
                    {
                        memberMean[0] = Convert.ToDouble(textBoxX.Text.Replace(',', '.'));
                        memberMean[1] = Convert.ToDouble(textBoxY.Text.Replace(',', '.'));
                        memberMean[2] = Convert.ToDouble(textBoxRadius.Text.Replace(',', '.'));
                        colorMean[0] = Convert.ToByte(textBoxR.Text);
                        colorMean[1] = Convert.ToByte(textBoxG.Text);
                        colorMean[2] = Convert.ToByte(textBoxB.Text);
                        colorMean[3] = Convert.ToByte(textBoxA.Text);
                        ListViewItem item = new ListViewItem("Окружность");
                        item.SubItems.Add($"({memberMean[0]}; {memberMean[1]})");
                        item.SubItems.Add($"{colorMean[0]}:{colorMean[1]}:{colorMean[2]}:{colorMean[3]}");
                        if (index != -1)
                        {
                            VectorDocument.GetFigure(index).ChangeFigure();
                            parrent.listView1.Items.RemoveAt(index);
                            parrent.listView1.Items.Insert(index, item);
                        }
                        else
                        {
                            VectorDocument.AddCircle();
                            parrent.listView1.Items.Add(item);
                        }
                        parrent.clearDocumentButton.Enabled = true;
                        break;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введены неверные значения");
                    }
                }
                else break;
            }
        }
    }
}
