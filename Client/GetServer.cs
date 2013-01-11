using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tranzap
{
    public partial class GetServer : Form
    {
        private bool gotServer;
        public GetServer()
        {
            InitializeComponent();

            gotServer = false;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (gotServer && Client.connected())
            {
                this.Enabled = false;
                if (Client.logIn(usernameTextBox.Text, passwordTextBox.Text))
                { this.Close(); }
                else
                { failLabel.Visible = true; }
                this.Enabled = true;
            }
            if (!gotServer && addressTextBox.Text != "")
            {
                if (Client.connect(addressTextBox.Text))
                {
                    addressLabel.Visible = false;
                    addressTextBox.Visible = false;

                    usernameLabel.Visible = true;
                    usernameTextBox.Visible = true;
                    passwordLabel.Visible = true;
                    passwordTextBox.Visible = true;
                    wrongAddressLabel.Visible = false;

                    sendButton.Text = "Log In";

                    gotServer = true;
                }
                else
                { wrongAddressLabel.Visible = true; }
            }
        }

        private void GetServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { sendButton_Click(sendButton, new EventArgs());}
        }
    }
}
