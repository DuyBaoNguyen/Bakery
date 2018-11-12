using Bakery.MappingModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bakery.HandleData
{
    public class SalaryData
    {
        static SalaryData instance;
        
        public static SalaryData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SalaryData();
                }
                return instance;
            }
        }

        private SalaryData() { }

        public List<Salary> GetSalary(string month, string year, ref string error)
        {
            List<Salary> sals = new List<Salary>();
            SqlParameter[] sqlParas = new SqlParameter[2];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "month",
                Value = month
            };
            sqlParas[1] = new SqlParameter()
            {
                ParameterName = "year",
                Value = year
            };

            DataSet ds = AccessDb.AccessDb.Instance.GetData("EXEC dbo.GetSalary @month, @year", sqlParas, ref error);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Salary sal = new Salary();
                    sal.Employee = new Employee();
                    sal.Employee.Id = (int)row[0];
                    sal.Employee.Name = row[1].ToString();
                    sal.Value = (int)row[2];
                    sal.Date = (DateTime)row[3];
                    sals.Add(sal);
                }
            }
            return sals;
        }

        public bool Insert(DataTable dt, ref string error)
        {
            SqlParameter[] sqlParas = new SqlParameter[1];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "sal_table",
                Value = dt,
                SqlDbType = SqlDbType.Structured,
                TypeName = "dbo.EmployeeSalary"
            };

            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC dbo.InsertSalary @sal_table", sqlParas, ref error);
        }

        public bool Delete(Salary sal, ref string error)
        {
            SqlParameter[] sqlParas = new SqlParameter[2];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "emp_id",
                Value = sal.Employee.Id
            };
            sqlParas[1] = new SqlParameter()
            {
                ParameterName = "sal_date",
                Value = sal.Date
            };

            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC dbo.DeleteSalary @emp_id, @sal_date", sqlParas, ref error);
        }

        public bool Update(Salary sal, ref string error)
        {
            SqlParameter[] sqlParas = new SqlParameter[2];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "emp_id",
                Value = sal.Employee.Id
            };
            sqlParas[1] = new SqlParameter()
            {
                ParameterName = "sal_value"
            };
            if (sal.Value != -1)
            {
                sqlParas[1].Value = sal.Value;
            }
            else
            {
                sqlParas[1].Value = DBNull.Value;
            }

            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC dbo.UpdateSalary @emp_id, @sal_value", sqlParas, ref error);
        }
    }
}
