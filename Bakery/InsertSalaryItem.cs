using Bakery.MappingModel;
using System.Windows.Forms;

namespace Bakery
{
    public partial class InsertSalaryItem : UserControl
    {
        Employee info;

        public Employee Info
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
                if (info != null)
                {
                    empIdLb.Text = info.Id.ToString();
                    empNameLb.Text = info.Name;
                }
                else
                {
                    empIdLb.Text = null;
                    empNameLb.Text = null;
                }
            }
        }

        public EmployeeSalary Data
        {
            get
            {
                if (salValueTxt.Text != string.Empty)
                {
                    EmployeeSalary emp_sal = new EmployeeSalary();
                    emp_sal.EmployeeId = info.Id;
                    emp_sal.SalaryValue = int.Parse(salValueTxt.Text);
                    return emp_sal;
                }
                return null;
            }
        }

        public InsertSalaryItem()
        {
            InitializeComponent();
        }

        public bool Check()
        {
            if (salValueTxt.Text != string.Empty)
            {
                return int.TryParse(salValueTxt.Text, out int tmp);
            }
            return true;
        }
    }
}
