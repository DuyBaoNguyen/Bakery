using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bakery
{
    public partial class ManagerPanel : UserControl
    {
        int menu_item_enter_dx = 10;
        int menu_item_click_dx = 3;

        public ManagerPanel()
        {
            InitializeComponent();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            menuPanel.Location = new Point((this.Width - menuPanel.Width) / 2, (this.Height - menuPanel.Height) / 2);
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
    }
}
