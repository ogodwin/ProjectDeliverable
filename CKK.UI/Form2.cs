﻿using System;
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
        private FileStore store = new();

        public FileStore Store {get { return store; } }
        public Form2()
        {
            InitializeComponent();
            store.CreatePath();
            store.Load();
            listBox1.DataSource = store.Items;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = store.GetAllProductsByName(searchByName.Text, store.Items);
        }

        private void newStoreItem_Click(object sender, EventArgs e)
        {
            Product item = new();
            item.Id = (int)idNumUD.Value;
            item.Name = itemNameTextBox.Text;
            item.Price = decimal.Parse(itemPriceTextBox.Text);
            if(removeQuantButton.Checked == true)
            {
                MessageBox.Show("Cannot create an item with a negative quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int quantity = (int)quantityNumUD.Value;
                store.AddStoreItem(item, quantity);
            }
            store.Save();

        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = store.Items;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            return;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void sortByQuantity_Click(object sender, EventArgs e)
        {
            store.Items = store.GetProductsByQuantity(store.Items);
        }

        private void sortByPrice_Click(object sender, EventArgs e)
        {
            store.Items = store.GetProductsByPrice(store.Items);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                StoreItem reference = (StoreItem)listBox1.SelectedItem;
                itemNameTextBox.Text = reference.Product.Name;
                idNumUD.Value = reference.Product.Id;
                itemPriceTextBox.Text = reference.Product.Price.ToString();
                quantityNumUD.Value = reference.Quantity;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            StoreItem reference = (StoreItem)listBox1.SelectedItem;
            store.RemoveStoreItem(listBox1.SelectedIndex, reference.Quantity);
            store.Save();
        }
    }
}
