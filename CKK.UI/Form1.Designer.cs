namespace CKK.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.socialsPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.googleTextBox = new System.Windows.Forms.Button();
            this.instagramTextBox = new System.Windows.Forms.Button();
            this.twitterTextBox = new System.Windows.Forms.Button();
            this.facebookTextBox = new System.Windows.Forms.Button();
            this.noAccountLabel = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.socialsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.noAccountLabel);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.usernameTextBox);
            this.loginPanel.Location = new System.Drawing.Point(38, 84);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(337, 231);
            this.loginPanel.TabIndex = 0;
            // 
            // socialsPanel
            // 
            this.socialsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.socialsPanel.Controls.Add(this.facebookTextBox);
            this.socialsPanel.Controls.Add(this.twitterTextBox);
            this.socialsPanel.Controls.Add(this.instagramTextBox);
            this.socialsPanel.Controls.Add(this.googleTextBox);
            this.socialsPanel.Location = new System.Drawing.Point(423, 84);
            this.socialsPanel.Name = "socialsPanel";
            this.socialsPanel.Size = new System.Drawing.Size(337, 231);
            this.socialsPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(289, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(220, 25);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Corey\'s Knick Knacks";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(23, 19);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(289, 20);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Text = "Username";
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(23, 60);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(289, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(23, 100);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(289, 73);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // googleTextBox
            // 
            this.googleTextBox.Location = new System.Drawing.Point(3, 3);
            this.googleTextBox.Name = "googleTextBox";
            this.googleTextBox.Size = new System.Drawing.Size(329, 51);
            this.googleTextBox.TabIndex = 0;
            this.googleTextBox.Text = "Google";
            this.googleTextBox.UseVisualStyleBackColor = true;
            // 
            // instagramTextBox
            // 
            this.instagramTextBox.Location = new System.Drawing.Point(3, 60);
            this.instagramTextBox.Name = "instagramTextBox";
            this.instagramTextBox.Size = new System.Drawing.Size(329, 51);
            this.instagramTextBox.TabIndex = 0;
            this.instagramTextBox.Text = "Instagram";
            this.instagramTextBox.UseVisualStyleBackColor = true;
            // 
            // twitterTextBox
            // 
            this.twitterTextBox.Location = new System.Drawing.Point(3, 117);
            this.twitterTextBox.Name = "twitterTextBox";
            this.twitterTextBox.Size = new System.Drawing.Size(329, 51);
            this.twitterTextBox.TabIndex = 0;
            this.twitterTextBox.Text = "Twitter";
            this.twitterTextBox.UseVisualStyleBackColor = true;
            // 
            // facebookTextBox
            // 
            this.facebookTextBox.Location = new System.Drawing.Point(3, 174);
            this.facebookTextBox.Name = "facebookTextBox";
            this.facebookTextBox.Size = new System.Drawing.Size(329, 51);
            this.facebookTextBox.TabIndex = 0;
            this.facebookTextBox.Text = "Facebook";
            this.facebookTextBox.UseVisualStyleBackColor = true;
            // 
            // noAccountLabel
            // 
            this.noAccountLabel.AutoSize = true;
            this.noAccountLabel.Location = new System.Drawing.Point(105, 193);
            this.noAccountLabel.Name = "noAccountLabel";
            this.noAccountLabel.Size = new System.Drawing.Size(122, 13);
            this.noAccountLabel.TabIndex = 3;
            this.noAccountLabel.Text = "Don\'t have an account?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.socialsPanel);
            this.Controls.Add(this.loginPanel);
            this.Name = "Form1";
            this.Text = "CKK.UI";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.socialsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Panel socialsPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label noAccountLabel;
        private System.Windows.Forms.Button facebookTextBox;
        private System.Windows.Forms.Button twitterTextBox;
        private System.Windows.Forms.Button instagramTextBox;
        private System.Windows.Forms.Button googleTextBox;
    }
}

