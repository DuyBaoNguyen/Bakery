using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bakery.Other;
using Bakery.MappingModel;
using Bakery.HandleData;
using System.Drawing;

namespace Bakery
{
    public partial class BillPanel : UserControl
    {
        List<Bill> bills;
        Color oddControlColor = Color.White;
        Color evenControlColor = Color.FromArgb(250, 250, 250);

        public BillPanel()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["managePnl"].BringToFront();
        }

        public void RefreshItem()
        {
            billsPnl.SuspendLayout();

            string day = dayCmb.Text;
            string month = monthCmb.Text;
            string year = yearCmb.Text;
            string error = null;

            bills = BillData.Instance.GetBills(day, month, year, ref error);

            if (error != null)
            {
                for (int i = billsPnl.Controls.Count - 1; i >= 0; i--)
                {
                    Control ctrl = billsPnl.Controls[i];
                    billsPnl.Controls.RemoveAt(i);
                    ctrl.Dispose();
                }
                billsPnl.ResumeLayout();
                if (this.Parent.Controls.IndexOf(this) == 0)
                {
                    MessageBox.Show(error, "Thông báo");
                }
                return;
            }

            BillItem[] billItems;

            if (bills.Count < billsPnl.Controls.Count)
            {
                for (int i = billsPnl.Controls.Count - 1; i >= bills.Count; i--)
                {
                    Control ctrl = billsPnl.Controls[i];
                    billsPnl.Controls.RemoveAt(i);
                    ctrl.Dispose();
                }
            }
            else if (bills.Count > billsPnl.Controls.Count)
            {
                billItems = new BillItem[bills.Count - billsPnl.Controls.Count];
                using (VScrollBar scrollBar = new VScrollBar())
                {
                    for (int i = 0; i < billItems.Length; i++)
                    {
                        billItems[i] = new BillItem();
                        billItems[i].Margin += new Padding(scrollBar.Width, 0, 0, 0);
                    }
                }
                billsPnl.Controls.AddRange(billItems);
            }

            for (int i = 0; i < billsPnl.Controls.Count; i++)
            {
                ((BillItem)billsPnl.Controls[i]).Data = bills[i];
            }
            billsPnl.EditScreenByWidth();
            billsPnl.InterleaveColor(oddControlColor, evenControlColor);
            billsPnl.ResumeLayout();
        }

        private void LoadDataBtn_Click(object sender, EventArgs e)
        {
            RefreshItem();
        }

        private void BillPanel_Load(object sender, EventArgs e)
        {
            dayCmb.AddDaysDataSource();
            monthCmb.AddMonthsDataSource();
            yearCmb.AddYearsDataSource(2018, 2040);
        }

        private void BillsPnl_SizeChanged(object sender, EventArgs e)
        {
            billsPnl.EditScreenByWidth();
        }
    }
}
