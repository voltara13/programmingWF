using System;
using System.Drawing;
using System.Windows.Forms;

namespace programmingWF
{
    [Serializable]
    internal class Transaction : WareHouse
    {
        /*Перечисляемый тип типа транзакции*/
        protected internal enum Type
        {
            Purchase,
            Sale
        }
        /*Конструктор дочернего класса с вызовом родительского конструктора*/
        protected internal Transaction(string barCode, string organization, string name, double cost, int count, Type type, string num) : base(barCode, name, count, cost)
        {
            Organization = organization;
            CurType = type;
            Sum = cost * count;
            Num = num;
        }
        /*Поле суммы*/
        protected internal readonly double Sum;
        /*Поле типа транзакции*/
        private readonly Type CurType;
        /*Виртуальная функция возврата строки для таблицы*/
        protected internal override ListViewItem GetListViewItem()
        {
            var item = new ListViewItem(Num);
            item.SubItems.Add(BarCode);
            item.SubItems.Add(CreateDate.ToShortDateString());
            item.SubItems.Add(Organization);
            item.SubItems.Add(GetTypeString());
            item.SubItems.Add(Sum.ToString());
            item.SubItems.Add(GetStatusString());
            item.UseItemStyleForSubItems = false;
            item.SubItems[4].ForeColor = GetColor();
            return item;
        }
        /*Абстрактная функция возврата действительной таблицы*/
        protected internal override ListView GetListView(MainWindow parent)
        {
            return parent.listViewTransactions;
        }
        /*Функция возврата типа транзакции в виде строки*/
        private string GetTypeString()
        {
            switch (CurType)
            {
                case Type.Purchase:
                    return "Покупка";
                case Type.Sale:
                    return "Продажа";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        /*Функция возврата необходимого цвета*/
        private Color GetColor()
        {
            switch (CurType)
            {
                case Type.Purchase:
                    return Color.Red;
                case Type.Sale:
                    return Color.Chartreuse;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        /*Функция смены статуса транзакции*/
        protected internal static void TransactionSet(Status status, string num, MainWindow parent)
        {
            var indexTransaction = Search(parent.data.Transactions, num);
            var itemTransaction = parent.data.Transactions[indexTransaction];
            itemTransaction.CurStatus = status;
            parent.data.Transactions[indexTransaction] = itemTransaction;
        }
    }
}
