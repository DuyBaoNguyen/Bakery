using Bakery.HandleData;
using Bakery.MappingModel;
using Bakery.Other;
using System;
using System.Windows.Forms;

namespace Bakery
{
    public partial class EmployeeItem : UserControl
    {
        Employee data;

        public Employee Data
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
                    empIdlb.Text = data.Id.ToString();
                    empNameLb.Text = data.Name;
                    empSexCkb.Checked = !data.Sex;
                    if (data.Birthday != DateTime.MinValue)
                    {
                        empBirthdayLb.Text = data.Birthday.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        empBirthdayLb.Text = null;
                    }
                    empAddressLb.Text = data.Address.ToShortString(empAddressLb.Font, empAddressLb.Width);
                    empNumberPhoneLb.Text = data.NumberPhone;
                    empIdCodeLb.Text = data.IdCode;
                    empDateOfJoinLb.Text = data.DateOfJoin.ToString("dd/MM/yyyy");
                }
            }
        }

        public EmployeeItem()
        {
            InitializeComponent();
        }

        private void EmployeeItem_Load(object sender, EventArgs e)
        {
            empSexCkb.Margin += new Padding(0, (this.Height - empSexCkb.Height) / 2, 0, 0);
        }

        private void EmployeeItem_SizeChanged(object sender, EventArgs e)
        {
            if (data != null)
            {
                empAddressLb.Text = data.Address.ToShortString(empAddressLb.Font, empAddressLb.Width);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa nhân viên " + data.Id + "?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string error = null;
                bool result_query = EmployeeData.Instance.Delete(data, ref error);
                if (!result_query)
                {
                    MessageBox.Show(error, "Thông báo");
                }
                else
                {
                    Form form = this.FindForm();
                    ((EmployeePanel)form.Controls["empPnl"]).RefreshItem();
                    ((AccountPanel)form.Controls["accPnl"]).RefreshItem();
                    ((SalaryPanel)form.Controls["salPnl"]).RefreshItem();
                }
            }
        }
        
        private void ContainerPnl_Click(object sender, EventArgs e)
        {
            EmployeeInfoForm form = new EmployeeInfoForm(false);
            form.Data = data;
            form.ShowDialog();
            ((EmployeePanel)this.Parent.Parent).RefreshItem();
            ((AccountPanel)this.Parent.Parent.Parent.Controls["accPnl"]).RefreshItem();
        }
    }
}
