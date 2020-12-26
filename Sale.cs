using System;
using System.Windows.Forms;

namespace programmingWF
{
    internal class Sale : WareHouse
    {
        protected internal Sale(string barCode, string organization, string name, string note, double cost, DateTime dueDate, int count) 
            : base(barCode, name, count, cost)
        {
            Organization = organization;
            Note = note;
            DueDate = dueDate;
        }

        protected internal override ListView GetListView(MainWindow parent)
        {
            return parent.listViewSale;
        }
    }
}