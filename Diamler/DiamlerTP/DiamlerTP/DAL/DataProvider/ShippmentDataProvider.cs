using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DiamlerTP.DAL
{
    public class ShippmentDataProvider
    {
        private readonly DataProvider _dataProvider;

        public ShippmentDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public Shippment GetShippment(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_Shippment", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                Shippment Shippment = new Shippment
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
                    ContactPerson = Convert.ToInt32(dataRow["ContactPerson"]),
                    MainTel = dataRow["MainTel"].ToString(),
                    MainFax = dataRow["MainFax"].ToString(),
                    MainEmail = dataRow["MainEmail"].ToString(),
                    Location = dataRow["Location"].ToString(),
                    OpenTransport = dataRow["OpenTransport"].ToString(),
                    CloseTransport = dataRow["CloseTransport"].ToString(),
                    OperationalArea = dataRow["OperationalArea"].ToString(),
                    Remarks = dataRow["Remarks"].ToString(),
                    FlightNo = dataRow["FlightNo"].ToString(),
                    Function = dataRow["funktion"].ToString(),

                    
                };
                return Shippment;
            }
            return null;
        }
        public List<Shippment> GetShippmentdata()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_Shippment"));
            DataTable dt = ds.Tables[0];
            List<Shippment> shippments= new List<Shippment>();
            foreach (DataRow dataRow in dt.Rows)
            {
              shippments.Add(new Shippment
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
                    ContactPerson = Convert.ToInt32(dataRow["ContactPerson"]),
                    MainTel = dataRow["MainTel"].ToString(),
                    MainFax = dataRow["MainFax"].ToString(),
                    MainEmail = dataRow["MainEmail"].ToString(),
                    Location = dataRow["Location"].ToString(),
                    OpenTransport = dataRow["OpenTransport"].ToString(),
                    CloseTransport = dataRow["CloseTransport"].ToString(),
                    OperationalArea = dataRow["OperationalArea"].ToString(),
                    Remarks = dataRow["Remarks"].ToString(),
                    FlightNo = dataRow["FlightNo"].ToString(),
                    Function = dataRow["funktion"].ToString(),

                    
                });
            }
                return shippments;
            }
        public List<Shippment> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_Shippment", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<Shippment> ShippmentList = new List<Shippment>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Shippment shippment = new Shippment
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
                    ContactPerson = Convert.ToInt32(dataRow["ContactPerson"]),
                    MainTel = dataRow["MainTel"].ToString(),
                    MainFax = dataRow["MainFax"].ToString(),
                    MainEmail = dataRow["MainEmail"].ToString(),
                    Location = dataRow["Location"].ToString(),
                    OpenTransport = dataRow["OpenTransport"].ToString(),
                    CloseTransport = dataRow["CloseTransport"].ToString(),
                    OperationalArea = dataRow["OperationalArea"].ToString(),
                    Remarks = dataRow["Remarks"].ToString(),
                    FlightNo = dataRow["FlightNo"].ToString(),
                    Function = dataRow["funktion"].ToString(),
                };
                ShippmentList.Add(shippment);
            }
            return ShippmentList;
        }

        public Shippment GetShipmentInfo(int id)
        {
            DataSet ds = _dataProvider.GetData(@"SELECT * FROM T_Shippment WHERE ID=" + id);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];

            Shippment shippment = new Shippment
            {
                ID = Convert.ToInt64(dr["ID"]),
                SearchName = dr["SearchName"].ToString(),
                Name1 = dr["Name1"].ToString(),
                Name2 = dr["Name2"].ToString(),
                Street1 = dr["Street1"].ToString(),
                Street2 = dr["Street2"].ToString(),
                PostCode = dr["PostCode"].ToString(),
                City = dr["City"].ToString(),
                Region = dr["Region"].ToString(),
                Country = dr["Country"].ToString(),
                ContactPerson = Convert.ToInt32(dr["ContactPerson"]),
                MainTel = dr["MainTel"].ToString(),
                MainFax = dr["MainFax"].ToString(),
                MainEmail = dr["MainEmail"].ToString(),
                Location = dr["Location"].ToString(),
                OpenTransport = dr["OpenTransport"].ToString(),
                CloseTransport = dr["CloseTransport"].ToString(),
                OperationalArea = dr["OperationalArea"].ToString(),
                Remarks = dr["Remarks"].ToString(),
                FlightNo = dr["FlightNo"].ToString(),
                Function = dr["funktion"].ToString(),
            };
            return shippment;
        }
        public object Update(int shipmentId,string searchName, string name1, string name2, string street1, string street2, string postCode, string city, string region, string country, int contactPerson, string mainTel, string mainFax, string mainEmail, string location, string openTransport, string closeTransport, string operationalArea, string remarks, string flightNo, string function)
        {
            object sId = 0;
            try
            {
                string[] arrColumn = { "SearchName", "Name1", "Name2", "Street1", "Street2", "PostCode", "City", "Region", "Country", "ContactPerson", "MainTel", "MainFax", "MainEmail", "Location", "OpenTransport", "CloseTransport", "OperationalArea", "Remarks", "FlightNo", "funktion" };
                string[] arrValue = { "'" + searchName + "'", "'" + name1 + "'", "'" + name2 + "'", "'" + street1 + "'", "'" + street2 + "'", "'" + postCode + "'", "'" + city + "'", "'" + region + "'", "'" + country + "'", "" + contactPerson + "", "'" + mainTel + "'", "'" + mainFax + "'", "'" + mainEmail + "'", "'" + location + "'", "'" + openTransport + "'", "'" + closeTransport + "'", "'" + operationalArea + "'", "'" + remarks + "'", "'" + flightNo + "'", "'" + function + "'" };
                sId = _dataProvider.ManipulateData(QueryCreater.UpdateQuery("T_Shippment", arrColumn, arrValue, shipmentId));
            }
            catch (Exception ex)
            {
            }
            return sId;
        }
        public object Add(string searchName, string name1, string name2, string street1, string street2, string postCode, string city, string region, string country, int contactPerson, string mainTel, string mainFax, string mainEmail, string location, string openTransport, string closeTransport, string operationalArea, string remarks, string flightNo, string function)
        {
            object shipmentId = 0;
            try
            {
                string[] arrColumn = { "SearchName", "Name1", "Name2", "Street1", "Street2", "PostCode", "City", "Region", "Country", "ContactPerson", "MainTel", "MainFax", "MainEmail", "Location", "OpenTransport", "CloseTransport", "OperationalArea", "Remarks", "FlightNo", "funktion" };
                string[] arrValue = { "'" + searchName + "'", "'" + name1 + "'", "'" + name2 + "'", "'" + street1 + "'", "'" + street2 + "'", "'" + postCode + "'", "'" + city + "'", "'" + region + "'", "'" + country + "'", "" + contactPerson + "", "'" + mainTel + "'", "'" + mainFax + "'", "'" + mainEmail + "'", "'" + location + "'", "'" + openTransport + "'", "'" + closeTransport + "'", "'" + operationalArea + "'", "'" + remarks + "'", "'" + flightNo + "'", "'" + function + "'" };

                shipmentId = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_Shippment", arrColumn, arrValue));
            }
            catch (Exception ex)
            {
            }
            return shipmentId;
        }
        
        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_Shippment", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }
    }
}