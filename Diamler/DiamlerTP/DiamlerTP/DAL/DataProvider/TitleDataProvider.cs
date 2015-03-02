using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DiamlerTP.DAL
{
    public class TitleDataProvider
    {
        private readonly DataProvider _dataProvider;

        public TitleDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public List<Title> GetTitle()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_Title"));
            DataTable dt = ds.Tables[0];
            List<Title> titles = new List<Title>();
            foreach (DataRow dataRow in dt.Rows)
            {
                titles.Add(new Title
                {
                    ID = Convert.ToInt64(dataRow["Id"]),
                    Name = dataRow["Name"].ToString(),
                    Description = dataRow["Description"].ToString()
                });
            }
            return titles;
        }

        public List<Title> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_Title", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<Title> TitleList = new List<Title>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Title title = new Title
                {
                    ID = Convert.ToInt64(dataRow["Id"]),
                    Name = dataRow["Name"].ToString(),
                    Description = dataRow["Description"].ToString(),
                };
                TitleList.Add(title);
            }
            return TitleList;
        }

        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_Title", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }
    }

}