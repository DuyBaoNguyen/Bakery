using Bakery.HandleData;
using Bakery.MappingModel;
using Bakery.Other;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bakery
{
    public partial class EmployeePanel : UserControl
    {
        List<Employee> emps;
        Color oddControlColor = Color.White;
        Color evenControlColor = Color.FromArgb(250, 250, 250);

        string searchString = String.Empty;
        string searchPro = "Mã nhân viên";
        bool sortAsc = true;
        string sortPro = "Mã nhân viên";

        public EmployeePanel()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["managePnl"].BringToFront();
        }

        public void RefreshItem()
        {
            empsPnl.SuspendLayout();

            string error = null;
            emps = EmployeeData.Instance.GetEmployees(searchString, searchPro, sortAsc, sortPro, ref error);

            if (error != null)
            {
                for (int i = empsPnl.Controls.Count - 1; i >= 0; i--)
                {
                    Control ctrl = empsPnl.Controls[i];
                    empsPnl.Controls.RemoveAt(i);
                    ctrl.Dispose();
                }
                empsPnl.ResumeLayout();
                if (this.Parent.Controls.IndexOf(this) == 0)
                {
                    MessageBox.Show(error, "Thông báo");
                }
                return;
            }

            EmployeeItem[] empItems;

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
                empItems = new EmployeeItem[emps.Count - empsPnl.Controls.Count];
                using (VScrollBar scrollBar = new VScrollBar())
                {
                    for (int i = 0; i < empItems.Length; i++)
                    {
                        empItems[i] = new EmployeeItem();
                        empItems[i].Margin += new Padding(scrollBar.Width, 0, 0, 0);
                    }
                }
                empsPnl.Controls.AddRange(empItems);
            }

            for (int i = 0; i < empsPnl.Controls.Count; i++)
            {
                ((EmployeeItem)empsPnl.Controls[i]).Data = emps[i];
            }
            empsPnl.EditScreenByWidth();
            empsPnl.InterleaveColor(oddControlColor, evenControlColor);
            empsPnl.ResumeLayout();
        }
        
        private void EmployeePanel_Load(object sender, EventArgs e)
        {
            searchEmpCms.AddTitle("Tìm kiếm");
            sortEmpCms.AddTitle("Sắp xếp");
        }

        private void SortProToolStrip_Click(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in sortEmpCms.Items)
            {
                if (item is ToolStripMenuItem menuItem && !menuItem.Equals(sender))
                {
                    menuItem.Checked = false;
                }
            }
            ToolStripMenuItem click_item = sender as ToolStripMenuItem;
            click_item.Checked = true;
            sortPro = click_item.Text;
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

        private void EmpsPnl_SizeChanged(object sender, EventArgs e)
        {
            empsPnl.EditScreenByWidth();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            searchString = "";
            RefreshItem();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            if (sortAsc == true)
            {
                sortBtn.CenterImage = Properties.Resources.up;
                sortAsc = false;
            }
            else
            {
                sortBtn.CenterImage = Properties.Resources.down;
                sortAsc = true;
            }
            RefreshItem();
        }

        private void SearchCakeSb_Search(object sender, EventArgs e)
        {
            searchString = searchSb.Text;
            RefreshItem();
        }

        private void AddEmpBtn_Click(object sender, EventArgs e)
        {
            EmployeeInfoForm form = new EmployeeInfoForm(true);
            form.ShowDialog();
            RefreshItem();
        }
    }
}
