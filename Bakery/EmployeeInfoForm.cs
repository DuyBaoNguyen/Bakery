using Bakery.HandleData;
using Bakery.MappingModel;
using System;
using System.Windows.Forms;

namespace Bakery
{
    public partial class EmployeeInfoForm : Form
    {
        bool addEmp;
        Employee data;

        public Employee Data {
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
                    empNameTxt.Text = data.Name;
                    empFemaleSexRbn.Checked = !data.Sex;
                    if (data.Birthday == DateTime.MinValue)
                    {
                        empBirthdayDtp.Value = DateTime.Now;
                    }
                    else
                    {
                        empBirthdayDtp.Value = data.Birthday;
                    }
                    empAddressTxt.Text = data.Address;
                    empNumberPhoneTxt.Text = data.NumberPhone;
                    empIdCodeTxt.Text = data.IdCode;
                    empDateOfJoinLb.Text = data.DateOfJoin.ToString("dd/MM/yyyy");
                }
                else
                {
                    empIdLb.Text = null;
                    empNameTxt.Text = null;
                    empBirthdayDtp.Value = DateTime.Now;
                    empAddressTxt.Text = null;
                    empNumberPhoneTxt.Text = null;
                    empIdCodeTxt.Text = null;
                    empDateOfJoinLb = null;
                }
            }
        }
        
        public EmployeeInfoForm(bool addEmp)
        {
            InitializeComponent();
            this.addEmp = addEmp;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string error = null;
            bool result_query;

            Employee emp = new Employee();
            emp.Name = empNameTxt.Text;
            emp.Sex = empMaleSexRbn.Checked;
            emp.Birthday = empBirthdayDtp.Value;
            emp.Address = empAddressTxt.Text;
            emp.NumberPhone = empNumberPhoneTxt.Text;
            emp.IdCode = empIdCodeTxt.Text;

            if (addEmp)
            {
                result_query = EmployeeData.Instance.Insert(emp, ref error);
            }
            else
            {
                emp.Id = data.Id;
                result_query = EmployeeData.Instance.Update(emp, ref error);
            }

            if (result_query)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(error, "Thông báo");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
