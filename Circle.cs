using System;
using System.Windows.Forms;

namespace programmingWF
{
    [Serializable]
    class Circle : VectorDocument
    {
        private void Edit()
        {
            c = Math.PI * 2 * r;
            s = Math.PI * r * r;
        }
        private byte red, green, blue, alpha;
        private double x, y, r, c, s;
        public Circle()
        {
            ChangeFigure();
        }
        public override void ShowDialogForm(Form1 parrent, int index = -1)
        {
            parrent.dialogCircle.textBoxX.Text = Convert.ToString(x);
            parrent.dialogCircle.textBoxY.Text = Convert.ToString(y);
            parrent.dialogCircle.textBoxRadius.Text = Convert.ToString(r);
            parrent.dialogCircle.textBoxR.Text = Convert.ToString(red);
            parrent.dialogCircle.textBoxG.Text = Convert.ToString(green);
            parrent.dialogCircle.textBoxB.Text = Convert.ToString(blue);
            parrent.dialogCircle.textBoxA.Text = Convert.ToString(alpha);
            if (parrent.dialogCircle.ShowDialogForm(parrent, index))
            {
                ChangeFigure();
                SelectFigure(parrent);
            }
        }
        public override void SelectFigure(Form1 parrent)
        {
            parrent.groupBoxRectangle.Enabled = false;
            parrent.groupBoxRectangle.Visible = false;
            parrent.groupBoxCircle.Visible = true;
            parrent.groupBoxCircle.Enabled = true;
            parrent.labelCircleCenter.Text = $"({Math.Round(x, 2)}; {Math.Round(y, 2)})";
            parrent.labelCircleC.Text = $"{Math.Round(c, 2)}";
            parrent.labelCircleS.Text = $"{Math.Round(s, 2)}";
            parrent.labelCircleR.Text = $"{Math.Round(r, 2)}";
            parrent.labelCircleColor.Text = $"{red}:{green}:{blue}:{alpha}";
        }
        public override void ChangeFigure()
        {
            x = Form3.memberMean[0];
            y = Form3.memberMean[1];
            r = Form3.memberMean[2];
            red = Form3.colorMean[0];
            green = Form3.colorMean[1];
            blue = Form3.colorMean[2];
            alpha = Form3.colorMean[3];
            Edit();
        }
        public override ListViewItem ListViewStr()
        {
            ListViewItem item = new ListViewItem("Окружность");
            item.SubItems.Add($"({x}; {y})");
            item.SubItems.Add($"{red}:{green}:{blue}:{alpha}");
            return item;
        }
        protected override void AngleEdit()
        {
            double _x = x, _y = y, _Angle = Angle * Math.PI / 180;
            x = _x * Math.Cos(_Angle) - _y * Math.Sin(_Angle);
            y = _x * Math.Sin(_Angle) + _y * Math.Cos(_Angle);
        }
        protected override void ScaleEdit()
        {
            double _Scale = Math.Sqrt(Scale);
            r *= _Scale;
            Edit();
        }
        protected override void CenterEdit()
        {
            x += Dx;
            y += Dy;
        }
    }
}
