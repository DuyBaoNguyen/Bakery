using Bakery.MappingModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bakery.HandleData
{
    public class AccountData
    {
        static AccountData instance = null;

        public static AccountData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountData();
                }
                return instance;
            }
        }

        private AccountData() { }

        public Account GetAccount(string username)
        {
            SqlParameter[] sqlParas = new SqlParameter[1];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "login_name",
                Value = username
            };

            string error = null;
            DataSet ds = AccessDb.AccessDb.Instance.GetData("EXEC dbo.GetAccount @login_name", sqlParas, ref error);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];

                Account acc = new Account();
                acc.Username = dt.Rows[0][0].ToString();
                if (dt.Rows[0][1] != DBNull.Value)
                {
                    acc.Employee = new Employee();
                    acc.Employee.Id = (int)dt.Rows[0][2];
                    acc.Employee.Name = dt.Rows[0][3].ToString();
                }
                return acc;
            }
            return null;
        }

        public List<Account> GetAccounts(string searchString, string searchPro, bool sortAsc, string sortPro, ref string error)
        {
            List<Account> accs = new List<Account>();

            SqlParameter[] sqlParas = new SqlParameter[4];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "searchString",
                Value = searchString
            };
            sqlParas[1] = new SqlParameter()
            {
                ParameterName = "searchPro",
                Value = searchPro
            };
            sqlParas[2] = new SqlParameter()
            {
                ParameterName = "sortAsc",
                Value = sortAsc
            };
            sqlParas[3] = new SqlParameter()
            {
                ParameterName = "sortPro",
                Value = sortPro
            };
            
            DataSet ds = AccessDb.AccessDb.Instance.GetData("EXEC dbo.GetAccounts @searchString, @searchPro, @sortAsc, @sortPro", sqlParas, ref error);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Account acc = new Account();
                    acc.Username = dt.Rows[i][0].ToString();
                    acc.Permission = dt.Rows[i][1].ToString();
                    acc.Employee = new Employee();
                    acc.Employee.Id = (int)dt.Rows[i][2];
                    acc.Employee.Name = dt.Rows[i][3].ToString();
                    accs.Add(acc);
                }
            }
            return accs;
        }

        public bool Insert(Account acc, ref string error)
        {
            SqlParameter[] sqlParas = new SqlParameter[4];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "login_name",
                Value = acc.Username
            };
            sqlParas[1] = new SqlParameter()
            {
                ParameterName = "password",
                Value = acc.Password
            };
            sqlParas[2] = new SqlParameter();
            sqlParas[2].ParameterName = "emp_id";
            if (acc.Employee != null)
            {
                sqlParas[2].Value = acc.Employee.Id;
            }
            else
            {
                sqlParas[2].Value = DBNull.Value;
            }
            sqlParas[3] = new SqlParameter()
            {
                ParameterName = "permission",
                Value = acc.Permission
            };

            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC dbo.InsertAccount @login_name, @password, @emp_id, @permission", sqlParas, ref error);
        }

        public bool Delete(Account acc, ref string error)
        {
            SqlParameter[] sqlParas = new SqlParameter[1];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "login_name",
                Value = acc.Username
            };

            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC dbo.DeleteAccount @login_name", sqlParas, ref error);
        }

        public bool Update(Account acc, ref string error)
        {
            SqlParameter[] sqlParas = new SqlParameter[3];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "login_name",
                Value = acc.Username
            };
            sqlParas[1] = new SqlParameter()
            {
                ParameterName = "password",
                Value = acc.Password
            };
            sqlParas[2] = new SqlParameter()
            {
                ParameterName = "permission",
                Value = acc.Permission
            };

            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC dbo.UpdateAccount @login_name, @password, @permission", sqlParas, ref error);
        }
    }
}
