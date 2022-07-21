using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using System.Collections.ObjectModel;

namespace CKK.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class InventoryManagementForm : Window
    {
        private IStore Store;
        private ObservableCollection<StoreItem> Items;

        public ObservableCollection<StoreItem> _Items
        {
            get { return Items; }
            private set { Items = value; }
        }
        public InventoryManagementForm()
        {
            Store = new Store();
            InitializeComponent();
            _Items = new ObservableCollection<StoreItem>();
            //LISTBOXNAMEHERE.ItemsSource = _Items;
            RefreshList();
        }

        private void RefreshList()
        {
            Items.Clear();
            foreach (StoreItem item in new ObservableCollection<StoreItem>(Store.GetStoreItems())) Items.Add(item);
        }
    }
}
