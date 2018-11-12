using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bakery.MappingModel;
using Bakery.HandleData;
using Bakery.Other;

namespace Bakery
{
    public partial class ActCakeItem : UserControl
    {
        int mouse_enter_dx = 10;
        int mouse_down_dx = 3;
        bool mouse_enter = false;
        bool mouse_click_del = false;
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

        public ActCakeItem()
        {
            InitializeComponent();
        }

        private void Container_MouseEnter(object sender, EventArgs e)
        {
            this.Margin -= new Padding(mouse_enter_dx);
            this.Size += new Size(mouse_enter_dx * 2, mouse_enter_dx * 2);
            mouse_enter = true;
            delBtn.Visible = true;
        }

        private void Container_MouseLeave(object sender, EventArgs e)
        {
            this.Size -= new Size(mouse_enter_dx * 2, mouse_enter_dx * 2);
            this.Margin += new Padding(mouse_enter_dx);
            mouse_enter = false;
            delBtn.Visible = false;
        }

        private void Container_SizeChanged(object sender, EventArgs e)
        {
            container.ImageHeight = container.Width;
            maskLb.Height = container.Width;
            cakeNameLb.Height = (container.Height - maskLb.Height) / 2;
        }

        private void Container_MouseDown(object sender, MouseEventArgs e)
        {
            RectangleF rec = new RectangleF(container.Width - 60, container.Height - 60, 50, 50);

            if (e.X >= delBtn.Location.X && e.X < delBtn.Location.X + delBtn.Width
                && e.Y >= delBtn.Location.Y && e.Y < delBtn.Location.Y + delBtn.Height)
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa bánh " + data.Name + "?", "Thông báo", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string error = "";
                    bool flag = CakeData.Instance.DeleteCake(data, ref error);
                    if (flag == false)
                    {
                        MessageBox.Show(error, "Thông báo");
                    }
                    else
                    {
                        ((InactCakePanel)this.Parent.Parent.Parent.Controls["inactCakePnl"]).RefreshItem();
                        ((ActCakePanel)this.Parent.Parent).RefreshItem();
                        return;
                    }
                }
                mouse_click_del = true;
            }
            else
            {
                this.Size -= new Size(mouse_down_dx * 2, mouse_down_dx * 2);
                this.Margin += new Padding(mouse_down_dx);
                mouse_click_del = false;
            }
        }

        private void Container_MouseUp(object sender, MouseEventArgs e)
        {
            if (!mouse_click_del)
            {
                this.Margin -= new Padding(mouse_down_dx);
                this.Size += new Size(mouse_down_dx * 2, mouse_down_dx * 2);
                ((ActCakePanel)this.Parent.Parent).RefreshItem();
            }
        }
        
        private void Container_Click(object sender, EventArgs e)
        {
            if (!mouse_click_del)
            {
                CakeInfoForm cakes = new CakeInfoForm(false);
                cakes.Data = data;
                cakes.ShowDialog();
            }
        }
    }
}
