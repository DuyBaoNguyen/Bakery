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
    public partial class SalePanel : UserControl
    {
        public SalePanel()
        {
            InitializeComponent();
        }

        private void MenuItem_Paint(object sender, PaintEventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            if (rdb.Checked)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 122, 255)))
                {
                    e.Graphics.FillRectangle(brush, 0, 0, 5, rdb.Height);
                }
            }
        }
    }
}
