using System;
using System.Windows.Forms;

namespace programmingWF
{
    [Serializable]
    public partial class Form2 : Form
    {
        public static readonly double[] memberMean = new double[4];
        public static readonly byte[] colorMean = new byte[4];

        public Form2()
        {
            InitializeComponent();
        }

        public bool ShowDialogForm(Form1 parrent, int index = - 1)
        {
            while (true)
            {
                if (ShowDialog(parrent) == DialogResult.OK)
                {
                    try
                    {
                        memberMean[0] = Convert.ToDouble(textBoxX1.Text.Replace(',', '.'));
                        memberMean[1] = Convert.ToDouble(textBoxY1.Text.Replace(',', '.'));
                        memberMean[2] = Convert.ToDouble(textBoxX2.Text.Replace(',', '.'));
                        memberMean[3] = Convert.ToDouble(textBoxY2.Text.Replace(',', '.'));
                        colorMean[0] = Convert.ToByte(textBoxR.Text);
                        colorMean[1] = Convert.ToByte(textBoxG.Text);
                        colorMean[2] = Convert.ToByte(textBoxB.Text);
                        colorMean[3] = Convert.ToByte(textBoxA.Text);
                        ListViewItem item = new ListViewItem("Прямоугольник");
                        item.SubItems.Add($"({memberMean[0]}; {memberMean[1]}), ({memberMean[2]}, {memberMean[3]})");
                        item.SubItems.Add($"{colorMean[0]}:{colorMean[1]}:{colorMean[2]}:{colorMean[3]}");
                        if (index != -1)
                        {
                            VectorDocument.GetFigure(index).ChangeFigure();
                            parrent.listView1.Items.RemoveAt(index);
                            parrent.listView1.Items.Insert(index, item);
                        }
                        else
                        {
                            VectorDocument.AddRectangle();
                            parrent.listView1.Items.Add(item);
                        }
                        parrent.clearDocumentButton.Enabled = true;
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
