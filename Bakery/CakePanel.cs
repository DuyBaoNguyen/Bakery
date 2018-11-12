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
    public partial class CakePanel : UserControl
    {
        bool inactCakeFirstLoad = true;
        public CakePanel()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["managePnl"].BringToFront();
        }

        private void InactiveCakeBtn_Click(object sender, EventArgs e)
        {
            inactCakePnl.BringToFront();
            if (inactCakeFirstLoad)
            {
                inactCakePnl.RefreshItem();
                inactCakeFirstLoad = false;
            }
        }
        
        private void ActiveCakeBtn_Click(object sender, EventArgs e)
        {
            actCakePnl.BringToFront();
        }
    }
}
