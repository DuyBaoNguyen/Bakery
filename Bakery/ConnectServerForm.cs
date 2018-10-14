using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class ConnectServerForm : Form
    {
        public ConnectServerForm()
        {
            InitializeComponent();
        }
        private async void AccessBtn_Click(object sender, System.EventArgs e)
        {
            accessBtn.Enabled = false;
            loadPtb.Visible = true;

            await Task.Run(() =>
            {
                Properties.Settings.Default.ServerName = serverTxt.Text;
                AccessDb.AccessDb.LoginName = loginNameTxt.Text;
                AccessDb.AccessDb.Password = passwordTxt.Text;
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
            accessBtn.Enabled = true;

            if (Properties.Settings.Default.SuccessfullAccess)
            {
                this.Hide();
                Form loginForm = new LoginForm();
                loginForm.ShowDialog();
                if (this != null)
                {
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Server không tồn tại hoặc không thể kết nối!", "Thông báo");
            }
        }

        private void ServerTxt_TextChanged(object sender, EventArgs e)
        {
            if (serverTxt.Text != String.Empty)
            {
                accessBtn.Enabled = true;
            }
            else
            {
                accessBtn.Enabled = false;
            }
        }
        
        private void ConnectServerForm_Load(object sender, EventArgs e)
        {
            if (serverTxt.Text != String.Empty)
            {
                accessBtn.Enabled = true;
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
