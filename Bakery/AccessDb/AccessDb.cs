using System.Data;
using System.Data.SqlClient;

namespace Bakery.AccessDb
{
    public class AccessDb
    {
        static AccessDb instance = null;
        public static string LoginName { private get; set; }
        public static string Password { private get; set; }

        public static AccessDb Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccessDb();
                }
                return instance;
            }
        }

        private AccessDb() { }

        private string GetConnectionString()
        {
            return @"Data Source=" + Properties.Settings.Default.ServerName + ";Initial Catalog=QuanLyTiemBanh;Integrated Security=SSPI;" +
                    "User ID=" + LoginName + ";Password= " + Password + ";";
        }

        public bool ConnectDatabase()
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
                if (con != null)
                {
                    con.Dispose();
                }
            }
        }

        public DataTable GetData(string query, SqlParameter[] sqlParas)
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            com.Parameters.AddRange(sqlParas);
            
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            da.Fill(dt);

            con.Close();
            if (con != null)
            {
                con.Dispose();
            }
            if (com != null)
            {
                com.Dispose();
            }
            if (da != null)
            {
                da.Dispose();
            }
            return dt;
        }

        public bool ExcuteQuery(string query, SqlParameter[] sqlParas, ref string error)
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddRange(sqlParas);
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                com.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                con.Close();
                if (con != null)
                {
                    con.Dispose();
                }
                if (com != null)
                {
                    com.Dispose();
                }
            }
        }
    }
}
