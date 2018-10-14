using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class ManagerPanel : UserControl
    {
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
            Label lb = sender as Label;
            RoundPanel pnl = (RoundPanel)lb.Parent;
            pnl.Margin = new Padding(10);
            pnl.Size = pnl.Size + new Size(20, 20);
            pnl.Color = Color.Orange;
        }

        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            RoundPanel pnl = (RoundPanel)lb.Parent;
            pnl.Size = pnl.Size - new Size(20, 20);
            pnl.Margin = new Padding(20);
            pnl.Color = Color.FromArgb(0, 122, 255);
        }

        private void MeneItem_MouseDown(object sender, MouseEventArgs e)
        {
            Label lb = sender as Label;
            RoundPanel pnl = (RoundPanel)lb.Parent;
            pnl.Size = pnl.Size - new Size(10, 10);
            pnl.Margin = new Padding(15);
        }

        private void MeneItem_MouseUp(object sender, MouseEventArgs e)
        {
            Label lb = sender as Label;
            RoundPanel pnl = (RoundPanel)lb.Parent;
            pnl.Margin = new Padding(10);
            pnl.Size = pnl.Size + new Size(10, 10);
        }
    }
}
