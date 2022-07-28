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
using System.Windows.Shapes;
using CKK.Logic.Models;
using System.Collections.ObjectModel;

namespace CKK.UI
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Store store = new Store();
        ObservableCollection<StoreItem> Items = new ObservableCollection<StoreItem>();
        int selectedIndex;

        public Window1()
        {
            InitializeComponent();
            itemsListBox.ItemsSource = Items;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedIndex = itemsListBox.SelectedIndex;
            selectedNameTextBox.Text = Items[selectedIndex].Product.Name;
            selectedIdTextBox.Text = Items[selectedIndex].Product.Id.ToString();
            selectedPriceTextBox.Text = Items[selectedIndex].Product.Price.ToString();
            quantityTextBox.Text = Items[selectedIndex].Quantity.ToString();
            
        }

        private void viewAllButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void selectedNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void updateSelectedItemButton_Click(object sender, RoutedEventArgs e)
        {
            Items[selectedIndex].Product.Name = selectedNameTextBox.Text;
            Items[selectedIndex].Product.Id = int.Parse(selectedNameTextBox.Text);
            Items[selectedIndex].Product.Price = decimal.Parse(selectedPriceTextBox.Text);
            Items[selectedIndex].Quantity = int.Parse(quantityTextBox.Text);
        }

        private void newItemButton_Click(object sender, RoutedEventArgs e)
        {
            StoreItem addToStore = new(new(), int.Parse(quantityTextBox.Text));
            addToStore.Product.Name = selectedNameTextBox.Text;
            addToStore.Product.Id = int.Parse(selectedIdTextBox.Text);
            addToStore.Product.Price = decimal.Parse(selectedPriceTextBox.Text);
            Items.Add(addToStore);
        }

        private void selectedNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            selectedNameTextBox.Text = "Name";
        }

        private void selectedIdTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            selectedIdTextBox.Text = "Id";
        }

        private void selectedPriceTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            selectedPriceTextBox.Text = "Price";
        }

        private void quantityTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            quantityTextBox.Text = "Quantity";
        }
    }
}
