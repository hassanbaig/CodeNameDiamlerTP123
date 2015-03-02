using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DiamlerTP.DAL;

namespace DiamlerTP
{
    public class EmployeeInfoDataProvider
    {
        private readonly DataProvider _dataProvider;

        public EmployeeInfoDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public EmployeeInfo GetEmployeeInfo(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_EmployeeInfo", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                EmployeeInfo employeeInfo = new EmployeeInfo
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    LastName = dataRow["LastName"].ToString(),
                    FirstName = dataRow["FirstName"].ToString(),
                    Tel = dataRow["Tel"].ToString(),
                    Mobile =dataRow["Mobile"].ToString(),
                    Email = dataRow["Email"].ToString(),
                    Abberviation = dataRow["Abberviation"].ToString(),
                    Status = Convert.ToInt32(dataRow["Status"]),
                    
                };
                return employeeInfo;
            }
            return null;
        }

        public List<EmployeeInfo> GetemployeeByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_EmployeeInfo", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<EmployeeInfo> employeeInfoList = new List<EmployeeInfo>();
            foreach (DataRow dataRow in dt.Rows)
            {
                EmployeeInfo employeeInfo = new EmployeeInfo
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    LastName = dataRow["LastName"].ToString(),
                    FirstName = dataRow["FirstName"].ToString(),
                    Tel = dataRow["Tel"].ToString(),
                    Mobile = dataRow["Mobile"].ToString(),
                    Email = dataRow["Email"].ToString(),
                    Abberviation = dataRow["Abberviation"].ToString(),
                    Status = Convert.ToInt32(dataRow["Status"]),
                };
                employeeInfoList.Add(employeeInfo);
            }
            return employeeInfoList;
        }

        public EmployeeInfo GetEmployeeInformationInfo(int id)
        {
            DataSet ds = _dataProvider.GetData(@"SELECT * FROM T_EmployeeInfo WHERE ID=" + id);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];

            EmployeeInfo employeeInfo = new EmployeeInfo
            {
                ID = Convert.ToInt64(dr["ID"]),
                LastName = dr["LastName"].ToString(),
                FirstName = dr["FirstName"].ToString(),
                Tel = dr["Tel"].ToString(),
                Mobile = dr["Mobile"].ToString(),
                Email = dr["Email"].ToString(),
                Abberviation = dr["Abbreviation"].ToString(),
                Status = Convert.ToInt32(dr["Status"]),
                Title = Convert.ToInt32(dr["Title"])
            };
            return employeeInfo;
        }
        public object Update(int employeeId, string firstName, string lastName, string tel, string mobile, string email, string abbreviation, int status, int title)
        {
            object oId = 0;
            try
            {
                string[] arrColumn = { "FirstName", "LastName", "Tel", "Mobile", "Email", "Abbreviation", "Status", "Title" };
                string[] arrValue = { "'" + firstName + "'", "'" + lastName + "'", "'" + tel + "'", "'" + mobile + "'", "'" + email + "'", "'" + abbreviation + "'", "" + status.ToString() + "", "" + title.ToString() + "" };
                oId = _dataProvider.ManipulateData(QueryCreater.UpdateQuery("T_EmployeeInfo", arrColumn, arrValue, employeeId));
            }
            catch (Exception ex)
            {
            }
            return oId;
        }
        public object Add(string firstName, string lastName, string tel, string mobile, string email, string abbreviation, int status, int title)
        {
            object employeeId = 0;
            try
            {
                string[] arrColumn = { "FirstName", "LastName", "Tel", "Mobile", "Email", "Abbreviation", "Status", "Title" };
                string[] arrValue = { "'" + firstName + "'", "'" + lastName + "'", "'" + tel + "'", "'" + mobile + "'", "'" + email + "'", "'" + abbreviation + "'", "" + status.ToString() + "", "" + title.ToString() + "" };

                employeeId = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_EmployeeInfo", arrColumn, arrValue));
            }
            catch (Exception ex)
            {              
            }
            return employeeId;
        }

        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_EmployeeInfo", new [] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }

    }
}
  