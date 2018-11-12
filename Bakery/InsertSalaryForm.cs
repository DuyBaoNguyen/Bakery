using Bakery.HandleData;
using Bakery.MappingModel;
using Bakery.Other;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Bakery
{
    public partial class InsertSalaryForm : Form
    {
        Color oddControlColor = Color.White;
        Color evenControlColor = Color.FromArgb(250, 250, 250);

        public InsertSalaryForm()
        {
            InitializeComponent();
        }

        private void InsertSalaryForm_Load(object sender, System.EventArgs e)
        {
            string error = null;
            List<Employee> emps = EmployeeData.Instance.GetEmployees("", "Mã nhân viên", true, "Mã nhân viên", ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Thông báo");
                return;
            }
            salPnl.SuspendLayout();
            using (VScrollBar scrollBar = new VScrollBar())
            {
                for (int i = 0; i < emps.Count; i++)
                {
                    InsertSalaryItem item = new InsertSalaryItem();
                    item.Info = emps[i];
                    item.Margin += new Padding(scrollBar.Width, 0, 0, 0);
                    salPnl.Controls.Add(item);
                }
            }
            salPnl.EditScreenByWidth();
            salPnl.InterleaveColor(oddControlColor, evenControlColor);
            salPnl.ResumeLayout();
        }

        private void SaveBtn_Click(object sender, System.EventArgs e)
        {
            foreach (InsertSalaryItem item in salPnl.Controls)
            {
                if (item.Check() == false)
                {
                    MessageBox.Show("Thông tin lương không chính xác!", "Thông báo");
                    return;
                }
            }

            string error = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("emp_id", typeof(int));
            dt.Columns.Add("sal_value", typeof(int));

            foreach (InsertSalaryItem item in salPnl.Controls)
            {
                if (item.Data != null)
                {
                    dt.Rows.Add(item.Data.EmployeeId, item.Data.SalaryValue);
                }
            }
            
            if (salPnl.Controls.Count > dt.Rows.Count)
            {
                DialogResult result = MessageBox.Show("Có " + (salPnl.Controls.Count - dt.Rows.Count) + " nhân viên chưa được nhập lương!", "Thông báo", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            if (SalaryData.Instance.Insert(dt, ref error) == false)
            {
                MessageBox.Show(error, "Thông báo");
            }
            else
            {
                this.Close();
            }
        }

        private void CancelBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void InsertSalaryForm_SizeChanged(object sender, System.EventArgs e)
        {
            salPnl.EditScreenByWidth();
        }
    }
}
