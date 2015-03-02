using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DiamlerTP.DAL;


namespace DiamlerTP.DAL
{
    public class LoginDataProvider
    {
        private DataProvider _dataProvider;

        public LoginDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public List<Login> GetLoginData()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_Login"));
            DataTable dt = ds.Tables[0];
            List<Login> logins = new List<Login>();
            foreach (DataRow dataRow in dt.Rows)
            {
                logins.Add(new Login
                {
                    Id = Convert.ToInt64(dataRow["Id"]),
                    Email = dataRow["Email"].ToString(),
                    Password = dataRow["Password"].ToString()
                });
            }
            return logins;
        }
        public List<Login> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_Login", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<Login> LoginList = new List<Login>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Login Login = new Login
                {
                    Id = Convert.ToInt64(dataRow["Id"]),
                    Email = dataRow["Email"].ToString(),
                    Password = dataRow["Password"].ToString(),
                };
                LoginList.Add(Login);
            }
            return LoginList;
        }

        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_Login", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }
    }
}