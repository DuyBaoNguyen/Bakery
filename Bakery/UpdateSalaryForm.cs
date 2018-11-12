using Bakery.HandleData;
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
    public partial class UpdateSalaryForm : Form
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
                    salValueTxt.Text = data.Value.ToString();
                }
                else
                {
                    empIdLb.Text = null;
                    empNameLb.Text = null;
                    salValueTxt.Text = null;
                }
            }
        }

        public UpdateSalaryForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Salary sal = new Salary();
            sal.Employee = new Employee();
            sal.Employee.Id = data.Employee.Id;
            if (int.TryParse(salValueTxt.Text, out int value))
            {
                sal.Value = value;
            }
            else
            {
                sal.Value = -1;
            }

            string error = null;
            if (SalaryData.Instance.Update(sal, ref error))
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
