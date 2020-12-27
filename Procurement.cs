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

        protected internal override void WareHouseSet(Status status, int index, MainWindow parent)
        {
            if (status != Status.Completed) return;
            if (Count * Cost > parent.data.Balance)
                throw new ArgumentException();

            var indexInventory = parent.Search(parent.data.Inventory, BarCode);
            if (indexInventory != -1)
            {
                var itemInventory = parent.data.Inventory[indexInventory];
                itemInventory.Count += Count;
                parent.data.Inventory[indexInventory] = itemInventory;
            }
            else
                parent.data.Inventory.Add(new Inventory(
                    BarCode,
                    Name,
                    Cost,
                    Count));
        }
    }
}
