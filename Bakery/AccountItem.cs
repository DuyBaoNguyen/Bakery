using Bakery.HandleData;
using Bakery.MappingModel;
using System.Windows.Forms;

namespace Bakery
{
    public partial class AccountItem : UserControl
    {
        Account data;

        public Account Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                if (data != null)
                {
                    usernameLb.Text = data.Username;
                    permissionLb.Text = data.Permission;
                    if (data.Employee != null)
                    {
                        empIdLb.Text = data.Employee.Id.ToString();
                        empNameLb.Text = data.Employee.Name;
                    }
                    else
                    {
                        empIdLb.Text = null;
                        empNameLb.Text = null;
                    }
                }
                else
                {
                    usernameLb.Text = null;
                    permissionLb.Text = null;
                    empIdLb.Text = null;
                    empNameLb.Text = null;
                }
            }
        }

        public AccountItem()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa tài khoản " + data.Username + "?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string error = null;
                bool resultQuery = AccountData.Instance.Delete(data, ref error);
                if (!resultQuery)
                {
                    MessageBox.Show(error, "Thông báo");
                }
                else
                {
                    ((AccountPanel)this.Parent.Parent).RefreshItem();
                }
            }
        }

        private void TableLayoutPanel_Click(object sender, System.EventArgs e)
        {
            AddEditAccountForm form = new AddEditAccountForm(false);
            form.Data = data;
            form.ShowDialog(this);
            ((AccountPanel)this.Parent.Parent).RefreshItem();
        }
    }
}

