using Bakery.MappingModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.HandleData
{
    public class BillDetailData
    {
        static BillDetailData instance;

        public static BillDetailData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDetailData();
                }
                return instance;
            }
        }

        private BillDetailData() { }

        public List<BillDetail> GetBillDetails(int billId)
        {
            List<BillDetail> billDetails = new List<BillDetail>();

            SqlParameter[] sqlParas = new SqlParameter[1];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "bill_id",
                Value = billId
            };

            string error = null;
            DataSet ds = AccessDb.AccessDb.Instance.GetData("EXEC dbo.GetBillDetails @bill_id", sqlParas, ref error);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BillDetail billDetail = new BillDetail();
                    billDetail.Bill = new Bill();
                    billDetail.Bill.Id = (int)dt.Rows[i][0];
                    billDetail.Bill.PaymentDate = (DateTime)dt.Rows[i][1];
                    billDetail.Bill.Value = (int)dt.Rows[i][2];
                    if (dt.Rows[i][3] != DBNull.Value)
                    {
                        billDetail.Bill.Employee = new Employee();
                        billDetail.Bill.Employee.Id = (int)dt.Rows[i][3];
                        billDetail.Bill.Employee.Name = dt.Rows[i][4].ToString();
                    }
                    billDetail.Cake = new Cake();
                    billDetail.Cake.Name = dt.Rows[i][5].ToString();
                    billDetail.Cost = (int)dt.Rows[i][6];
                    billDetail.Amount = (int)dt.Rows[i][7];
                    billDetails.Add(billDetail);
                }
            }

            return billDetails;
        }
    }
}
