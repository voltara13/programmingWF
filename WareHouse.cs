using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace programmingWF
{
    [Serializable]
    public abstract class WareHouse
    {
        /*Перечисляемый тип статуса*/
        protected internal enum Status
        {
            Canceled,
            Expectation,
            Completed
        }
        /*Конструктор абстрактного обобщающего класса*/
        protected WareHouse(string barCode, string name, int count, double cost)
        {
            BarCode = barCode;
            Name = name;
            Count = count;
            Cost = cost;
        }
        /*Уникальный номер каждой позиции (строится на основе времени создания)*/
        protected internal string Num { get; set; } = TransactionEncoding();
        /*Наименование организации*/
        protected internal string Organization { get; set; }
        /*Наименование товара*/
        protected internal string Name { get; }
        /*Примечание*/
        protected internal string Note { get; set; }
        /*Количество*/
        protected internal int Count { get; set; }
        /*Статус (по-умолчанию "Ожидание")*/
        protected internal Status CurStatus { get; set; } = Status.Expectation;
        /*Дата исполнения*/
        protected internal DateTime DueDate { get; set; }
        /*Дата создания*/
        protected internal DateTime CreateDate { get; } = DateTime.Now.Date;
        /*Штрихкод*/
        protected internal string BarCode { get; }
        /*Цена*/
        protected internal double Cost { get; }
        /*Абстрактный метод возврата действительной таблицы*/
        protected internal abstract ListView GetListView(MainWindow parent);
        /*Виртуальный метод изменения статуса позиции*/
        protected internal virtual void WareHouseSet(Status status, int index, MainWindow parent) {}
        /*Виртуальный метод возврата строки для таблицы*/
        protected internal virtual ListViewItem GetListViewItem()
        {
            var item = new ListViewItem(BarCode);
            item.SubItems.Add(DueDate.ToShortDateString());
            item.SubItems.Add(Organization);
            item.SubItems.Add(Name);
            item.SubItems.Add(Count.ToString());
            item.SubItems.Add(Cost.ToString());
            item.SubItems.Add(GetStatusString());
            item.SubItems.Add(Note);
            return item;
        }
        /*Метод возврата статуса в виде строки*/
        protected internal string GetStatusString()
        {
            switch (CurStatus) 
            {
                case Status.Canceled:
                    return "Отменено";
                case Status.Expectation:
                    return "Ожидание";
                case Status.Completed:
                    return "Завершено";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        /*Виртуальный метод сравнения*/
        protected internal virtual bool Comparison(string str)
        {
            return str == Num;
        }
        /*Метод поиска элемента по какому-либо значению
         в заданном массиве и дальнейшего вывода его индекса*/
        protected internal static int Search(ObservableCollection<WareHouse> array, string criterion)
        {
            var index = 0;
            foreach (var elm in array)
                if (elm.Comparison(criterion))
                    return index;
                else index++;
            return -1;
        }
        /*Преобразование времени создания в уникальную строку*/
        private static string TransactionEncoding()
        {
            return string.Concat(DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK").Where(char.IsDigit));
        }
    }
}
