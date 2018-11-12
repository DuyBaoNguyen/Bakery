using Bakery.HandleData;
using Bakery.MappingModel;
using Bakery.Other;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bakery
{
    public partial class AddEditAccountForm : Form
    {
        Account data;
        List<Employee> emps;
        string searchString = "";
        string searchPro = "Mã nhân viên";
        Color oddControlColor = Color.White;
        Color evenControlColor = Color.FromArgb(250, 250, 250);

        bool addAcc;

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
                    usernameTxt.Text = data.Username;
                    if (data.Permission == "Admin")
                    {
                        accAdPermissionRbn.Checked = true;
                    }
                    empIdLb.Text = data.Employee.Id.ToString();
                    empNameLb.Text = data.Employee.Name;
                }
                else
                {
                    usernameTxt.Text = null;
                    empIdLb.Text = null;
                    empNameLb.Text = null;
                }
            }
        }

        public AddEditAccountForm(bool addAcc)
        {
            InitializeComponent();
            this.addAcc = addAcc;
        }
        
        private void RefreshItem()
        {
            empsPnl.SuspendLayout();

            string error = null;
            emps = EmployeeData.Instance.GetEmpsNoAccount(searchString, searchPro, ref error);

            if (error != null)
            {
                empsPnl.ResumeLayout();
                MessageBox.Show(error, "Thông báo");
                return;
            }

            EmployeeShortItem[] empItems;

            if (emps.Count < empsPnl.Controls.Count)
            {
                for (int i = empsPnl.Controls.Count - 1; i >= emps.Count; i--)
                {
                    Control ctrl = empsPnl.Controls[i];
                    empsPnl.Controls.RemoveAt(i);
                    ctrl.Dispose();
                }
            }
            else if (emps.Count > empsPnl.Controls.Count)
            {
                empItems = new EmployeeShortItem[emps.Count - empsPnl.Controls.Count];
                using (VScrollBar scrollBar = new VScrollBar())
                {
                    for (int i = 0; i < empItems.Length; i++)
                    {
                        empItems[i] = new EmployeeShortItem();
                        empItems[i].Margin += new Padding(scrollBar.Width, 0, 0, 0);
                    }
                }
                empsPnl.Controls.AddRange(empItems);
            }

            for (int i = 0; i < empsPnl.Controls.Count; i++)
            {
                ((EmployeeShortItem)empsPnl.Controls[i]).Data = emps[i];
            }
            empsPnl.EditScreenByWidth();
            empsPnl.InterleaveColor(oddControlColor, evenControlColor);
            empsPnl.ResumeLayout();
        }

        private void SearchSb_Search(object sender, EventArgs e)
        {
            searchString = searchSb.Text;
            RefreshItem();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            searchString = "";
            RefreshItem();
        }

        private void SearchProToolStrip_Click(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in searchEmpCms.Items)
            {
                if (item is ToolStripMenuItem menuItem && !menuItem.Equals(sender))
                {
                    menuItem.Checked = false;
                }
            }
            ToolStripMenuItem click_item = sender as ToolStripMenuItem;
            click_item.Checked = true;
            searchPro = click_item.Text;
            RefreshItem();
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            changePasswordBtn.Visible = false;
            newPasswordLb.Visible = true;
            newPasswordPnl.Visible = true;
        }

        private void AddEditAccountForm_Load(object sender, EventArgs e)
        {
            searchEmpCms.AddTitle("Tìm kiếm");
            if (!addAcc)
            {
                changePasswordBtn.Visible = true;
                newPasswordLb.Visible = false;
                newPasswordPnl.Visible = false;
                empContainer.Width = 0;
                usernameTxt.ReadOnly = true;
            }
            else
            {
                RefreshItem();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string error = null;
            bool result = false;

            if (addAcc)
            {
                Account acc = new Account();
                acc.Username = usernameTxt.Text;
                acc.Password = passwordTxt.Text;
                if (int.TryParse(empIdLb.Text, out int temp))
                {
                    acc.Employee = new Employee();
                    acc.Employee.Id = int.Parse(empIdLb.Text);
                }
                if (accAdPermissionRbn.Checked)
                {
                    acc.Permission = "Admin";
                }
                else
                {
                    acc.Permission = "Nhân viên";
                }

                result = AccountData.Instance.Insert(acc, ref error);
            }
            else
            {
                Account acc = new Account();
                acc.Username = data.Username;
                acc.Password = passwordTxt.Text;
                if (accAdPermissionRbn.Checked)
                {
                    acc.Permission = "Admin";
                }
                else
                {
                    acc.Permission = "Nhân viên";
                }

                result = AccountData.Instance.Update(acc, ref error);

                if (result && Properties.Settings.Default.Username == acc.Username)
                {
                    if (acc.Password != String.Empty)
                    {
                        Properties.Settings.Default.Password = acc.Password;
                    }

                    if (accEmpPermissionRbn.Checked)
                    {
                        Form form = this.Owner;
                        ((EmployeePanel)form.Controls["empPnl"]).RefreshItem();
                        ((SalaryPanel)form.Controls["salPnl"]).RefreshItem();
                        ((BillPanel)form.Controls["billPnl"]).RefreshItem();
                        ((StatisticPanel)form.Controls["statisticPnl"]).RefreshItem();
                    }
                }
            }

            if (!result)
            {
                MessageBox.Show(error, "Thông báo");
            }
            else
            {
                this.Close();
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
    }
}
