namespace Tranzap
{
    partial class GetServer
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.failLabel = new System.Windows.Forms.Label();
            this.wrongAddressLabel = new System.Windows.Forms.Label();
            this.newUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usernameLabel.Location = new System.Drawing.Point(13, 25);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordLabel.Location = new System.Drawing.Point(13, 81);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.Visible = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usernameTextBox.Location = new System.Drawing.Point(12, 41);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(260, 20);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordTextBox.Location = new System.Drawing.Point(12, 97);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(260, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Visible = false;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(113, 227);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Access";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addressLabel.Location = new System.Drawing.Point(13, 99);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(260, 13);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Type in the IP address or domain you want to access.";
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addressTextBox.Location = new System.Drawing.Point(12, 115);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(260, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // failLabel
            // 
            this.failLabel.AutoSize = true;
            this.failLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.failLabel.Location = new System.Drawing.Point(118, 201);
            this.failLabel.Name = "failLabel";
            this.failLabel.Size = new System.Drawing.Size(67, 13);
            this.failLabel.TabIndex = 7;
            this.failLabel.Text = "Log in failed.";
            this.failLabel.Visible = false;
            // 
            // wrongAddressLabel
            // 
            this.wrongAddressLabel.AutoSize = true;
            this.wrongAddressLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.wrongAddressLabel.Location = new System.Drawing.Point(72, 200);
            this.wrongAddressLabel.Name = "wrongAddressLabel";
            this.wrongAddressLabel.Size = new System.Drawing.Size(159, 13);
            this.wrongAddressLabel.TabIndex = 8;
            this.wrongAddressLabel.Text = "No server found at that address.";
            this.wrongAddressLabel.Visible = false;
            // 
            // newUserButton
            // 
            this.newUserButton.Location = new System.Drawing.Point(113, 160);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(75, 23);
            this.newUserButton.TabIndex = 9;
            this.newUserButton.Text = "button1";
            this.newUserButton.UseVisualStyleBackColor = true;
            // 
            // GetServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.wrongAddressLabel);
            this.Controls.Add(this.failLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GetServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetServer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GetServer_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label failLabel;
        private System.Windows.Forms.Label wrongAddressLabel;
        private System.Windows.Forms.Button newUserButton;
    }
}