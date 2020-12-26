﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace programmingWF
{
    internal class Transaction : WareHouse
    {
        private readonly double Sum;
        private Type CurType { get; }
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
        protected internal enum Type
        {
            Purchase,
            Sale
        }
        protected internal Transaction(string barCode, string organization, string name, double cost, int count, Type type, string num) : base(barCode, name, count, cost)
        {
            Organization = organization;
            CurType = type;
            Sum = cost * count;
            Num = num;
        }
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
        protected internal override ListView GetListView(MainWindow parent)
        {
            return parent.listViewTransactions;
        }
    }
}
