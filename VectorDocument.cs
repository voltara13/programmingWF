using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace programmingWF
{
    [Serializable]
    class VectorDocument
    {
        private static double scale = 1, angle = 0, x = 0, y = 0, dx, dy;
        private static List<VectorDocument> VectorDocuments = new List<VectorDocument>();
        protected virtual void PrintDescription() {} //Виртуальная функция вывода свойств фигуры
        protected virtual void ScaleEdit() {} //Виртуальная функция изменения масштаба фигуры
        protected virtual void AngleEdit() {} //Виртуальная функция изменения угла фигуры
        protected virtual void CenterEdit() {} //Виртуальная функция изменения центра фигуры
        protected static double Scale
        {
            get => scale;
            set
            {
                scale = value;
                foreach (var element in VectorDocuments)
                    element.ScaleEdit();
            }
        }
        protected static double Angle
        {
            get => angle;
            set
            {
                angle = value;
                foreach (var element in VectorDocuments)
                    element.AngleEdit();
            }
        }
        public static double Dx => dx;
        public static double Dy => dy;
        public static int Size => VectorDocuments.Count;
        public static void AddCircle()
        {
            VectorDocuments.Add(new Circle());
        } //Функция добавления окружности
        public static void AddRectangle()
        {
            VectorDocuments.Add(new Rectangle());
        } //Функция добавления четырёхугольника
        public static void LabelDocRefresh(Form1 parrent)
        {
            parrent.labelDocScale.Text = $"x{scale}";
            parrent.labelDocAngle.Text = $"{angle}°";
            parrent.labelDocCenter.Text = $"({x}; {y})";
            parrent.listView1.Items.Clear();
            ListViewDoc(parrent);
            if (Size != 0) parrent.clearDocumentButton.Enabled = true;
        } //Функция обновления списка
        public static void EditDocument(Form1 parrent)
        {
            parrent.documentDialog.textBoxDocScale.Text = Convert.ToString(scale);
            parrent.documentDialog.textBoxDocAngle.Text = Convert.ToString(angle);
            parrent.documentDialog.textBoxDocX.Text = Convert.ToString(x);
            parrent.documentDialog.textBoxDocY.Text = Convert.ToString(y);
            if (parrent.documentDialog.ShowDialogForm(parrent))
            {
                Scale = Form4.memberMean[0];
                Angle = Form4.memberMean[1];
                double _x = Form4.memberMean[2];
                double _y = Form4.memberMean[3];
                dx = _x - x;
                dy = _y - y;
                x = _x;
                y = _y;
                foreach (var element in VectorDocuments)
                    element.CenterEdit();
                LabelDocRefresh(parrent);
                parrent.groupBoxCircle.Visible = false;
                parrent.groupBoxCircle.Enabled = false;
                parrent.groupBoxRectangle.Enabled = false;
                parrent.groupBoxRectangle.Visible = false;
            }
        } //Функция изменения параметров документа
        public static void Serialize()
        {
            FieldInfo[] fields = typeof(VectorDocument).GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            object[,] a = new object[fields.Length, 2];
            int i = 0;
            foreach (FieldInfo field in fields)
            {
                a[i, 0] = field.Name;
                a[i, 1] = field.GetValue(null);
                i++;
            };
            Stream f = File.Open("serialize.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(f, a);
            f.Close();

        } //Функция сериализации
        public static void Deserialize(Form1 parrent)
        {
            FieldInfo[] fields = typeof(VectorDocument).GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            object[,] a;
            Stream f = File.Open("serialize.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            a = formatter.Deserialize(f) as object[,];
            f.Close();
            int i = 0;
            foreach (FieldInfo field in fields)
            {
                if (field.Name == (a[i, 0] as string))
                    field.SetValue(null, a[i, 1]);
                i++;
            };
            LabelDocRefresh(parrent);
        } //Функция десериализации
        public static void ClearDocument()
        {
            VectorDocuments.Clear();
            scale = 1;
            angle = 0;
            x = 0;
            y = 0;
        } //Функция очистки документа
        public static void ListViewDoc(Form1 parrent)
        {
            foreach (var element in VectorDocuments)
                parrent.listView1.Items.Add(element.ListViewStr());
        } //Функция изменения списка в приложении
        public static void DeleteFigure(int index)
        {
            VectorDocuments.Remove(VectorDocuments[index]);
        } //Функция удаления фигуры
        public static VectorDocument GetFigure(int index)
        {
            return VectorDocuments[index];
        } //Функция получения ссылки на фигуру
        public virtual ListViewItem ListViewStr() { return null; } //Виртуальная функция добавления параметров фигуры в список приложения
        public virtual void ShowDialogForm(Form1 parrent, int index = -1) {} //Виртуальная функция диалога свойств фигуры
        public virtual void SelectFigure(Form1 parrent) {} //Виртуальная функция выделения фигуры
        public virtual void ChangeFigure() {} //Виртуальная функция изменения свойств фигуры
    }
}
