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
            return @"Server = " + Properties.Settings.Default.ServerName + 
                    ";Database = QuanLyTiemBanh" +
                    ";User Id = " + Properties.Settings.Default.Username + 
                    ";Password = " + Properties.Settings.Default.Password + ";";
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

        public DataSet GetData(string query, SqlParameter[] sqlParas, ref string error)
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();

            com.Parameters.AddRange(sqlParas);

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                da.Fill(ds);
                con.Close();
            }
            catch (SqlException e)
            {
                if (e.Class == 16 && e.State == 1)
                {
                    error = e.Message;
                }
                else
                {
                    error = "Đã có lỗi xảy ra hoặc bạn không được quyền truy xuất dữ liệu này!";
                }
            }
            finally
            {
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
            }
            return ds;
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
            catch (SqlException e)
            {
                if (e.Class == 16 && e.State == 1)
                {
                    error = e.Message;
                }
                else
                {
                    error = "Đã có lỗi xảy ra hoặc bạn không được quyền truy xuất dữ liệu này!";
                }
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

        public object ExcuteScalar(string query, SqlParameter[] sqlParas, ref string error)
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
                return com.ExecuteScalar();
            }
            catch (SqlException e)
            {
                if (e.Class == 16 && e.State == 1)
                {
                    error = e.Message;
                }
                else
                {
                    error = "Đã có lỗi xảy ra hoặc bạn không được quyền truy xuất dữ liệu này!";
                }
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
