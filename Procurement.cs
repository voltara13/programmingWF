using System;
using System.Windows.Forms;

namespace programmingWF
{
    internal class Procurement : WareHouse
    {
        protected internal Procurement(string barCode, string organization, string name, string note, double cost, DateTime dueDate, int count)
        {
            BarCode = barCode;
            Organization = organization;
            Name = name;
            Note = note;
            DueDate = dueDate;
            Cost = cost;
            Count = count;
        }
        protected internal override ListViewItem GetListViewItem()
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
        protected internal override ListView GetListView(MainWindow parent)
        {
            return parent.listViewProcurement;
        }
    }
}
