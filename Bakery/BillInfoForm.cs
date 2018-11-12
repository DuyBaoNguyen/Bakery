using Bakery.HandleData;
using Bakery.MappingModel;
using Bakery.Other;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bakery
{
    public partial class BillInfoForm : Form
    {
        public Bill Data { get; set; }
        Color oddControlColor = Color.White;
        Color evenControlColor = Color.FromArgb(250, 250, 250);

        public BillInfoForm()
        {
            InitializeComponent();
        }

        private void BillInfoForm_Load(object sender, EventArgs e)
        {
            List<BillDetail> billDetails = BillDetailData.Instance.GetBillDetails(Data.Id);

            BillDetail billDetail = billDetails[0];
            billIdLb.Text = billDetail.Bill.Id.ToString();
            billPaymentDateLb.Text = billDetail.Bill.PaymentDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            billValueLb.Text = billDetail.Bill.Value.ToString().ConvertToMoney();
            if (billDetail.Bill.Employee != null)
            {
                empIdLb.Text = billDetail.Bill.Employee.Id.ToString();
                empNameLb.Text = billDetail.Bill.Employee.Name;
            }

            for (int i = 0; i < billDetails.Count; i++)
            {
                BillDetailItem billDetailItem = new BillDetailItem();
                billDetailItem.Data = billDetails[i];
                using (VScrollBar scrollBar = new VScrollBar())
                {
                    billDetailItem.Margin += new Padding(scrollBar.Width, 0, 0, 0);
                }
                billDetailsPnl.Controls.Add(billDetailItem);
            }

            billDetailsPnl.EditScreenByWidth();
            billDetailsPnl.InterleaveColor(oddControlColor, evenControlColor);
        }
    }
}
