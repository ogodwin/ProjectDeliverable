﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CKK.Logic.Interfaces;
using CKK.Persistance.Models;

namespace CKK.UI
{
    public partial class Form1 : Form
    {
        private IStore Store;

        public Form1()
        {
            InitializeComponent();
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            passwordTextBox.Text = "";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        

    }
}
