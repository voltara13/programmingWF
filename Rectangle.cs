using System;
using System.Windows.Forms;

namespace programmingWF
{
    [Serializable]
    class Rectangle : VectorDocument
    {
        private void Edit()
        {
            d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            c = 2 * d * Math.Sqrt(2);
            s = d * d / 2;
        }
        private byte red, green, blue, alpha;
        private double x1, y1, x2, y2, d, c, s;
        public Rectangle()
        {
            ChangeFigure();
        }
        public override void ShowDialogForm(Form1 parrent, int index)
        {
            parrent.dialogRectangle.textBoxX1.Text = Convert.ToString(x1);
            parrent.dialogRectangle.textBoxY1.Text = Convert.ToString(y1);
            parrent.dialogRectangle.textBoxX2.Text = Convert.ToString(x2);
            parrent.dialogRectangle.textBoxY2.Text = Convert.ToString(y2);
            parrent.dialogRectangle.textBoxR.Text = Convert.ToString(red);
            parrent.dialogRectangle.textBoxG.Text = Convert.ToString(green);
            parrent.dialogRectangle.textBoxB.Text = Convert.ToString(blue);
            parrent.dialogRectangle.textBoxA.Text = Convert.ToString(alpha);
            if (parrent.dialogRectangle.ShowDialogForm(parrent, index))
            {
                ChangeFigure();
                SelectFigure(parrent);
            }
        }
        public override void SelectFigure(Form1 parrent)
        {
            parrent.groupBoxCircle.Visible = false;
            parrent.groupBoxCircle.Enabled = false;
            parrent.groupBoxRectangle.Enabled = true;
            parrent.groupBoxRectangle.Visible = true;
            parrent.labelRectangleVertex.Text = $"({Math.Round(x1, 2)}; {Math.Round(y1, 2)}), ({Math.Round(x2, 2)}; {Math.Round(y2, 2)})";
            parrent.labelRectangleD.Text = $"{Math.Round(d, 2)}";
            parrent.labelRectangleC.Text = $"{Math.Round(c, 2)}";
            parrent.labelRectangleS.Text = $"{Math.Round(s, 2)}";
            parrent.labelRectangleColor.Text = $"{red}:{green}:{blue}:{alpha}";
        }
        public override void ChangeFigure()
        {
            x1 = Form2.memberMean[0];
            y1 = Form2.memberMean[1];
            x2 = Form2.memberMean[2];
            y2 = Form2.memberMean[3];
            red = Form2.colorMean[0];
            green = Form2.colorMean[1];
            blue = Form2.colorMean[2];
            alpha = Form2.colorMean[3];
            Edit();
        }
        public override ListViewItem ListViewStr()
        {
            ListViewItem item = new ListViewItem("Прямоугольник");
            item.SubItems.Add($"({x1}; {y1}), ({x2}, {y2})");
            item.SubItems.Add($"{red}:{green}:{blue}:{alpha}");
            return item;
        }
        protected override void AngleEdit()
        {
            double _x1 = x1, _y1 = y1, _x2 = x2, _y2 = y2, _Angle = Dangle * Math.PI / 180; ;
            x1 = _x1 * Math.Cos(_Angle) - _y1 * Math.Sin(_Angle);
            y1 = _x1 * Math.Sin(_Angle) + _y1 * Math.Cos(_Angle);
            x2 = _x2 * Math.Cos(_Angle) - _y2 * Math.Sin(_Angle);
            y2 = _x2 * Math.Sin(_Angle) + _y2 * Math.Cos(_Angle);
        }
        protected override void ScaleEdit()
        {
            double _Scale = Math.Sqrt(Scale);
            x1 *= _Scale;
            y1 *= _Scale;
            x2 *= _Scale;
            y2 *= _Scale;
            Edit();
        }
        protected override void CenterEdit()
        {
            x1 += Dx;
            y1 += Dy;
            x2 += Dx;
            y2 += Dy;
        }
    }
}