using System;
using System.Windows.Forms;
using Bakery.MappingModel;

namespace Bakery
{
    public partial class OrderItem : UserControl
    {
        Order data;

        public Order Data
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
                    imagePtb.Image = data.Cake.Image;
                    cakeNameLb.Text = data.Cake.Name;
                    cakeCostLb.Text = data.Cake.Cost.ToString();
                    amoutCakeNud.Value = data.Amount;
                }
                else
                {
                    imagePtb.Image = null;
                    cakeNameLb.Text = "";
                    cakeCostLb.Text = "";
                    amoutCakeNud.Value = 1;
                }
            }
        }

        public OrderItem()
        {
            InitializeComponent();
        }

        private void OrderItem_Load(object sender, EventArgs e)
        {
            amoutCakeNud.Margin = new Padding(0, (this.Height - amoutCakeNud.Height) / 2, 0, 0);
        }
    }
}
