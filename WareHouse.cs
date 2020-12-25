using System;
using System.Windows.Forms;

namespace programmingWF
{
    public abstract class WareHouse
    {
        protected internal enum Status
        {
            Canceled,
            Expectation,
            Completed
        }
        protected internal Status CurStatus { get; set; } = Status.Expectation;
        protected internal abstract ListViewItem GetListViewItem();
        protected internal abstract ListView GetListView(MainWindow parent);
        protected string BarCode { get; set; }
        protected string Organization { get; set; }
        protected string Name { get; set; }
        protected string Note { get; set; }
        protected double CostBuy { get; set; }
        protected double CostSale { get; set; }
        protected int Count { get; set; }
        protected DateTime DueDate { get; set; }
        protected DateTime CreateDate { get; } = DateTime.Now.Date;
        protected string GetStatusString()
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
    }
}
