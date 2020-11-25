using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

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
        }
        public static void AddRectangle()
        {
            VectorDocuments.Add(new Rectangle());
        }
        public static void EditDocument()
        {
            while (true)
            {
                int ans;
                Console.Write("\nВведите:\n" +
                              "'1' - Чтобы изменить масштаб документа\n" +
                              "'2' - Чтобы изменить угол документа\n" +
                              "'3' - Чтобы изменить центр документа\n" +
                              "'4' - Чтобы вывести информацию о документе\n" +
                              "'0' - Чтобы выйти в меню\n" +
                              "ВВОД: ");
                ans = Convert.ToInt32(Console.ReadLine());
                switch (ans)
                {
                    case 1:
                        Console.Write("Новый масштаб документа: ");
                        Scale = Convert.ToDouble(Console.ReadLine());
                        return;
                    case 2:
                        Console.Write("Новый угол документа: ");
                        Angle = Convert.ToDouble(Console.ReadLine());
                        return;
                    case 3:
                        while (true)
                        {
                            Console.Write("Новые координаты центра в формате 'x y': ");
                            string temp = Console.ReadLine();
                            string[] splitString = temp.Split(' ');
                            if (splitString.Length == 2 &&
                                double.TryParse(splitString[0], out double _x) &&
                                double.TryParse(splitString[1], out double _y))
                            {
                                dx = _x - x;
                                dy = _y - y;
                                x = _x;
                                y = _y;
                                foreach (var element in VectorDocuments)
                                    element.CenterEdit();
                                break;
                            }
                            Console.Write("\nНеверный ввод. Попробуйте ещё раз\n");
                        }
                        return;
                    case 4:
                        Console.Write("Сведения о документе\n" +
                                      $"Центр документа: ({x}, {y})\n" +
                                      $"Масштаб документа: x{scale}\n" +
                                      $"Угол поворота документа: {angle}°\n" +
                                      $"Количество фигур: {Size}\n");
                        return;
                    case 0:
                        return;
                    default:
                        Console.Write("\nВыбран неверный вариант. Попробуйте ещё раз\n");
                        break;
                }
            }
        }
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
        }
        public static void Deserialize()
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
        }
        public static void ClearDocument()
        {
            VectorDocuments.Clear();
            scale = 1;
            angle = 0;
            x = 0;
            y = 0;
        }
        public static void DeleteFigure(int index)
        {
            VectorDocuments.Remove(VectorDocuments[index]);
        }
        public static VectorDocument GetFigure(int index)
        {
            return VectorDocuments[index];
        }

        public virtual void ShowDialogForm(Form1 parrent, int index = -1) {}
        public virtual void SelectFigure(Form1 parrent) {}
        public virtual void ChangeFigure() {} //Виртуальная функция изменения свойств фигуры
    }
}
