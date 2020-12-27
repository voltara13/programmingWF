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
        protected internal double Balance { get; set; } = 10000;
        protected internal int CountProc { get; set; }
        protected internal int CountSale { get; set; }
        protected internal int CountWaitProc { get; set; }
        protected internal int CountWaitSale { get; set; }
        protected internal int CountOverDueProc { get; set; }
        protected internal int CountOverDueSale { get; set; }
    }
}
