using Bakery.MappingModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.HandleData
{
    public class StatisticData
    {
        static StatisticData instance;

        public static StatisticData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StatisticData();
                }
                return instance;
            }
        }

        private StatisticData() { }

        public List<Statistic> GetStatistics(string day, string month, string year, ref string error)
        {
            List<Statistic> statistics = new List<Statistic>();

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

            DataSet ds = AccessDb.AccessDb.Instance.GetData("EXEC dbo.StatisticCakes @day, @month, @year", sqlParas, ref error);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    Statistic stat = new Statistic();
                    stat.Cake = new Cake();
                    stat.Cake.Id = (int)row[0];
                    stat.Cake.Name = row[1].ToString();
                    if (row[2] != DBNull.Value)
                    {
                        using (MemoryStream stream = new MemoryStream((byte[])row[2]))
                        {
                            stat.Cake.Image = Image.FromStream(stream);
                        }
                    }
                    else
                    {
                        stat.Cake.Image = null;
                    }
                    stat.Amount = (int)row[3];
                    statistics.Add(stat);
                }
            }
            return statistics;
        }

        public int GetIncome(string day, string month, string year, ref string error)
        {
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

            DataSet ds = AccessDb.AccessDb.Instance.GetData("SELECT dbo.GetIncome(@day, @month, @year)", sqlParas, ref error);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    return (int)dt.Rows[0][0];
                }
            }
            return 0;
        }
    }
}
