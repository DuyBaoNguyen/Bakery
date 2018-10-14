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

        public bool CheckLogin(Account acc, ref string error)
        {
            SqlParameter[] sqlParas = new SqlParameter[2];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "username",
                Value = acc.Username
            };
            sqlParas[1] = new SqlParameter()
            {
                ParameterName = "password",
                Value = acc.Password
            };
            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC CheckLogin @username, @password", sqlParas, ref error);
        }

        public Account GetAccount(string username)
        {
            SqlParameter[] sqlParas = new SqlParameter[1];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "username",
                Value = username
            };
            DataTable dt = AccessDb.AccessDb.Instance.GetData("EXEC GetAccount @username", sqlParas);

            Account acc = new Account();
            acc.Username = dt.Rows[0][0].ToString();
            acc.Password = dt.Rows[0][1].ToString();
            acc.Admin = (bool)dt.Rows[0][2];
            acc.Employee = null;

            return acc;
        }
    }
}
