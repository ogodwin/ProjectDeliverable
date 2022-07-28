﻿
namespace CKK.UI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchByName = new System.Windows.Forms.TextBox();
            this.searchById = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.quantityNumUD = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addQuantButton = new System.Windows.Forms.RadioButton();
            this.setQuantButton = new System.Windows.Forms.RadioButton();
            this.removeQuantButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchByName
            // 
            this.searchByName.Location = new System.Drawing.Point(13, 13);
            this.searchByName.Name = "searchByName";
            this.searchByName.Size = new System.Drawing.Size(221, 23);
            this.searchByName.TabIndex = 0;
            this.searchByName.Text = "Search by Name";
            // 
            // searchById
            // 
            this.searchById.Location = new System.Drawing.Point(13, 42);
            this.searchById.Name = "searchById";
            this.searchById.Size = new System.Drawing.Size(221, 23);
            this.searchById.TabIndex = 0;
            this.searchById.Text = "Search by ID";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(287, 13);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(168, 52);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // viewAllButton
            // 
            this.viewAllButton.Location = new System.Drawing.Point(485, 13);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(303, 52);
            this.viewAllButton.TabIndex = 1;
            this.viewAllButton.Text = "View All";
            this.viewAllButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(13, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 304);
            this.listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(287, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 304);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.quantityLabel);
            this.panel2.Controls.Add(this.quantityNumUD);
            this.panel2.Location = new System.Drawing.Point(223, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 127);
            this.panel2.TabIndex = 0;
            // 
            // quantityNumUD
            // 
            this.quantityNumUD.Location = new System.Drawing.Point(3, 43);
            this.quantityNumUD.Name = "quantityNumUD";
            this.quantityNumUD.Size = new System.Drawing.Size(120, 23);
            this.quantityNumUD.TabIndex = 0;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(4, 22);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(53, 15);
            this.quantityLabel.TabIndex = 1;
            this.quantityLabel.Text = "Quantity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeQuantButton);
            this.groupBox1.Controls.Add(this.setQuantButton);
            this.groupBox1.Controls.Add(this.addQuantButton);
            this.groupBox1.Location = new System.Drawing.Point(129, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // addQuantButton
            // 
            this.addQuantButton.AutoSize = true;
            this.addQuantButton.Location = new System.Drawing.Point(6, 15);
            this.addQuantButton.Name = "addQuantButton";
            this.addQuantButton.Size = new System.Drawing.Size(47, 19);
            this.addQuantButton.TabIndex = 0;
            this.addQuantButton.TabStop = true;
            this.addQuantButton.Text = "Add";
            this.addQuantButton.UseVisualStyleBackColor = true;
            // 
            // setQuantButton
            // 
            this.setQuantButton.AutoSize = true;
            this.setQuantButton.Location = new System.Drawing.Point(6, 40);
            this.setQuantButton.Name = "setQuantButton";
            this.setQuantButton.Size = new System.Drawing.Size(41, 19);
            this.setQuantButton.TabIndex = 0;
            this.setQuantButton.TabStop = true;
            this.setQuantButton.Text = "Set";
            this.setQuantButton.UseVisualStyleBackColor = true;
            // 
            // removeQuantButton
            // 
            this.removeQuantButton.AutoSize = true;
            this.removeQuantButton.Location = new System.Drawing.Point(6, 65);
            this.removeQuantButton.Name = "removeQuantButton";
            this.removeQuantButton.Size = new System.Drawing.Size(68, 19);
            this.removeQuantButton.TabIndex = 0;
            this.removeQuantButton.TabStop = true;
            this.removeQuantButton.Text = "Remove";
            this.removeQuantButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.viewAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchById);
            this.Controls.Add(this.searchByName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchByName;
        private System.Windows.Forms.TextBox searchById;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button viewAllButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton removeQuantButton;
        private System.Windows.Forms.RadioButton setQuantButton;
        private System.Windows.Forms.RadioButton addQuantButton;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityNumUD;
    }
}