using System;
using System.Windows.Forms;

namespace programmingWF
{
    [Serializable]
    internal class Sale : WareHouse
    {
        /*Конструктор дочернего класса с вызовом родительского конструктора*/
        protected internal Sale(string barCode, string organization, string name, string note, double cost, DateTime dueDate, int count) 
            : base(barCode, name, count, cost)
        {
            Organization = organization;
            Note = note;
            DueDate = dueDate;
        }
        /*Абстрактный метод возврата действительной таблицы*/
        protected internal override ListView GetListView(MainWindow parent)
        {
            return parent.listViewSale;
        }
        /*Виртуальный метод изменения статуса позиции*/
        protected internal override void WareHouseSet(Status status, int index, MainWindow parent)
        {
            /*Если новый статус не равен завершенному, то функция заканчивается*/
            if (status != Status.Completed) return;
            /*Отнимаем позицию от существующей или,
             если недостаточно предметов на складе для закрытия, выводим сообщение или
             убираем существующую позицию*/
            var indexInventory = Search(parent.data.Inventory, BarCode);
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