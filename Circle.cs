using System;

namespace programmingWF
{
    [Serializable]
    class Circle : VectorDocument
    {
        private Form3 dialogCircle = new Form3();
        public Circle()
        {
            ChangeFigure();
        }
        private byte red, green, blue, alpha;
        private double x, y, r, c, s;
        private void Edit()
        {
            c = Math.PI * 2 * r;
            s = Math.PI * r * r;
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
        public override void ShowDialogForm(Form1 parrent, int index = -1)
        {
            dialogCircle.textBoxX.Text = Convert.ToString(x);
            dialogCircle.textBoxY.Text = Convert.ToString(y);
            dialogCircle.textBoxRadius.Text = Convert.ToString(r);
            dialogCircle.textBoxR.Text = Convert.ToString(red);
            dialogCircle.textBoxG.Text = Convert.ToString(green);
            dialogCircle.textBoxB.Text = Convert.ToString(blue);
            dialogCircle.textBoxA.Text = Convert.ToString(alpha);
            dialogCircle.ShowDialogForm(parrent, index);
            ChangeFigure();
            SelectFigure(parrent);
        }
        public override void SelectFigure(Form1 parrent)
        {
            parrent.groupBoxRectangle.Enabled = false;
            parrent.groupBoxRectangle.Visible = false;
            parrent.groupBoxCircle.Visible = true;
            parrent.groupBoxCircle.Enabled = true;
            parrent.labelCircleCenter.Text = $"({x}; {y})";
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
    }
}
