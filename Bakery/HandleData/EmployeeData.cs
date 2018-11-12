using Bakery.MappingModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bakery.HandleData
{
    public class EmployeeData
    {
        static EmployeeData instance;

        public static EmployeeData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeData();
                }
                return instance;
            }
        }

        private EmployeeData() { }

        public List<Employee> GetEmployees(string searchString, string searchPro, bool sortAsc, string sortPro, ref string error)
        {
            List<Employee> emps = new List<Employee>();

            SqlParameter[] sqlParas = new SqlParameter[4];
            sqlParas[0] = new SqlParameter
            {
                ParameterName = "searchString",
                Value = searchString
            };
            sqlParas[1] = new SqlParameter
            {
                ParameterName = "searchPro",
                Value = searchPro
            };
            sqlParas[2] = new SqlParameter
            {
                ParameterName = "sortAsc",
                Value = sortAsc
            };
            sqlParas[3] = new SqlParameter
            {
                ParameterName = "sortPro",
                Value = sortPro
            };

            DataSet ds = AccessDb.AccessDb.Instance.GetData("EXEC dbo.GetEmployees @searchString, @searchPro, @sortAsc, @sortPro", sqlParas, ref error);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Employee emp = new Employee();
                    emp.Id = (int)dt.Rows[i][0];
                    emp.Name = dt.Rows[i][1].ToString();
                    emp.Sex = (bool)dt.Rows[i][2];
                    if (dt.Rows[i][3] != DBNull.Value)
                    {
                        emp.Birthday = (DateTime)dt.Rows[i][3];
                    }
                    else
                    {
                        emp.Birthday = DateTime.MinValue;
                    }
                    if (dt.Rows[i][4] != DBNull.Value)
                    {
                        emp.Address = dt.Rows[i][4].ToString();
                    }
                    else
                    {
                        emp.Address = null;
                    }
                    if (dt.Rows[i][5] != DBNull.Value)
                    {
                        emp.NumberPhone = dt.Rows[i][5].ToString();
                    }
                    else
                    {
                        emp.NumberPhone = null;
                    }
                    if (dt.Rows[i][6] != DBNull.Value)
                    {
                        emp.IdCode = dt.Rows[i][6].ToString();
                    }
                    else
                    {
                        emp.IdCode = null;
                    }
                    emp.DateOfJoin = (DateTime)dt.Rows[i][7];
                    emps.Add(emp);
                }
            }
            return emps;
        }

        public List<Employee> GetEmpsNoAccount(string searchString, string searchPro, ref string error)
        {
            List<Employee> emps = new List<Employee>();

            SqlParameter[] sqlParas = new SqlParameter[2];
            sqlParas[0] = new SqlParameter
            {
                ParameterName = "searchString",
                Value = searchString
            };
            sqlParas[1] = new SqlParameter
            {
                ParameterName = "searchPro",
                Value = searchPro
            };

            DataSet ds = AccessDb.AccessDb.Instance.GetData("EXEC dbo.GetEmpsNoAccount @searchString, @searchPro", sqlParas, ref error);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Employee emp = new Employee();
                    emp.Id = (int)dt.Rows[i][0];
                    emp.Name = dt.Rows[i][1].ToString();
                    emps.Add(emp);
                }
            }
            return emps;
        }

        public bool Insert(Employee emp, ref string error)
        {
            SqlParameter[] sqlParas = new SqlParameter[6];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "emp_name",
                Value = emp.Name
            };
            sqlParas[1] = new SqlParameter()
            {
                ParameterName = "emp_sex",
                Value = emp.Sex
            };
            sqlParas[2] = new SqlParameter()
            {
                ParameterName = "emp_birthday"
            };
            if (emp.Birthday.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                sqlParas[2].Value = DBNull.Value;
            }
            else
            {
                sqlParas[2].Value = emp.Birthday;
            }
            sqlParas[3] = new SqlParameter()
            {
                ParameterName = "emp_address"
            };
            if (emp.Address != String.Empty)
            {
                sqlParas[3].Value = emp.Address;
            }
            else
            {
                sqlParas[3].Value = DBNull.Value;
            }
            sqlParas[4] = new SqlParameter()
            {
                ParameterName = "emp_number_phone",
            };
            if (emp.NumberPhone != String.Empty)
            {
                sqlParas[4].Value = emp.NumberPhone;
            }
            else
            {
                sqlParas[4].Value = DBNull.Value;
            }
            sqlParas[5] = new SqlParameter()
            {
                ParameterName = "emp_id_code"
            };
            if (emp.IdCode != String.Empty)
            {
                sqlParas[5].Value = emp.IdCode;
            }
            else
            {
                sqlParas[5].Value = DBNull.Value;
            }
            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC dbo.InsertEmployee @emp_name, @emp_sex, @emp_birthday, @emp_address, @emp_number_phone, @emp_id_code", sqlParas, ref error);
        }

        public bool Delete(Employee emp, ref string error)
        {
            SqlParameter[] sqlParas = new SqlParameter[1];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "emp_id",
                Value = emp.Id
            };
            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC dbo.DeleteEmployee @emp_id", sqlParas, ref error);
        }

        public bool Update(Employee emp, ref string error)
        {
            SqlParameter[] sqlParas = new SqlParameter[7];
            sqlParas[0] = new SqlParameter()
            {
                ParameterName = "emp_id",
                Value = emp.Id
            };
            sqlParas[1] = new SqlParameter()
            {
                ParameterName = "emp_name",
                Value = emp.Name
            };
            sqlParas[2] = new SqlParameter()
            {
                ParameterName = "emp_sex",
                Value = emp.Sex
            };
            sqlParas[3] = new SqlParameter()
            {
                ParameterName = "emp_birthday"
            };
            if (emp.Birthday.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                sqlParas[3].Value = DBNull.Value;
            }
            else
            {
                sqlParas[3].Value = emp.Birthday;
            }
            sqlParas[4] = new SqlParameter()
            {
                ParameterName = "emp_address"
            };
            if (emp.Address != String.Empty)
            {
                sqlParas[4].Value = emp.Address;
            }
            else
            {
                sqlParas[4].Value = DBNull.Value;
            }
            sqlParas[5] = new SqlParameter()
            {
                ParameterName = "emp_number_phone",
            };
            if (emp.NumberPhone != String.Empty)
            {
                sqlParas[5].Value = emp.NumberPhone;
            }
            else
            {
                sqlParas[5].Value = DBNull.Value;
            }
            sqlParas[6] = new SqlParameter()
            {
                ParameterName = "emp_id_code"
            };
            if (emp.IdCode != String.Empty)
            {
                sqlParas[6].Value = emp.IdCode;
            }
            else
            {
                sqlParas[6].Value = DBNull.Value;
            }
            return AccessDb.AccessDb.Instance.ExcuteQuery("EXEC dbo.UpdateEmployee @emp_id, @emp_name, @emp_sex, @emp_birthday, @emp_address, @emp_number_phone, @emp_id_code", sqlParas, ref error);
        }
    }
}
