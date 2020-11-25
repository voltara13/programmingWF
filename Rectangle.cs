using System;

namespace programmingWF
{
    [Serializable]
    class Rectangle : VectorDocument
    {
        public Rectangle()
        {
            ChangeFigure();
        }
        public override double X1
        {
            get => x1;
            set => x1 = value;
        }
        public override double Y1
        {
            get => y1;
            set => y1 = value;
        }
        public override double X2
        {
            get => x2;
            set => x2 = value;
        }
        public override double Y2
        {
            get => y2;
            set => y2 = value;
        }
        public override byte Red
        {
            get => red;
            set => red = value;
        }
        public override byte Green
        {
            get => green;
            set => green = value;
        }
        public override byte Blue
        {
            get => blue;
            set => blue = value;
        }
        public override byte Alpha
        {
            get => alpha;
            set => alpha = value;
        }
        private byte red, green, blue, alpha;
        private double x1, y1, x2, y2, d, c, s;
        private void Edit()
        {
            d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            c = 2 * d * Math.Sqrt(2);
            s = d * d / 2;
        }
        protected override void AngleEdit()
        {
            double _x1 = x1, _y1 = y1, _x2 = x2, _y2 = y2, _Angle = Angle * Math.PI / 180; ;
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
        protected override void ChangeFigure()
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
    }
}