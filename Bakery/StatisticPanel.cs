using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Bakery.MappingModel;
using Bakery.HandleData;
using Bakery.Other;

namespace Bakery
{
    public partial class StatisticPanel : UserControl
    {
        List<Statistic> statistics;
        //Color oddControlColor = Color.White;
        //Color evenControlColor = Color.FromArgb(250, 250, 250);

        public StatisticPanel()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["managePnl"].BringToFront();
        }

        public void RefreshItem()
        {
            cakesPnl.SuspendLayout();

            string day = dayCmb.Text;
            string month = monthCmb.Text;
            string year = yearCmb.Text;
            string error1 = null;
            string error2 = null;

            statistics = StatisticData.Instance.GetStatistics(day, month, year, ref error1);

            if (error1 != null)
            {
                for (int i = cakesPnl.Controls.Count - 1; i >= 0; i--)
                {
                    Control ctrl = cakesPnl.Controls[i];
                    cakesPnl.Controls.RemoveAt(i);
                    ctrl.Dispose();
                }
                incomeLb.Text = null;
                cakesPnl.ResumeLayout();
                if (this.Parent.Controls.IndexOf(this) == 0)
                {
                    MessageBox.Show(error1, "Thông báo");
                }
                return;
            }

            int income = StatisticData.Instance.GetIncome(day, month, year, ref error2);
            
            if (error2 != null)
            {
                for (int i = cakesPnl.Controls.Count - 1; i >= 0; i--)
                {
                    Control ctrl = cakesPnl.Controls[i];
                    cakesPnl.Controls.RemoveAt(i);
                    ctrl.Dispose();
                }
                incomeLb.Text = null;
                cakesPnl.ResumeLayout();
                if (this.Parent.Controls.IndexOf(this) == 0)
                {
                    MessageBox.Show(error2, "Thông báo");
                }
                return;
            }

            incomeLb.Text = income.ToString().ConvertToMoney();

            StatisticItem[] statItems;

            if (statistics.Count < cakesPnl.Controls.Count)
            {
                for (int i = cakesPnl.Controls.Count - 1; i >= statistics.Count; i--)
                {
                    Control ctrl = cakesPnl.Controls[i];
                    cakesPnl.Controls.RemoveAt(i);
                    ctrl.Dispose();
                }
            }
            else if (statistics.Count > cakesPnl.Controls.Count)
            {
                statItems = new StatisticItem[statistics.Count - cakesPnl.Controls.Count];
                using (VScrollBar scrollBar = new VScrollBar())
                {
                    for (int i = 0; i < statItems.Length; i++)
                    {
                        statItems[i] = new StatisticItem();
                        statItems[i].Margin += new Padding(scrollBar.Width, 0, 0, 0);
                    }
                }
                cakesPnl.Controls.AddRange(statItems);
            }

            for (int i = 0; i < cakesPnl.Controls.Count; i++)
            {
                ((StatisticItem)cakesPnl.Controls[i]).Data = statistics[i];
            }
            cakesPnl.EditScreenByWidth();
            //cakesPnl.InterleaveColor(oddControlColor, evenControlColor);
            cakesPnl.ResumeLayout();
        }

        private void LoadDataBtn_Click(object sender, EventArgs e)
        {
            RefreshItem();
        }

        private void StatisticPanel_Load(object sender, EventArgs e)
        {
            dayCmb.AddDaysDataSource();
            monthCmb.AddMonthsDataSource();
            yearCmb.AddYearsDataSource(2018, 2040);
        }

        private void CakesPnl_SizeChanged(object sender, EventArgs e)
        {
            cakesPnl.EditScreenByWidth();
        }

        private void cakesPnl_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
