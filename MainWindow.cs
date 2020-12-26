using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace programmingWF
{
    public partial class MainWindow : Form
    {
        protected internal ObservableCollection<WareHouse> Procurements = new ObservableCollection<WareHouse>();
        protected internal ObservableCollection<WareHouse> Sales = new ObservableCollection<WareHouse>();
        protected internal ObservableCollection<WareHouse> Inventory = new ObservableCollection<WareHouse>();
        protected internal ObservableCollection<WareHouse> Transactions = new ObservableCollection<WareHouse>();
        private int countProc;
        private int countSale;
        private int countWaitProc;
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

        protected internal int Search(ObservableCollection<WareHouse> array, string criterion)
        {
            var index = 0;
            foreach (var elm in array)
                if (elm.Comparison(criterion))
                    return index;
                else index++;
            return -1;
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:

                    var newItem = e.NewItems[0] as WareHouse; 
                    newItem.GetListView(this).Items.Add(newItem.GetListViewItem());
                    labelTotalCount.Text = (Procurements.Count + Sales.Count).ToString();
                    break;

                case NotifyCollectionChangedAction.Remove:

                    var oldItem = e.OldItems[0] as WareHouse;
                    oldItem.GetListView(this).Items.RemoveAt(e.OldStartingIndex);
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
            labelProcurementCount2.Text = (countWaitProc += 1).ToString();
        }

        private void buttonClosePurchase_Click(object sender, EventArgs e)
        {
            var indexProcurement = listViewProcurement.SelectedIndices[0];
            var itemProcurement = Procurements[indexProcurement];
            itemProcurement.CurStatus = WareHouse.Status.Completed;
            Procurements[indexProcurement] = itemProcurement;

            var indexTransaction = Search(Transactions, itemProcurement.Num);
            var itemTransaction = Transactions[indexTransaction];
            itemTransaction.CurStatus = WareHouse.Status.Completed;
            Transactions[indexTransaction] = itemTransaction;

            var indexInventory = Search(Inventory, itemProcurement.BarCode);
            if (indexInventory != -1)
            {
                var itemInventory = Inventory[indexInventory];
                itemInventory.Count += itemProcurement.Count;
                Inventory[indexInventory] = itemInventory;
            }
            else
            {
                Inventory.Add(new Inventory(
                    itemProcurement.BarCode,
                    itemProcurement.Name,
                    itemProcurement.Note,
                    itemProcurement.Cost,
                    itemProcurement.Count));
            }

            labelProcurementCount1.Text = (countProc += 1).ToString();
            labelProcurementCount2.Text = (countWaitProc -= 1).ToString();
            labelBidCount.Text = Inventory.Count.ToString();
        }

        private void buttonCancelPurchase_Click(object sender, EventArgs e)
        {
            var indexProcurement = listViewProcurement.SelectedIndices[0];
            var itemProcurement = Procurements[indexProcurement];
            itemProcurement.CurStatus = WareHouse.Status.Canceled;
            Procurements[indexProcurement] = itemProcurement;

            var indexTransaction = Search(Transactions, itemProcurement.Num);
            var itemTransaction = Transactions[indexTransaction];
            itemTransaction.CurStatus = WareHouse.Status.Canceled;
            Transactions[indexTransaction] = itemTransaction;

            labelProcurementCount2.Text = (countWaitProc -= 1).ToString();
        }

        private void listViewProcurement_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Procurements[listViewProcurement.SelectedIndices[0]].CurStatus != WareHouse.Status.Expectation) return;
                buttonCancelPurchase.Enabled = true;
                buttonClosePurchase.Enabled = true;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                buttonCancelPurchase.Enabled = false;
                buttonClosePurchase.Enabled = false;
            }
        }

        private void buttonAddSale_Click(object sender, EventArgs e)
        {
            new SaleWindow(this);
            labelSaleCount2.Text = (countWaitSale += 1).ToString();
        }

        private void buttonCloseSale_Click(object sender, EventArgs e)
        {
            var indexSale = listViewSale.SelectedIndices[0];
            var itemSale = Sales[indexSale];
            itemSale.CurStatus = WareHouse.Status.Completed;
            Sales[indexSale] = itemSale;

            var indexTransaction = Search(Transactions, itemSale.Num);
            var itemTransaction = Transactions[indexTransaction];
            itemTransaction.CurStatus = WareHouse.Status.Completed;
            Transactions[indexTransaction] = itemTransaction;

            var indexInventory = Search(Inventory, itemSale.BarCode);
            if (itemSale.Count < Inventory[indexInventory].Count)
            {
                var itemInventory = Inventory[indexInventory];
                itemInventory.Count -= itemSale.Count;
                Inventory[indexInventory] = itemInventory;
            }
            else Inventory.RemoveAt(indexInventory);

            labelSaleCount1.Text = (countSale += 1).ToString();
            labelSaleCount2.Text = (countWaitSale -= 1).ToString();
            labelBidCount.Text = Inventory.Count.ToString();
        }

        private void buttonCancelSale_Click(object sender, EventArgs e)
        {
            var indexSale = listViewSale.SelectedIndices[0];
            var itemSale = Sales[indexSale];
            itemSale.CurStatus = WareHouse.Status.Canceled;
            Sales[indexSale] = itemSale;

            var indexTransaction = Search(Transactions, itemSale.Num);
            var itemTransaction = Transactions[indexTransaction];
            itemTransaction.CurStatus = WareHouse.Status.Canceled;
            Transactions[indexTransaction] = itemTransaction;

            labelSaleCount2.Text = (countWaitSale -= 1).ToString();
        }

        private void listViewSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Sales[listViewSale.SelectedIndices[0]].CurStatus != WareHouse.Status.Expectation) return;
                buttonCancelSale.Enabled = true;
                buttonCloseSale.Enabled = true;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                buttonCancelSale.Enabled = false;
                buttonCloseSale.Enabled = false;
            }
        }
    }
}
