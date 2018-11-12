using System;
using System.Drawing;
using System.Windows.Forms;
using Bakery.HandleData;
using Bakery.MappingModel;
using Bakery.Other;

namespace Bakery
{
    public partial class OrderPanel : UserControl
    {
        Account acc;
        Color oddControlColor = Color.White;
        Color evenControlColor = Color.FromArgb(250, 250, 250);

        public Account Account
        {
            get
            {
                return acc;
            }
            set
            {
                acc = value;
                if (acc.Employee != null)
                {
                    empIdLb.Text = acc.Employee.Id.ToString();
                    empNameLb.Text = acc.Employee.Name;
                }
            }
        }

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
            //ordersPnl.InterleaveColor(oddControlColor, evenControlColor);
        }

        private void Order_Added(object sender, EventArgs e)
        {
            ordersPnl.SuspendLayout();
            OrderItem orderItem = new OrderItem();
            ordersPnl.Controls.Add(orderItem);
            orderItem.Data = ListOrder.Instance[ListOrder.Instance.Count - 1];
            int w = ordersPnl.Width;
            using (VScrollBar scrollBar = new VScrollBar())
            {
                orderItem.Width = ordersPnl.Width - scrollBar.Width * 2;
                orderItem.Margin += new Padding(scrollBar.Width, 0, 0, 0);
            }
            ordersPnl.ResumeLayout();

            CalculateTotal();
        }

        private void Order_Removed(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void OrdersPnl_SizeChanged(object sender, EventArgs e)
        {
            ordersPnl.EditScreenByWidth();
        }

        public void CalculateTotal()
        {
            int sum = 0;
            for (int i = 0; i < ListOrder.Instance.Count; i++)
            {
                sum += ListOrder.Instance[i].Cake.Cost * ListOrder.Instance[i].Amount;
            }

            if (sum > 0)
            {
                valueCartLb.Text = sum.ToString().ConvertToMoney();
            }
            else
            {
                valueCartLb.Text = String.Empty;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ordersPnl.Controls.Clear();
            ListOrder.Instance.Clear();
        }

        private void AccessBtn_Click(object sender, EventArgs e)
        {
            if (ListOrder.Instance.Count > 0)
            {
                string error = null;
                if (BillData.Instance.Insert(acc.Employee, ref error))
                {
                    ordersPnl.Controls.Clear();
                    ListOrder.Instance.Clear();
                }
                else
                {
                    MessageBox.Show(error, "Thông báo");
                }
            }
        }
    }
}
