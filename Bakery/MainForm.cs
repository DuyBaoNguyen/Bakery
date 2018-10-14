using Bakery.MappingModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class MainForm : Form
    {
        static Account curAccount;

        public MainForm(Account acc)
        {
            InitializeComponent();
            curAccount = acc;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (curAccount.Admin)
            {
                managerPnl.BringToFront();
            }
            else
            {
                salePnl.BringToFront();
            }
        }
    }
}
