using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DiamlerTP.DAL
{
    public class CountryListDataProvider
    {
        private readonly DataProvider _dataProvider;

        public CountryListDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public CountryList GetCountryList(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_CountryList", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                CountryList CountryList = new CountryList
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Countries = dataRow["Countries"].ToString(),
                    ISOAlphaCode = dataRow["ISOAlphaCode"].ToString(),
                    
                };
                return CountryList;
            }
            return null;
        }

        public List<CountryList> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_CountryList", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<CountryList> CountryListList = new List<CountryList>();
            foreach (DataRow dataRow in dt.Rows)
            {
                CountryList countrylist = new CountryList
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Countries = dataRow["Countries"].ToString(),
                    ISOAlphaCode = dataRow["ISOAlphaCode"].ToString(),
                };
                CountryListList.Add(countrylist);
            }
            return CountryListList;
        }

        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_CountryList", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }

        public object Alpha { get; set; }
    }
}