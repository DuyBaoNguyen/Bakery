using System.Drawing;
using System.Windows.Forms;
using Bakery.MappingModel;

namespace Bakery
{
    public partial class StatisticItem : UserControl
    {
        Statistic data;

        public Statistic Data
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
                    cakeImgPnl.Image = data.Cake.Image;
                    cakeIdLb.Text = data.Cake.Id.ToString();
                    cakeNameLb.Text = data.Cake.Name;
                    cakeAmountLb.Text = data.Amount.ToString();
                }
                else
                {
                    cakeImgPnl.Image = null;
                    cakeIdLb.Text = null;
                    cakeNameLb.Text = null;
                    cakeAmountLb.Text = null;
                }
            }
        }

        public StatisticItem()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(200, 200, 200)))
            {
                e.Graphics.DrawLine(pen, cakeIdLb.Location.X, this.Height - 1, this.Width - 1, this.Height - 1);
            }
        }
    }
}
