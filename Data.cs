using System;
using System.Collections.ObjectModel;

namespace programmingWF
{
    [Serializable]
    public class Data
    {
        /*Наблюдаемый массив, состоящий из позиций покупок*/
        protected internal ObservableCollection<WareHouse> Procurements = new ObservableCollection<WareHouse>();
        /*Наблюдаемый массив, состоящий из позиций продаж*/
        protected internal ObservableCollection<WareHouse> Sales = new ObservableCollection<WareHouse>();
        /*Наблюдаемый массив, состоящий из позиций инвентаря*/
        protected internal ObservableCollection<WareHouse> Inventory = new ObservableCollection<WareHouse>();
        /*Наблюдаемый массив, состоящий из позиций транзакций*/
        protected internal ObservableCollection<WareHouse> Transactions = new ObservableCollection<WareHouse>();
        /*Баланс склада*/
        protected internal double Balance { get; set; }
        /*Количество исполненных заявок на закупку*/
        protected internal int CountProc { get; set; }
        /*Количество исполненных заявок на продажу*/
        protected internal int CountSale { get; set; }
        /*Количество ожидающих исполнения заявок на закупку*/
        protected internal int CountWaitProc { get; set; }
        /*Количество ожидающих исполнения заявок на продажу*/
        protected internal int CountWaitSale { get; set; }
        /*Количество просроченных заявок на закупку*/
        protected internal int CountOverDueProc { get; set; }
        /*Количество просроченных заявок на продажу*/
        protected internal int CountOverDueSale { get; set; }
    }
}
