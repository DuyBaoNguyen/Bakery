using System;
using System.Windows.Forms;
using Bakery.Other;

namespace Bakery
{
    public partial class OrderPanel : UserControl
    {
        public OrderPanel()
        {
            InitializeComponent();
            ListOrder.Instance.OnAdd += new EventHandler(Order_Added);
            ListOrder.Instance.OnRemove += new EventHandler(Order_Removed);
            
        }

        public void RefreshItem()
        {
            for (int i = 0; i < ordersPnl.Controls.Count; i++)
            {
                ((OrderItem)ordersPnl.Controls[i]).Data = ListOrder.Instance[i];
            }
        }

        private void Order_Added(object sender, EventArgs e)
        {
            ordersPnl.SuspendLayout();
            OrderItem orderItem = new OrderItem();
            orderItem.Data = ListOrder.Instance[ListOrder.Instance.Count - 1];
            int w = ordersPnl.Width;
            using (VScrollBar scrollBar = new VScrollBar())
            {
                orderItem.Width = ordersPnl.Width - scrollBar.Width * 2;
                orderItem.Margin += new Padding(scrollBar.Width, 0, 0, 0);
            }
            ordersPnl.Controls.Add(orderItem);
            ordersPnl.ResumeLayout();
        }

        private void Order_Removed(object sender, EventArgs e)
        {

        }
    }
}
