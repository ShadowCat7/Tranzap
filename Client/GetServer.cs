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
                if (Client.logIn(usernameTextBox.Text, passwordTextBox.Text))
                { }//TODO
            }
            if (!gotServer && Client.connect(addressTextBox.Text))
            {
                addressLabel.Visible = false;
                addressTextBox.Visible = false;

                usernameLabel.Visible = true;
                usernameTextBox.Visible = true;
                passwordLabel.Visible = true;
                passwordTextBox.Visible = true;

                gotServer = true;
            }
        }
    }
}
