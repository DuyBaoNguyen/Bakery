using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Bakery.MappingModel;
using Bakery.HandleData;
using Bakery.Other;

namespace Bakery
{
    public partial class ActCakePanel : UserControl
    {
        bool add;
        List<Cake> cakes;
        string searchString = "";
        string searchPro = "Tên bánh";
        bool sortAsc = true;
        string sortPro = "Tên bánh";

        int left_margin = 15;
        int top_margin = 15;

        public ActCakePanel()
        {
            InitializeComponent();
        }
        
        public void RefreshItem()
        {
            actCakesPnl.SuspendLayout();

            string error = null;
            cakes = CakeData.Instance.GetCakes(true, searchString, searchPro, sortAsc, sortPro, ref error);

            if (error != null)
            {
                for (int i = actCakesPnl.Controls.Count - 1; i >= 0; i--)
                {
                    Control ctrl = actCakesPnl.Controls[i];
                    actCakesPnl.Controls.RemoveAt(i);
                    ctrl.Dispose();
                }
                actCakesPnl.ResumeLayout();
                if (this.Parent.Controls.IndexOf(this) == 0)
                {
                    MessageBox.Show(error, "Thông báo");
                }
                return;
            }

            ActCakeItem[] cakeItems;

            if (cakes.Count < actCakesPnl.Controls.Count)
            {
                for (int i = actCakesPnl.Controls.Count - 1; i >= cakes.Count; i--)
                {
                    Control ctrl = actCakesPnl.Controls[i];
                    actCakesPnl.Controls.RemoveAt(i);
                    ctrl.Dispose();
                }
            }
            else
            {
                cakeItems = new ActCakeItem[cakes.Count - actCakesPnl.Controls.Count];
                for (int i = 0; i < cakeItems.Length; i++)
                {
                    cakeItems[i] = new ActCakeItem();
                }
                actCakesPnl.Controls.AddRange(cakeItems);
            }

            for (int i = 0; i < actCakesPnl.Controls.Count; i++)
            {
                ((ActCakeItem)actCakesPnl.Controls[i]).Data = cakes[i];
            }

            actCakesPnl.EditScreen(left_margin, top_margin);
            actCakesPnl.ResumeLayout();
        }

        private void AddCakeBtn_Click(object sender, EventArgs e)
        {
            CakeInfoForm cakes = new CakeInfoForm(true);
            cakes.ShowDialog();
            RefreshItem();
        }
        
        private void CakePnl_SizeChanged(object sender, EventArgs e)
        {
            actCakesPnl.EditScreen(left_margin, top_margin);
        }

        private void SortProToolStrip_Click(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in sortCakeCms.Items)
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

        private void SalePanel_Load(object sender, EventArgs e)
        {
            sortCakeCms.AddTitle("Sắp xếp");
        }
    }
}
