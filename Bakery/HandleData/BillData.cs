using Bakery.MappingModel;
using Bakery.Other;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bakery.HandleData
{
    public class BillData
    {
        static BillData instance;

        public static BillData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillData();
                }
                return instance;
            }
        }

        private BillData() { }

        public List<Bill> GetBills(string day, string month, string year, ref string error)
        {
            List<Bill> bills = new List<Bill>();

            SqlParameter[] sqlParas = new SqlParameter[3];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "day",
                Value = day
            };
            sqlParas[1] = new SqlParameter()
            {
                ParameterName = "month",
                Value = month
            };
            sqlParas[2] = new SqlParameter()
            {
                ParameterName = "year",
                Value = year
            };

            DataSet ds = AccessDb.AccessDb.Instance.GetData("EXEC dbo.GetBills @day, @month, @year", sqlParas, ref error);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Bill bill = new Bill();
                    bill.Id = (int)dt.Rows[i][0];
                    bill.PaymentDate = (DateTime)dt.Rows[i][1];
                    bill.Value = (int)dt.Rows[i][2];
                    if (dt.Rows[i][3] != DBNull.Value)
                    {
                        bill.Employee = new Employee();
                        bill.Employee.Id = (int)dt.Rows[i][3];
                        bill.Employee.Name = dt.Rows[i][4].ToString();
                    }
                    bills.Add(bill);
                }
            }
            return bills;
        }

        public bool Insert(Employee emp, ref string error)
        {
            SqlParameter[] sqlParas = new SqlParameter[2];
            sqlParas[0] = new SqlParameter();
            sqlParas[0].ParameterName = "emp_id";
            if (emp != null)
            {
                sqlParas[0].Value = emp.Id;
            }
            else
            {
                sqlParas[0].Value = DBNull.Value;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("cake_id", typeof(int));
            dt.Columns.Add("cake_amount", typeof(int));
            for (int i = 0; i < ListOrder.Instance.Count; i++)
            {
                dt.Rows.Add(ListOrder.Instance[i].Cake.Id, ListOrder.Instance[i].Amount);
            }

            sqlParas[1] = new SqlParameter();
            sqlParas[1].ParameterName = "orders";
            sqlParas[1].Value = dt;
            sqlParas[1].SqlDbType = SqlDbType.Structured;
            sqlParas[1].TypeName = "dbo.CakeOrder";

            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC dbo.InsertBill @emp_id, @orders", sqlParas, ref error);
        }
    }
}
