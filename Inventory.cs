using System;
using System.Windows.Forms;

namespace programmingWF
{
    [Serializable]
    internal class Inventory : WareHouse
    {
        protected internal Inventory(string barCode, string name, double cost, int count) : base(barCode, name, count, cost) {}

        protected internal override ListViewItem GetListViewItem()
        {
            var item = new ListViewItem(BarCode);
            item.SubItems.Add(Name);
            item.SubItems.Add(Count.ToString());
            item.SubItems.Add(Cost.ToString());
            return item;
        }

        protected internal override ListView GetListView(MainWindow parent)
        {
            return parent.listViewInventory;
        }

        protected internal override bool Comparison(string str)
        {
            return str == BarCode;
        }
    }
}
