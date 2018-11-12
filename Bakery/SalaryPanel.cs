using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Bakery.MappingModel;
using Bakery.HandleData;
using Bakery.Other;

namespace Bakery
{
    public partial class SalaryPanel : UserControl
    {
        List<Salary> sals;
        Color oddControlColor = Color.White;
        Color evenControlColor = Color.FromArgb(250, 250, 250);

        public SalaryPanel()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["managePnl"].BringToFront();
        }

        public void RefreshItem()
        {
            salPnl.SuspendLayout();

            string month = monthCmb.Text;
            string year = yearCmb.Text;
            string error = null;

            sals = SalaryData.Instance.GetSalary(month, year, ref error);

            if (error != null)
            {
                for (int i = salPnl.Controls.Count - 1; i >= 0; i--)
                {
                    Control ctrl = salPnl.Controls[i];
                    salPnl.Controls.RemoveAt(i);
                    ctrl.Dispose();
                }
                salPnl.ResumeLayout();
                if (this.Parent.Controls.IndexOf(this) == 0)
                {
                    MessageBox.Show(error, "Thông báo");
                }
                return;
            }

            SalaryItem[] salItems;

            if (sals.Count < salPnl.Controls.Count)
            {
                for (int i = salPnl.Controls.Count - 1; i >= sals.Count; i--)
                {
                    Control ctrl = salPnl.Controls[i];
                    salPnl.Controls.RemoveAt(i);
                    ctrl.Dispose();
                }
            }
            else if (sals.Count > salPnl.Controls.Count)
            {
                salItems = new SalaryItem[sals.Count - salPnl.Controls.Count];
                using (VScrollBar scrollBar = new VScrollBar())
                {
                    for (int i = 0; i < salItems.Length; i++)
                    {
                        salItems[i] = new SalaryItem();
                        salItems[i].Margin += new Padding(scrollBar.Width, 0, 0, 0);
                    }
                }
                salPnl.Controls.AddRange(salItems);
            }

            for (int i = 0; i < salPnl.Controls.Count; i++)
            {
                ((SalaryItem)salPnl.Controls[i]).Data = sals[i];
            }
            salPnl.EditScreenByWidth();
            salPnl.InterleaveColor(oddControlColor, evenControlColor);
            salPnl.ResumeLayout();
        }

        private void LoadDataBtn_Click(object sender, EventArgs e)
        {
            RefreshItem();
        }

        private void SalaryPanel_Load(object sender, EventArgs e)
        {
            monthCmb.AddMonthsDataSource();
            yearCmb.AddYearsDataSource(2018, 2040);
        }

        private void AddSalBtn_Click(object sender, EventArgs e)
        {
            InsertSalaryForm form = new InsertSalaryForm();
            form.ShowDialog();
        }

        private void SalaryPanel_SizeChanged(object sender, EventArgs e)
        {
            salPnl.EditScreenByWidth();
        }
    }
}
