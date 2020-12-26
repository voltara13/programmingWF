using System;
using System.Collections.ObjectModel;

namespace programmingWF
{
    [Serializable]
    public class Data
    {
        protected internal ObservableCollection<WareHouse> Procurements = new ObservableCollection<WareHouse>();
        protected internal ObservableCollection<WareHouse> Sales = new ObservableCollection<WareHouse>();
        protected internal ObservableCollection<WareHouse> Inventory = new ObservableCollection<WareHouse>();
        protected internal ObservableCollection<WareHouse> Transactions = new ObservableCollection<WareHouse>();
        protected internal double balance;
        protected internal int countProc;
        protected internal int countSale;
        protected internal int countWaitProc;
        protected internal int countWaitSale;
        protected internal int countOverDueProc;
        protected internal int countOverDueSale;
    }
}
