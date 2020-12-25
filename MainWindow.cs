using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace programmingWF
{
    public partial class MainWindow : Form
    {
        protected internal ObservableCollection<Procurement> procurements = new ObservableCollection<Procurement>();
        protected internal ObservableCollection<Sale> sales = new ObservableCollection<Sale>();
        protected internal ObservableCollection<Transaction> transactions = new ObservableCollection<Transaction>();
        protected internal ObservableCollection<Inventory> inventories = new ObservableCollection<Inventory>();

        public MainWindow()
        {
            procurements.CollectionChanged += Procurement_CollectionChanged;
            sales.CollectionChanged += Sale_CollectionChanged;
            transactions.CollectionChanged += Transaction_CollectionChanged;
            inventories.CollectionChanged += Inventory_CollectionChanged;
            InitializeComponent();
            
        }

        private void Procurement_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Procurement newItem = e.NewItems[0] as Procurement;
                    ListViewItem item = new ListViewItem(newItem.BarCode);
                    item.SubItems.Add(newItem.Date.ToString());
                    item.SubItems.Add(newItem.Organization);
                    item.SubItems.Add(newItem.Name);
                    item.SubItems.Add(newItem.Count.ToString());
                    item.SubItems.Add(newItem.Cost.ToString());
                    item.SubItems.Add(newItem.Status);
                    item.SubItems.Add(newItem.Note);
                    listViewProcurement.Items.Add(item);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Procurement oldUser = e.OldItems[0] as Procurement;
                    Console.WriteLine($"Удален объект: ");
                    break;
                case NotifyCollectionChangedAction.Reset:
                    Procurement replacedUser = e.OldItems[0] as Procurement;
                    Procurement replacingUser = e.NewItems[0] as Procurement;
                    Console.WriteLine($"Объект ");
                    break;
            }
        }

        private void Sale_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Sale newUser = e.NewItems[0] as Sale;
                    Console.WriteLine($"Добавлен новый объект: ");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Sale oldUser = e.OldItems[0] as Sale;
                    Console.WriteLine($"Удален объект: ");
                    break;
                case NotifyCollectionChangedAction.Reset:
                    Sale replacedUser = e.OldItems[0] as Sale;
                    Sale replacingUser = e.NewItems[0] as Sale;
                    Console.WriteLine($"Объект ");
                    break;
            }
        }

        private void Transaction_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Transaction newUser = e.NewItems[0] as Transaction;
                    Console.WriteLine($"Добавлен новый объект: ");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Transaction oldUser = e.OldItems[0] as Transaction;
                    Console.WriteLine($"Удален объект: ");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Transaction replacedUser = e.OldItems[0] as Transaction;
                    Transaction replacingUser = e.NewItems[0] as Transaction;
                    Console.WriteLine($"Объект ");
                    break;
            }
        }
        private void Inventory_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Inventory newUser = e.NewItems[0] as Inventory;
                    Console.WriteLine($"Добавлен новый объект: ");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Inventory oldUser = e.OldItems[0] as Inventory;
                    Console.WriteLine($"Удален объект: ");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Inventory replacedUser = e.OldItems[0] as Inventory;
                    Inventory replacingUser = e.NewItems[0] as Inventory;
                    Console.WriteLine($"Объект ");
                    break;
            }
        }

        private void buttonAddPurchase_Click(object sender, EventArgs e)
        {
            ProcurementWindow window = new ProcurementWindow(this);
        }
    }
}
