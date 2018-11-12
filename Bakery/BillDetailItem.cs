using System.Windows.Forms;
using Bakery.MappingModel;
using Bakery.Other;

namespace Bakery
{
    public partial class BillDetailItem : UserControl
    {
        BillDetail data;

        public BillDetail Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                cakeNameLb.Text = data.Cake.Name;
                cakeCostLb.Text = data.Cost.ToString().ConvertToMoney();
                cakeAmountLb.Text = data.Amount.ToString();
            }
        }

        public BillDetailItem()
        {
            InitializeComponent();
        }
    }
}
