using System;
using System.Windows.Forms;

namespace programmingWF
{
    internal class Inventory : WareHouse
    {
        protected internal Inventory(string barCode, string name, string note, double costBuy, int count)
        {
            BarCode = barCode;
            Name = name;
            CostBuy = costBuy;
            Count = count;
            Note = note;
        }
        protected internal override ListViewItem GetListViewItem()
        {
            ListViewItem item = new ListViewItem(BarCode);
            item.SubItems.Add(Name);
            item.SubItems.Add(Count.ToString());
            item.SubItems.Add(CostBuy.ToString());
            item.SubItems.Add(CostSale.ToString());
            item.SubItems.Add(Note);
            return item;
        }

        protected internal override ListView GetListView(MainWindow parent)
        {
            return parent.listViewInventory;
        }
    }
}
