using System.Windows.Forms;
using Bakery.MappingModel;
using Bakery.Other;

namespace Bakery
{
    public partial class BillItem : UserControl
    {
        Bill data;

        public Bill Data
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
                    billIdLb.Text = data.Id.ToString();
                    billPaymentDateLb.Text = data.PaymentDate.ToString("dd/MM/yyyy hh:mm:ss tt");
                    billValueLb.Text = data.Value.ToString().ConvertToMoney();
                    if (data.Employee != null)
                    {
                        empIdLb.Text = data.Employee.Id.ToString();
                        empNameLb.Text = data.Employee.Name;
                    }
                    else
                    {
                        empIdLb.Text = null;
                        empNameLb.Text = null;
                    }
                }
                else
                {
                    billIdLb.Text = null;
                    billPaymentDateLb.Text = null;
                    billValueLb.Text = null;
                    empIdLb.Text = null;
                    empNameLb.Text = null;
                }
            }
        }

        public BillItem()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel1_Click(object sender, System.EventArgs e)
        {
            BillInfoForm form = new BillInfoForm();
            form.Data = data;
            form.ShowDialog();
        }
    }
}
