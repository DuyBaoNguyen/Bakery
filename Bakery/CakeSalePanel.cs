using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bakery.MappingModel;
using Bakery.HandleData;
using Bakery.Other;

namespace Bakery
{
    public partial class CakeSalePanel : UserControl
    {
        List<Cake> cakes;
        string searchString = "";
        string searchPro = "Tên bánh";
        bool sortAsc = true;
        string sortPro = "Tên bánh";

        int left_margin = 15;
        int top_margin = 15;

        public CakeSalePanel()
        {
            InitializeComponent();
        }

        public async void RefreshItem()
        {
            cakePnl.SuspendLayout();
            loadPtb.Enabled = true;
            loadPtb.BringToFront();
            cakePnl.Visible = false;

            await Task.Run(() => cakes = CakeData.Instance.GetCakes(true, searchString, searchPro, sortAsc, sortPro));

            loadPtb.SendToBack();
            loadPtb.Enabled = false;
            cakePnl.Visible = true;

            CakeItem[] cakeItems;

            if (cakes.Count <= cakePnl.Controls.Count)
            {
                for (int i = cakePnl.Controls.Count - 1; i >= cakes.Count; i--)
                {
                    Control ctrl = cakePnl.Controls[i];
                    cakePnl.Controls.RemoveAt(i);
                    ctrl.Dispose();
                }
            }
            else
            {
                int number_cake_item = cakes.Count - cakePnl.Controls.Count;
                cakeItems = new CakeItem[number_cake_item];
                for (int i = 0; i < number_cake_item; i++)
                {
                    cakeItems[i] = new CakeItem();
                }
                cakePnl.Controls.AddRange(cakeItems);
            }

            for (int i = 0; i < cakePnl.Controls.Count; i++)
            {
                ((CakeItem)cakePnl.Controls[i]).Data = cakes[i];
            }
            
            Support.EditSreen(cakePnl, left_margin, top_margin);
            cakePnl.ResumeLayout();
        }

        private void CakePnl_SizeChanged(object sender, EventArgs e)
        {
            Support.EditSreen(cakePnl, left_margin, top_margin);
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
            searchString = searchCakeSb.Text;
            RefreshItem();
        }
    }
}
