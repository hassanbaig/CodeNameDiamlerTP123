using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DiamlerTP.DAL
{
    public class LoadAdressDataProvider
    {
        private readonly DataProvider _dataProvider;

        public LoadAdressDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public LoadAdress GetLoadAdress(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_LoadAdress", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                LoadAdress LoadAdress = new LoadAdress
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    SearchName = dataRow["SearchName"].ToString(),
                    Name1 = dataRow["Name1"].ToString(),
                    Name2 = dataRow["Name2"].ToString(),
                    Street1 = dataRow["Street1"].ToString(),
                    Street2 = dataRow["Street2"].ToString(),
                    PostCode = dataRow["PostCode"].ToString(),
                    City = dataRow["City"].ToString(),
                    Region = dataRow["Region"].ToString(),
                    Country = dataRow["Country"].ToString(),


                };
                return LoadAdress;
            }
            return null;
        }

        public List<LoadAdress> GetLAdress()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_LoadAdress"));
            DataTable dt = ds.Tables[0];
            List<LoadAdress> LAdress = new List<LoadAdress>();
            foreach (DataRow dataRow in dt.Rows)
            {
                LAdress.Add(new LoadAdress
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    SearchName = dataRow["SearchName"].ToString(),
                    Name1 = dataRow["Name1"].ToString(),
                    Name2 = dataRow["Name2"].ToString(),
                    Street1 = dataRow["Street1"].ToString(),
                    Street2 = dataRow["Street2"].ToString(),
                    PostCode = dataRow["PostCode"].ToString(),
                    City = dataRow["City"].ToString(),
                    Region = dataRow["Region"].ToString(),
                    Country = dataRow["Country"].ToString(),

                });

            }
            return LAdress;
        }
        public List<LoadAdress> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_LoadAdress", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<LoadAdress> LoadAdressList = new List<LoadAdress>();
            foreach (DataRow dataRow in dt.Rows)
            {
                LoadAdress loadadress = new LoadAdress
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    SearchName = dataRow["SearchName"].ToString(),
                    Name1 = dataRow["Name1"].ToString(),
                    Name2 = dataRow["Name2"].ToString(),
                    Street1 = dataRow["Street1"].ToString(),
                    Street2 = dataRow["Street2"].ToString(),
                    PostCode = dataRow["PostCode"].ToString(),
                    City = dataRow["City"].ToString(),
                    Region = dataRow["Region"].ToString(),
                    Country = dataRow["Country"].ToString(),
                };
                LoadAdressList.Add(loadadress);
            }
            return LoadAdressList;
        }
        public LoadAdress GetLoadAddressInfo(long id)
        {
            DataSet ds = _dataProvider.GetData(@"SELECT * FROM T_LoadAdress WHERE ID=" + id);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];

            LoadAdress loadAdress = new LoadAdress
            {
                ID = Convert.ToInt32(dr["ID"]),
                SearchName = dr["SearchName"].ToString(),
                Name1 = dr["Name1"].ToString(),
                Name2 = dr["Name2"].ToString(),
                Street1 = dr["Street1"].ToString(),
                Street2 = dr["Street2"].ToString(),
                PostCode = dr["PostCode"].ToString(),
                City = dr["City"].ToString(),
                Region = dr["Region"].ToString(),
                Country = dr["Country"].ToString(),
            };
            return loadAdress;
        }
        public object Update(int loadAddressId, string searchName, string name1, string name2, string street1, string street2, string postCode, string city, string region,string country)
        {
            object laId = 0;
            try
            {
                string[] arrColumn = { "SearchName", "Name1", "Name2", "Street1", "Street2", "PostCode", "City", "Region", "Country" };
                string[] arrValue = { "'" + searchName + "'", "'" + name1 + "'", "'" + name2 + "'", "'" + street1 + "'", "'" + street2 + "'", "'" + postCode + "'", "'" + city + "'", "'" + region + "'", "'" + country + "'" };
                laId = _dataProvider.ManipulateData(QueryCreater.UpdateQuery("T_LoadAdress", arrColumn, arrValue, loadAddressId));
            }
            catch (Exception ex)
            {
            }
            return laId;
        }

        public object Add(string searchName, string name1, string name2, string street1, string street2, string postCode, string city, string region, string country)
        {
            object loadAddressId = 0;
            try
            {
                string[] arrColumn = { "SearchName", "Name1", "Name2", "Street1", "Street2", "PostCode", "City", "Region", "Country" };
                string[] arrValue = { "'" + searchName + "'", "'" + name1 + "'", "'" + name2 + "'", "'" + street1 + "'", "'" + street2 + "'", "'" + postCode + "'", "'" + city + "'", "'" + region + "'", "'" + country + "'"};

                loadAddressId = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_LoadAdress", arrColumn, arrValue));
            }
            catch (Exception ex)
            {
            }
            return loadAddressId;
        }
            

        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_LoadAdress", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }
    }
}