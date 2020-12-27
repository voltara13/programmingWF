using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace programmingWF
{
    [Serializable]
    internal class Procurement : WareHouse
    {
        /*Конструктор дочернего класса с вызовом родительского конструктора*/
        protected internal Procurement(string barCode, string organization, string name, string note, double cost, DateTime dueDate, int count) 
            : base(barCode, name, count, cost)
        {
            Organization = organization;
            Note = note;
            DueDate = dueDate;
        }
        /*Абстрактная функция возврата действительной таблицы*/
        protected internal override ListView GetListView(MainWindow parent)
        {
            return parent.listViewProcurement;
        }
        /*Виртуальная функция изменения статуса позиции*/
        protected internal override void WareHouseSet(Status status, int index, MainWindow parent)
        {
            /*Если новый статус не равен завершенному, то функция заканчивается*/
            if (status != Status.Completed) return;
            /*Если сумма позиции больше баланса, то выводим соответствующее сообщение*/
            if (Count * Cost > parent.data.Balance)
                throw new ArgumentException();
            /*Проверка на конфликт между существующим в инвентаре элементом*/
            var flagBarCode = parent.data.Inventory.Any(elm => elm.BarCode == BarCode);
            var flagName = parent.data.Inventory.Any(elm => elm.Name == Name);
            if (flagBarCode && !flagName || !flagBarCode && flagName)
                throw new MissingPrimaryKeyException();
            /*Прибавляем позицию к существующей или добавляем новую позицию*/
            var indexInventory = Search(parent.data.Inventory, BarCode);
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
