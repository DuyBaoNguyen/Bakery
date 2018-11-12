using System;
using System.Drawing;
using System.Windows.Forms;
using Bakery.MappingModel;
using Bakery.Other;

namespace Bakery
{
    public partial class CakeItem : UserControl
    {
        int mouse_enter_dx = 10;
        int mouse_down_dx = 3;
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
                    container.Image = data.Image;
                    cakeNameLb.Text = data.Name;
                    cakeCostLb.Text = data.Cost.ToString().ConvertToMoney();
                }
                else
                {
                    container.Image = null;
                    cakeNameLb.Text = "";
                    cakeCostLb.Text = "";
                }
            }
        }

        public CakeItem()
        {
            InitializeComponent();
        }

        private void Container_MouseEnter(object sender, EventArgs e)
        {
            this.Margin -= new Padding(mouse_enter_dx);
            this.Size += new Size(mouse_enter_dx * 2, mouse_enter_dx * 2);
        }

        private void Container_MouseLeave(object sender, EventArgs e)
        {
            this.Size -= new Size(mouse_enter_dx * 2, mouse_enter_dx * 2);
            this.Margin += new Padding(mouse_enter_dx);
        }

        private void Container_SizeChanged(object sender, EventArgs e)
        {
            container.ImageHeight = container.Width;
            maskLb.Height = container.Width;
            cakeNameLb.Height = (container.Height - maskLb.Height) / 2;
        }

        private void Container_MouseDown(object sender, MouseEventArgs e)
        {
            this.Size -= new Size(mouse_down_dx * 2, mouse_down_dx * 2);
            this.Margin += new Padding(mouse_down_dx);
        }

        private void Container_MouseUp(object sender, MouseEventArgs e)
        {
            this.Margin -= new Padding(mouse_down_dx);
            this.Size += new Size(mouse_down_dx * 2, mouse_down_dx * 2);
        }

        private void Container_Click(object sender, EventArgs e)
        {
            OrderCakeForm orderCakeForm = new OrderCakeForm();
            orderCakeForm.Data = data;
            orderCakeForm.ShowDialog();
        }
    }
}
