﻿using Bakery.HandleData;
using Bakery.MappingModel;
using System;
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

        private async void LoginBtn_Click(object sender, System.EventArgs e)
        {
            if (usernameTxt.Text == String.Empty)
            {
                MessageBox.Show("Hãy nhập username!", "Thông báo");
                return;
            }
            if (passwordTxt.Text == String.Empty)
            {
                MessageBox.Show("Hãy nhập password!", "Thông báo");
                return;
            }
            if (functionCmb.Text == String.Empty)
            {
                MessageBox.Show("Hãy chọn chức năng!", "Thông báo");
                return;
            }

            loginBtn.Enabled = false;
            loadPtb.Visible = true;
            serverPnl.Enabled = false;
            loginNamePnl.Enabled = false;
            passwordPnl.Enabled = false;
            functionPnl.Enabled = false;

            await Task.Run(() =>
            {
                Properties.Settings.Default.ServerName = serverTxt.Text;
                Properties.Settings.Default.Username = usernameTxt.Text;
                Properties.Settings.Default.Password = passwordTxt.Text;
                if (AccessDb.AccessDb.Instance.ConnectDatabase())
                {
                    Properties.Settings.Default.SuccessfullAccess = true;
                }
                else
                {
                    Properties.Settings.Default.SuccessfullAccess = false;
                }
                Properties.Settings.Default.Save();
            });

            loadPtb.Visible = false;
            loginBtn.Enabled = true;
            serverPnl.Enabled = true;
            loginNamePnl.Enabled = true;
            passwordPnl.Enabled = true;
            functionPnl.Enabled = true;

            if (Properties.Settings.Default.SuccessfullAccess)
            {
                this.Hide();
                
                this.Hide();
                if (functionCmb.Text == "Bán hàng")
                {
                    Account acc = AccountData.Instance.GetAccount(usernameTxt.Text);
                    Form form = new SaleForm(acc);
                    form.ShowDialog();
                }
                else
                {
                    Form form = new ManageForm();
                    form.ShowDialog();
                }

                passwordTxt.Text = "";
                this.Show();
            }
            else
            {
                MessageBox.Show("Server không tồn tại hoặc không thể kết nối!\n" +
                                "Hoặc tên tài khoản, mật khẩu không chính xác!", "Thông báo");
            }
        }

        private void ServerTxt_TextChanged(object sender, EventArgs e)
        {
            if (serverTxt.Text != String.Empty)
            {
                loginBtn.Enabled = true;
            }
            else
            {
                loginBtn.Enabled = false;
            }
        }

        private void ConnectServerForm_Load(object sender, EventArgs e)
        {
            if (serverTxt.Text != String.Empty)
            {
                loginBtn.Enabled = true;
            }
        }

        private void ViewBtn_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = false;
        }

        private void ViewBtn_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = true;
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (!passwordTxt.Text.Equals(String.Empty))
            {
                viewBtn.Visible = true;
            }
            else
            {
                viewBtn.Visible = false;
            }
        }
    }
}
