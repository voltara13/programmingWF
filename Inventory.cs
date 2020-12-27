using System;
using System.Windows.Forms;

namespace programmingWF
{
    [Serializable]
    internal class Inventory : WareHouse
    {
        /*Конструктор дочернего класса с вызовом родительского конструктора*/
        protected internal Inventory(string barCode, string name, double cost, int count) : base(barCode, name, count, cost) {}
        /*Виртуальный метод возврата строки для таблицы*/
        protected internal override ListViewItem GetListViewItem()
        {
            var item = new ListViewItem(BarCode);
            item.SubItems.Add(Name);
            item.SubItems.Add(Count.ToString());
            item.SubItems.Add(Cost.ToString());
            return item;
        }
        /*Абстрактный метод возврата действительной таблицы*/
        protected internal override ListView GetListView(MainWindow parent)
        {
            return parent.listViewInventory;
        }
        /*Виртуальный метод сравнения*/
        protected internal override bool Comparison(string str)
        {
            return str == BarCode;
        }
    }
}
