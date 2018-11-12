using System;
using System.Windows.Forms;
using Bakery.MappingModel;
using Bakery.Other;

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

        private void AmoutCakeNud_ValueChanged(object sender, EventArgs e)
        {
            data.Amount = (int)amoutCakeNud.Value;
            ((OrderPanel)this.Parent.Parent).CalculateTotal();
        }

        //public Control Check()
        //{
        //    int n = (int)amoutCakeNud.Value;
            
        //    if (int.TryParse(amoutCakeNud.Value.ToString(), out int result))
        //    {
        //        return null;
        //    }
        //    return amoutCakeNud;
        //}

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListOrder.Instance.Count; i++)
            {
                if (ListOrder.Instance[i].Cake.Id == data.Cake.Id)
                {
                    this.Parent.Controls.RemoveAt(i);
                    ListOrder.Instance.RemoveAt(i);
                    return;
                }
            }
            //((OrderPanel)this.Parent).RefreshItem();
        }
    }
}
