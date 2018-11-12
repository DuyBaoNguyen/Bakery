using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bakery
{
    public partial class ManagePanel : UserControl
    {
        int menu_item_enter_dx = 10;
        int menu_item_click_dx = 3;

        bool cakeFirstLoad = true;
        bool empFirstLoad = true;
        bool accFirstLoad = true;

        public ManagePanel()
        {
            InitializeComponent();
        }
        
        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            RoundPanel pnl = sender as RoundPanel;
            pnl.Margin -= new Padding(menu_item_enter_dx);
            pnl.Size += new Size(menu_item_enter_dx * 2, menu_item_enter_dx * 2);
            pnl.Color = Color.Orange;
        }

        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            RoundPanel pnl = sender as RoundPanel;
            pnl.Size -= new Size(menu_item_enter_dx * 2, menu_item_enter_dx * 2);
            pnl.Margin += new Padding(menu_item_enter_dx);
            pnl.Color = Color.FromArgb(0, 122, 255);
        }

        private void MeneItem_MouseDown(object sender, MouseEventArgs e)
        {
            RoundPanel pnl = sender as RoundPanel;
            pnl.Size -= new Size(menu_item_click_dx * 2, menu_item_click_dx * 2);
            pnl.Margin += new Padding(menu_item_click_dx);
        }

        private void MeneItem_MouseUp(object sender, MouseEventArgs e)
        {
            RoundPanel pnl = sender as RoundPanel;
            pnl.Margin -= new Padding(menu_item_click_dx);
            pnl.Size += new Size(menu_item_click_dx * 2, menu_item_click_dx * 2);
        }

        private void CakeItemPnl_Click(object sender, EventArgs e)
        {
            CakePanel pnl = this.Parent.Controls["cakePnl"] as CakePanel;
            pnl.BringToFront();
            if (cakeFirstLoad)
            {
                ((ActCakePanel)pnl.Controls["actCakePnl"]).RefreshItem();
                cakeFirstLoad = false;
            }
        }

        private void EmpItemPnl_Click(object sender, EventArgs e)
        {
            EmployeePanel pnl = this.Parent.Controls["empPnl"] as EmployeePanel;
            pnl.BringToFront();
            if (empFirstLoad)
            {
                pnl.RefreshItem();
                empFirstLoad = false;
            }
        }

        private void SalItemPnl_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["salPnl"].BringToFront();
        }

        private void BillItemPnl_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["billPnl"].BringToFront();
        }

        private void AccItemPnl_Click(object sender, EventArgs e)
        {
            AccountPanel pnl = this.Parent.Controls["accPnl"] as AccountPanel;
            pnl.BringToFront();
            if (accFirstLoad)
            {
                pnl.RefreshItem();
                accFirstLoad = false;
            }
        }

        private void StatisticItemPnl_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["statisticPnl"].BringToFront();
        }
        
        private void ManagePanel_Load(object sender, EventArgs e)
        {
            menuPanel.Location = new Point((this.Width - menuPanel.Width) / 2, (this.Height - menuPanel.Height) / 2);
        }
    }
}
