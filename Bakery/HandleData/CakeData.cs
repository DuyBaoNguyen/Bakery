using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using Bakery.MappingModel;
using Bakery.Other;

namespace Bakery.HandleData
{
    public class CakeData
    {
        static CakeData instance = null;

        public static CakeData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CakeData();
                }
                return instance;
            }
        }

        private CakeData() { }

        public List<Cake> GetCakes(bool cake_active, string searchString, string searchPro, bool sortAsc, string sortPro, ref string error)
        {
            SqlParameter[] sqlParas = new SqlParameter[5];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "cake_active",
                Value = cake_active
            };
            sqlParas[1] = new SqlParameter()
            {
                ParameterName = "searchString",
                Value = searchString
            };
            sqlParas[2] = new SqlParameter()
            {
                ParameterName = "searchPro",
                Value = searchPro
            };
            sqlParas[3] = new SqlParameter()
            {
                ParameterName = "sortAsc",
                Value = sortAsc
            };
            sqlParas[4] = new SqlParameter()
            {
                ParameterName = "sortPro",
                Value = sortPro
            };

            List<Cake> cakes = new List<Cake>();
            
            DataSet ds = AccessDb.AccessDb.Instance.GetData("EXEC dbo.GetCakes @cake_active, @searchString, @searchPro, @sortAsc, @sortPro", sqlParas, ref error);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    Cake cake = new Cake();
                    cake = new Cake();
                    cake.Id = (int)row[0];
                    cake.Name = row[1].ToString();
                    cake.Cost = (int)row[2];
                    cake.Active = (bool)row[4];
                    if (row[3] != DBNull.Value)
                    {
                        using (MemoryStream stream = new MemoryStream((byte[])row[3]))
                        {
                            cake.Image = Image.FromStream(stream);
                        }
                    }
                    else
                    {
                        cake.Image = null;
                    }
                    cakes.Add(cake);
                }
            }
            return cakes;
        }

        public bool DeleteCake(Cake banh, ref string Error)
        {
            SqlParameter[] sqlParas = new SqlParameter[1];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "ID",
                Value = banh.Id
            };
            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC dbo.DeleteCake @ID", sqlParas, ref Error);
        }

        public bool AddCake(Cake cake, ref string Error) // hàm thêm bánh
        {
            SqlParameter[] sqlParas = new SqlParameter[4];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "cake_name",
                Value = cake.Name
            };
            sqlParas[1] = new SqlParameter()
            {
                ParameterName = "cake_cost"
            };
            if (cake.Cost == -1)
            {
                sqlParas[1].Value = DBNull.Value;
            }
            else
            {
                sqlParas[1].Value = cake.Cost;
            }
            sqlParas[2] = new SqlParameter()
            {
                ParameterName = "cake_image",
                SqlDbType = SqlDbType.Image
            };
            if (cake.Image != null)
            {
                sqlParas[2].Value = cake.Image.ConvertToBytes();
            }
            else
            {
                sqlParas[2].Value = DBNull.Value;
            }
            sqlParas[3] = new SqlParameter()
            {
                ParameterName = "cake_active",
                Value = cake.Active
            };
            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC dbo.AddCake @cake_name, @cake_cost, @cake_image, @cake_active", sqlParas, ref Error);
        }

        public bool EditCake(Cake cake, ref string Error) // hàm sửa thông tin của bánh.
        {
            SqlParameter[] sqlParas = new SqlParameter[5];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "cake_ID",
                Value = cake.Id
            };
            sqlParas[1] = new SqlParameter()
            {
                ParameterName = "cake_name",
                Value = cake.Name
            };
            sqlParas[2] = new SqlParameter()
            {
                ParameterName = "cake_cost"
            };
            if (cake.Cost == -1)
            {
                sqlParas[2].Value = DBNull.Value;
            }
            else
            {
                sqlParas[2].Value = cake.Cost;
            }
            sqlParas[3] = new SqlParameter()
            {
                ParameterName = "cake_image",
                SqlDbType = SqlDbType.Image
            };
             if (cake.Image != null)
            {
                sqlParas[3].Value = cake.Image.ConvertToBytes();
            }
            else
            {
                sqlParas[3].Value = DBNull.Value;
            }
            sqlParas[4] = new SqlParameter()
            {
                ParameterName = "cake_active",
                Value = cake.Active
            };
            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC dbo.EditCake @cake_ID, @cake_name, @cake_cost, @cake_image, @cake_active", sqlParas, ref Error);
        }

        public bool RestoreCake(Cake cake, ref string error)
        {
            SqlParameter[] sqlParas = new SqlParameter[1];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "cake_id",
                Value = cake.Id
            };

            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC dbo.RestoreCake @cake_id", sqlParas, ref error);
        }
    }
}
