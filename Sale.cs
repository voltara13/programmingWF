using System;
using System.Windows.Forms;

namespace programmingWF
{
    [Serializable]
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

        protected internal override void WareHouseSet(Status status, int index, MainWindow parent)
        {
            if (status != Status.Completed) return;
            var indexInventory = parent.Search(parent.data.Inventory, BarCode);
            if (Count < parent.data.Inventory[indexInventory].Count)
            {
                var itemInventory = parent.data.Inventory[indexInventory];
                itemInventory.Count -= Count;
                parent.data.Inventory[indexInventory] = itemInventory;
            }
            else if (Count > parent.data.Inventory[indexInventory].Count)
                throw new ArgumentException();
            else parent.data.Inventory.RemoveAt(indexInventory);
        }
    }
}