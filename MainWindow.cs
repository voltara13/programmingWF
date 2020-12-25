using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading;
using System.Windows.Forms;

namespace programmingWF
{
    public partial class MainWindow : Form
    {
        protected internal ObservableCollection<WareHouse> Procurements = new ObservableCollection<WareHouse>();
        protected internal ObservableCollection<WareHouse> Sales = new ObservableCollection<WareHouse>();
        protected internal ObservableCollection<WareHouse> Inventory = new ObservableCollection<WareHouse>();
        protected internal ObservableCollection<WareHouse> Transactions = new ObservableCollection<WareHouse>();
        private int countBid;
        private int countTotal;
        private int countPurch;
        private int countSale;
        private int countWaitPurch;
        private int countWaitSale;
        private int countOverDuePurch;
        private int countOverDueSale;
        public MainWindow()
        {
            Procurements.CollectionChanged += CollectionChanged;
            Sales.CollectionChanged += CollectionChanged;
            Inventory.CollectionChanged += CollectionChanged;
            Transactions.CollectionChanged += CollectionChanged;
            InitializeComponent();
        }
        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    var newItem = e.NewItems[0] as WareHouse; 
                    newItem.GetListView(this).Items.Add(newItem.GetListViewItem());
                    break;
                case NotifyCollectionChangedAction.Replace:
                    var newReplaceItem = e.NewItems[0] as WareHouse;
                    var items = newReplaceItem.GetListView(this).Items;
                    items[e.OldStartingIndex] = newReplaceItem.GetListViewItem();
                    break;
            }
        }
        private void buttonAddPurchase_Click(object sender, EventArgs e)
        {
            new ProcurementWindow(this);
        }
        private void buttonClosePurchase_Click(object sender, EventArgs e)
        {
            var index = listViewProcurement.SelectedIndices[0];
            var itemProcurement = Procurements[index];
            itemProcurement.CurStatus = WareHouse.Status.Completed;
            Procurements[index] = itemProcurement;
            var itemTransaction = Transactions[index];
            itemProcurement.CurStatus = WareHouse.Status.Completed;
            Transactions[index] = itemTransaction;
            countPurch += 1;
            labelPurchaseCount1.Text = countPurch.ToString();
            countBid += 1;
            labelBidCount.Text = countBid.ToString();
        }
        private void buttonCancelPurchase_Click(object sender, EventArgs e)
        {
            var index = listViewProcurement.SelectedIndices[0];
            var itemProcurement = Procurements[index];
            itemProcurement.CurStatus = WareHouse.Status.Canceled;
            Procurements[index] = itemProcurement;
            var itemTransaction = Transactions[index];
            itemTransaction.CurStatus = WareHouse.Status.Canceled;
            Transactions[index] = itemTransaction;
        }
        private void listViewProcurement_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var index = listViewProcurement.SelectedIndices[0];
                if (Procurements[index].CurStatus == WareHouse.Status.Canceled) return;
                buttonCancelPurchase.Enabled = true;
                buttonClosePurchase.Enabled = true;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                buttonCancelPurchase.Enabled = false;
                buttonClosePurchase.Enabled = false;
            }
        }
    }
}
