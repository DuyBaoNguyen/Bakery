using Bakery.HandleData;
using Bakery.MappingModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void ServerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form serverForm = new ConnectServerForm();
            serverForm.ShowDialog();
            this.Close();
        }

        private void ViewBtn_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = false;
        }

        private void ViewBtn_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = true;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string error = null;
            Account acc = new Account()
            {
                Username = usernameTxt.Text,
                Password = passwordTxt.Text
            };

            bool result = AccountData.Instance.CheckLogin(acc, ref error);
            if (result)
            {
                acc = AccountData.Instance.GetAccount(usernameTxt.Text);
                this.Hide();
                MainForm mainForm = new MainForm(acc);
                mainForm.ShowDialog();
                this.Show();
                passwordTxt.Text = "";
            }
            else
            {
                MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
