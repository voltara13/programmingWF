using System;
using System.Linq;
using System.Windows.Forms;

namespace programmingWF
{
    public abstract class WareHouse
    {
        protected WareHouse(string barCode, string name, int count, double cost)
        {
            BarCode = barCode;
            Name = name;
            Count = count;
            Cost = cost;
        }

        protected internal enum Status
        {
            Canceled,
            Expectation,
            Completed
        }
        protected internal Status CurStatus { get; set; } = Status.Expectation;
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
        protected internal abstract ListView GetListView(MainWindow parent);
        protected internal string Num { get; set; } = TransactionEncoding();
        protected internal string BarCode { get; set; }
        protected internal string Organization { get; set; }
        protected internal string Name { get; set; }
        protected internal string Note { get; set; }
        protected internal double Cost { get; set; }
        protected internal int Count { get; set; }
        protected internal DateTime DueDate { get; set; }
        protected internal DateTime CreateDate { get; } = DateTime.Now.Date;

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

        private static string TransactionEncoding()
        {
            return string.Concat(DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK").Where(char.IsDigit));
        }

        protected internal virtual bool Comparison(string str)
        {
            return str == Num;
        }
    }
}
