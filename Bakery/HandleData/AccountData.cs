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
            acc.Employee = null;

            return acc;
        }
    }
}
