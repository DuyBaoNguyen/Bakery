using Bakery.MappingModel;
using Bakery.Other;
using System;
using System.Windows.Forms;

namespace Bakery
{
    public partial class OrderCakeForm : Form
    {
        Cake data;

        public Cake Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                if (data != null)
                {
                    imagePnl.Image = data.Image;
                    cakeNameLb.Text = data.Name;
                    cakeCostLb.Text = data.Cost.ToString();
                }
                else
                {
                    imagePnl.Image = null;
                    cakeNameLb.Text = "";
                    cakeCostLb.Text = "";
                }
            }
        }

        public OrderCakeForm()
        {
            InitializeComponent();
        }

        private void AccessBtn_Click(object sender, EventArgs e)
        {
            if (amountCakeNud.Value == 0 || amountCakeNud.Value.ToString() == "")
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            
            for (int i = 0; i < ListOrder.Instance.Count; i++)
            {
                if (ListOrder.Instance[i].Cake.Id == data.Id)
                {
                    ListOrder.Instance[i].Amount += (int)amountCakeNud.Value;
                    this.Close();
                    return;
                }
            }

            Order order = new Order();
            order.Cake = data;
            order.Amount = (int)amountCakeNud.Value;
            ListOrder.Instance.Add(order);
            this.Close();
        }
    }
}
