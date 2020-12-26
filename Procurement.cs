using System;
using System.Windows.Forms;

namespace programmingWF
{
    [Serializable]
    internal class Procurement : WareHouse
    {
        protected internal Procurement(string barCode, string organization, string name, string note, double cost, DateTime dueDate, int count) 
            : base(barCode, name, count, cost)
        {
            Organization = organization;
            Note = note;
            DueDate = dueDate;
        }

        protected internal override ListView GetListView(MainWindow parent)
        {
            return parent.listViewProcurement;
        }
    }
}
