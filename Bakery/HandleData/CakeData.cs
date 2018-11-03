using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using Bakery.MappingModel;

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

        public List<Cake> GetCakes(bool cake_active, string searchString, string searchPro, bool sortAsc, string sortPro)
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
            int i = 0;

            DataTable dt = AccessDb.AccessDb.Instance.GetData("EXEC dbo.GetCakes @cake_active, @searchString, @searchPro, @sortAsc, @sortPro", sqlParas);
            // Get data Cakes(cake_id, cake_name, cake_cost, cake_image, cake_active)

            foreach (DataRow row in dt.Rows)
            {
                Cake cake = new Cake();
                cake = new Cake();
                cake.Id = (int)row[0];
                cake.Name = row[1].ToString();
                cake.Cost = (int)row[2];
                cake.Active = (bool)row[4];
                //if (row[3] != DBNull.Value)
                //{
                //    using (MemoryStream stream = new MemoryStream((byte[])row[3]))
                //    {
                //        cake.Image = Image.FromStream(stream);
                //    }
                //}
                //else
                //{
                //    cake.Image = null;
                //}
                cake.Image = Image.FromFile(@"C:\Users\duyba\Pictures\CoffeeIcon.png");
                cakes.Add(cake);
                i++;
            }
            return cakes;
        }
    }
}
