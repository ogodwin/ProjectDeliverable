using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CKK.Persistance.Models;
using CKK.Logic.Models;

namespace CKK.UI
{
    public partial class Form2 : Form
    {
        private FileStore store;
        public Form2()
        {
            InitializeComponent();
            store = new FileStore();
            store.Load();
            listBox1.DataSource = store.GetStoreItems();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void newStoreItem_Click(object sender, EventArgs e)
        {
            StoreItem item = new(new(), 0);
            item.Product.Id = int.Parse(itemIdTextBox.Text);
            item.Product.Name = itemNameTextBox.Text;
            item.Product.Price = decimal.Parse(itemPriceTextBox.Text);
            if(removeQuantButton.Checked == true)
            {
                MessageBox.Show("Cannot create an item with a negative quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                item.Quantity = (int)quantityNumUD.Value;
            }
        }
    }
}
