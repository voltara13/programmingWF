using System;
using System.Windows.Forms;

namespace programmingWF
{
    [Serializable]
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public Form2 dialogRectangle = new Form2();
        public Form3 dialogCircle = new Form3();
        public Form4 documentDialog = new Form4();
        private void addRectangleButton_Click(object sender, EventArgs e)
        {
            Form2 dialogRectangle = new Form2();
            dialogRectangle.ShowDialogForm(this);
        }
        private void addCircleButton_Click(object sender, EventArgs e)
        {
            Form3 dialogCircle = new Form3();
            dialogCircle.ShowDialogForm(this);
        }
        private void clearDocumentButton_Click(object sender, EventArgs e)
        {
            VectorDocument.ClearDocument();
            Controls.Clear();
            InitializeComponent();
        }
        private void deleteElementButton_Click(object sender, EventArgs e)
        {
            VectorDocument.DeleteFigure(listView1.SelectedIndices[0]);
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            groupBoxCircle.Visible = false;
            groupBoxCircle.Enabled = false;
            groupBoxRectangle.Enabled = false;
            groupBoxRectangle.Visible = false;
            if (VectorDocument.Size == 0) clearDocumentButton.Enabled = false;
        }
        private void saveDocumentButton_Click(object sender, EventArgs e)
        {
            VectorDocument.Serialize();
        }
        private void loadDocumentButton_Click(object sender, EventArgs e)
        {
            VectorDocument.Deserialize(this);
        }
        private void changeDocumentButton_Click(object sender, EventArgs e)
        {
            VectorDocument.EditDocument(this);
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VectorDocument.GetFigure(listView1.SelectedIndices[0]).ShowDialogForm(this, listView1.SelectedIndices[0]);
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            VectorDocument.GetFigure(listView1.SelectedIndices[0]).SelectFigure(this);
            deleteElementButton.Enabled = true;
        }
    }
}
