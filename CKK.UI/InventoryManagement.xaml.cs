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

        public void SendLogin_Click(object sender, RoutedEventArgs e)
        {
            SendLogin.Content = "Button Click";
        }

        public void usernameTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            usernameTextBox.Text = "";
        }

        public void passwordTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            passwordTextBox.Text = "";
        }

        public void googleLogin_Click(object sender, RoutedEventArgs e)
        {
            googleLogin.Content = "Logged in with google";
        }

        public void instagramLogin_Click(object sender, RoutedEventArgs e)
        {
            instagramLogin.Content = "Logged in with instagram";
        }

        public void twitterLogin_Click(object sender, RoutedEventArgs e)
        {
            twitterLogin.Content = "Logged in with twitter";
        }

        public void facebookLogin_Click(object sender, RoutedEventArgs e)
        {
            facebookLogin.Content = "Logged in with facebook";
        }

        private void RefreshList()
        {
            Items.Clear();
            foreach (StoreItem item in new ObservableCollection<StoreItem>(Store.GetStoreItems())) Items.Add(item);
        }
    }
}
