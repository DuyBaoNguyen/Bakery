using System.Windows.Forms;
using Bakery.MappingModel;

namespace Bakery
{
    public partial class EmployeeShortItem : UserControl
    {
        Employee data;

        public Employee Data
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
                    empIdLb.Text = data.Id.ToString();
                    empNameLb.Text = data.Name;
                }
                else
                {
                    empIdLb.Text = null;
                    empNameLb.Text = null;
                }
            }
        }

        public EmployeeShortItem()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel_Click(object sender, System.EventArgs e)
        {
            Panel container = this.FindForm().Controls["accInfoPnl"] as Panel;
            container.Controls["empIdPnl"].Controls[0].Text = data.Id.ToString();
            container.Controls["empNamePnl"].Controls[0].Text = data.Name;
        }
    }
}
