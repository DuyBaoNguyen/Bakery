using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bakery.Other;

namespace Bakery
{
    public partial class SalePanel1 : UserControl
    {
        bool firstLoad = true;

        public SalePanel1()
        {
            InitializeComponent();
        }
        
        private void MenuItem_Paint(object sender, PaintEventArgs e)
        {
            RadioButton rbn = sender as RadioButton;
            if (rbn.Checked)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 122, 255)))
                {
                    e.Graphics.FillRectangle(brush, 0, 0, 5, rbn.Height);
                }
            }

            if (rbn.Equals(cartMenuItemRbn) && ListOrder.Instance.Count > 0)
            {
                using (SolidBrush brush = new SolidBrush(Color.Red))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    int diameter = 22;
                    Rectangle rec = new Rectangle(rbn.Width - diameter - 10, (rbn.Height - diameter) / 2, diameter, diameter);
                    e.Graphics.FillEllipse(brush, rec);

                    using (Font font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))))
                    {
                        TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
                        TextRenderer.DrawText(e.Graphics, ListOrder.Instance.Count.ToString(), font, rec, Color.White, flags);
                    }
                }
            }
        }

        private void SalePanel_Load(object sender, EventArgs e)
        {
            cakeMenuItemRbn.Checked = true;
            ListOrder.Instance.OnAdd += new EventHandler(Order_Added);
            ListOrder.Instance.OnRemove += new EventHandler(Order_Removed);
        }

        private void Order_Added(object sender, EventArgs e)
        {
            cartMenuItemRbn.Refresh();
        }

        private void Order_Removed(object sender, EventArgs e)
        {
            cartMenuItemRbn.Refresh();
        }

        private void CakeMenuItemRbn_CheckedChanged(object sender, EventArgs e)
        {
            if (cakeMenuItemRbn.Checked)
            {
                cakePnl.BringToFront();
                if (firstLoad)
                {
                    cakePnl.RefreshItem();
                    firstLoad = false;
                }
            }
        }

        private void CartMenuItemRbn_CheckedChanged(object sender, EventArgs e)
        {
            if (cartMenuItemRbn.Checked)
            {
                orderPnl.BringToFront();
                orderPnl.RefreshItem();
            }
        }
    }
}
