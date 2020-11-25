using System;
using System.Windows.Forms;

namespace programmingWF
{
    public partial class Form1 : Form
    {
        private Form2 RectangleDialog = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RectangleDialog.ShowDialogRectangle(this);
            //groupBoxCircle.Visible = false;
            //groupBoxCircle.Enabled = false;
            //groupBoxRectangle.Enabled = true;
            //groupBoxRectangle.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //VectorDocument.AddCircle();
            //groupBoxRectangle.Visible = false;
            //groupBoxRectangle.Enabled = false;
            //groupBoxCircle.Enabled = true;
            //groupBoxCircle.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RectangleDialog.ShowDialogRectangle(this, listView1.SelectedIndices[0]);
        }
    }
}
