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
            int index = itemsListBox.SelectedIndex;
            selectedNameTextBox.Text = Items[index].Product.Name;
            selectedIdTextBox.Text = Items[index].Product.Id.ToString();
            selectedPriceTextBox.Text = Items[index].Product.Price.ToString();
            
        }

        private void viewAllButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void selectedNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void updateSelectedItemButton_Click(object sender, RoutedEventArgs e)
        {
            int index = itemsListBox.SelectedIndex;
            Items[index].Product.Name = selectedNameTextBox.Text;
            Items[index].Product.Id = int.Parse(selectedNameTextBox.Text);
            Items[index].Product.Price = decimal.Parse(selectedPriceTextBox.Text);
            Items[index].Quantity = int.Parse(quantityTextBox.Text);
        }

        private void newItemButton_Click(object sender, RoutedEventArgs e)
        {
            StoreItem addToStore = new(new(), int.Parse(quantityTextBox.Text));
            addToStore.Product.Name = selectedNameTextBox.Text;
            addToStore.Product.Id = int.Parse(selectedIdTextBox.Text);
            addToStore.Product.Price = decimal.Parse(selectedPriceTextBox.Text);
            Items.Add(addToStore);
        }
    }
}
