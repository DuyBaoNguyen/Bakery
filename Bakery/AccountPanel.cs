using Bakery.HandleData;
using Bakery.MappingModel;
using Bakery.Other;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bakery
{
    public partial class AccountPanel : UserControl
    {
        List<Account> accs;
        Color oddControlColor = Color.White;
        Color evenControlColor = Color.FromArgb(250, 250, 250);

        string searchString = String.Empty;
        string searchPro = "Username";
        bool sortAsc = true;
        string sortPro = "Username";

        public AccountPanel()
        {
            InitializeComponent();
        }

        public void RefreshItem()
        {
            accsPnl.SuspendLayout();

            string error = null;
            accs = AccountData.Instance.GetAccounts(searchString, searchPro, sortAsc, sortPro, ref error);

            if (error != null)
            {
                for (int i = accsPnl.Controls.Count - 1; i >= 0; i--)
                {
                    Control ctrl = accsPnl.Controls[i];
                    accsPnl.Controls.RemoveAt(i);
                    ctrl.Dispose();
                }
                accsPnl.ResumeLayout();
                if (this.Parent.Controls.IndexOf(this) == 0)
                {
                    MessageBox.Show(error, "Thông báo");
                }
                return;
            }

            AccountItem[] accItems;

            if (accs.Count < accsPnl.Controls.Count)
            {
                for (int i = accsPnl.Controls.Count - 1; i >= accs.Count; i--)
                {
                    Control ctrl = accsPnl.Controls[i];
                    accsPnl.Controls.RemoveAt(i);
                    ctrl.Dispose();
                }
            }
            else if (accs.Count > accsPnl.Controls.Count)
            {
                accItems = new AccountItem[accs.Count - accsPnl.Controls.Count];
                using (VScrollBar scrollBar = new VScrollBar())
                {
                    for (int i = 0; i < accItems.Length; i++)
                    {
                        accItems[i] = new AccountItem();
                        accItems[i].Margin += new Padding(scrollBar.Width, 0, 0, 0);
                    }
                }
                accsPnl.Controls.AddRange(accItems);
            }

            for (int i = 0; i < accsPnl.Controls.Count; i++)
            {
                ((AccountItem)accsPnl.Controls[i]).Data = accs[i];
            }
            accsPnl.EditScreenByWidth();
            accsPnl.InterleaveColor(oddControlColor, evenControlColor);
            accsPnl.ResumeLayout();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["managePnl"].BringToFront();
        }

        private void AccountPanel_Load(object sender, EventArgs e)
        {
            searchAccCms.AddTitle("Tìm kiếm");
            sortAccCms.AddTitle("Sắp xếp");
        }

        private void SortProToolStrip_Click(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in sortAccCms.Items)
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
            foreach (ToolStripItem item in searchAccCms.Items)
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

        private void AccsPnl_SizeChanged(object sender, EventArgs e)
        {
            accsPnl.EditScreenByWidth();
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
        
        private void AddAccBtn_Click(object sender, EventArgs e)
        {
            AddEditAccountForm form = new AddEditAccountForm(true);
            form.ShowDialog();
            RefreshItem();
        }
    }
}
