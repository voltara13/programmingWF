using System.Windows.Forms;

namespace programmingWF
{
    internal class Inventory : WareHouse
    {
        protected internal Inventory(string barCode, string name, string note, double cost, int count) : base(barCode, name, count, cost)
        {
            Note = note;
        }

        protected internal override ListViewItem GetListViewItem()
        {
            var item = new ListViewItem(BarCode);
            item.SubItems.Add(Name);
            item.SubItems.Add(Count.ToString());
            item.SubItems.Add(Cost.ToString());
            item.SubItems.Add(Note);
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
