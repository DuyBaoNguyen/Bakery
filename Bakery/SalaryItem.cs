using System.Windows.Forms;
using Bakery.HandleData;
using Bakery.MappingModel;
using Bakery.Other;

namespace Bakery
{
    public partial class SalaryItem : UserControl
    {
        Salary data;

        public Salary Data
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
                    empIdLb.Text = data.Employee.Id.ToString();
                    empNameLb.Text = data.Employee.Name;
                    salValueLb.Text = data.Value.ToString().ConvertToMoney();
                    salDateLb.Text = data.Date.ToString("dd/MM/yyyy");
                }
                else
                {
                    empIdLb.Text = null;
                    empNameLb.Text = null;
                    salValueLb.Text = null;
                    salDateLb.Text = null;
                }
            }
        }

        public SalaryItem()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string error = null;
                if (SalaryData.Instance.Delete(data, ref error))
                {
                    ((SalaryPanel)this.Parent.Parent).RefreshItem();
                }
                else
                {
                    MessageBox.Show(error, "Thông báo");
                }
            }
        }

        private void ContainerPnl_Click(object sender, System.EventArgs e)
        {
            UpdateSalaryForm form = new UpdateSalaryForm();
            form.Data = data;
            form.ShowDialog();
            ((SalaryPanel)this.Parent.Parent).RefreshItem();
        }
    }
}
