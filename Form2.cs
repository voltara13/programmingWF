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
    public partial class Form2 : Form
    {
        public static readonly double[] memberMean = new double[4];
        public static readonly byte[] colorMean = new byte[4];

        public Form2()
        {
            InitializeComponent();
        }

        public void ShowDialogRectangle(Form1 parrent, int index = - 1)
        {
            while (true)
            {
                if (index != -1)
                {
                    textBoxX1.Text = Convert.ToString(VectorDocument.GetFigure(index).X1);
                    textBoxY1.Text = Convert.ToString(VectorDocument.GetFigure(index).Y1);
                    textBoxX2.Text = Convert.ToString(VectorDocument.GetFigure(index).X2);
                    textBoxY2.Text = Convert.ToString(VectorDocument.GetFigure(index).Y2);
                    textBoxR.Text = Convert.ToString(VectorDocument.GetFigure(index).Red);
                    textBoxG.Text = Convert.ToString(VectorDocument.GetFigure(index).Green);
                    textBoxB.Text = Convert.ToString(VectorDocument.GetFigure(index).Blue);
                    textBoxA.Text = Convert.ToString(VectorDocument.GetFigure(index).Alpha);
                }
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
                        item.SubItems.Add($"({memberMean[0]}, {memberMean[1]}); ({memberMean[2]}, {memberMean[3]})");
                        item.SubItems.Add($"{colorMean[0]}:{colorMean[1]}:{colorMean[2]}:{colorMean[3]}");
                        if (index != -1)
                        {
                            VectorDocument.GetFigure(index).X1 = memberMean[0];
                            VectorDocument.GetFigure(index).Y1 = memberMean[1];
                            VectorDocument.GetFigure(index).X2 = memberMean[2];
                            VectorDocument.GetFigure(index).Y2 = memberMean[3];
                            VectorDocument.GetFigure(index).Red = colorMean[0];
                            VectorDocument.GetFigure(index).Green = colorMean[1];
                            VectorDocument.GetFigure(index).Blue = colorMean[2];
                            VectorDocument.GetFigure(index).Alpha = colorMean[3];
                            parrent.listView1.Items.RemoveAt(index);
                            parrent.listView1.Items.Insert(index, item);
                        }
                        else
                        {
                            VectorDocument.AddRectangle();
                            parrent.listView1.Items.Add(item);
                        }

                        ResetDialog();
                        break;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Введены неверные значения");
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Цвет должен быть в формате RGBA (0-255)");
                    }
                }
                else break;
            }
            ResetDialog();
        }

        private void ResetDialog()
        {
            Array.Clear(memberMean, 0, 4);
            Array.Clear(colorMean, 0, 4);
            textBoxX1.Clear();
            textBoxY1.Clear();
            textBoxX2.Clear();
            textBoxY2.Clear();
            textBoxR.Clear();
            textBoxG.Clear();
            textBoxB.Clear();
            textBoxA.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
