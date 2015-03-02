using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace DiamlerTP.DAL
{
    public class ShippmentStatisticsDataProvider
    {
         private readonly DataProvider _dataProvider;

         public ShippmentStatisticsDataProvider()
        {
            _dataProvider = new DataProvider();
        }

         public ShippmentStatistics GetShippmentStatistics(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_ShippmentStatistics", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                ShippmentStatistics ShippmentStatistics = new ShippmentStatistics
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Year = dataRow["Year"].ToString(),
                    Month = dataRow["Month"].ToString(),
                    Day = dataRow["Day"].ToString(),
                    SumFromID_Order = dataRow["SumFromID_Order"].ToString(),
                    PriceSum = dataRow["PriceSum"].ToString(),
                    Receipt = dataRow["Receipt"].ToString(),
                    TotalVehicleNo = dataRow["TotalVehicleNo"].ToString(),
                    ShippingMethod = Convert.ToInt32(dataRow["ShippingMethod"]),
                    Vehicle = dataRow["Vehicle"].ToString(),
                    
                    
                };
                return ShippmentStatistics;
            }
            return null;
        }

         public List<ShippmentStatistics> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_ShippmentStatistics", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<ShippmentStatistics> ShippmentStatisticsList = new List<ShippmentStatistics>();
            foreach (DataRow dataRow in dt.Rows)
            {
                ShippmentStatistics shippmentstatistics = new ShippmentStatistics
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Year = dataRow["Year"].ToString(),
                    Month = dataRow["Month"].ToString(),
                    Day = dataRow["Day"].ToString(),
                    SumFromID_Order = dataRow["SumFromID_Order"].ToString(),
                    PriceSum = dataRow["PriceSum"].ToString(),
                    Receipt = dataRow["Receipt"].ToString(),
                    TotalVehicleNo = dataRow["TotalVehicleNo"].ToString(),
                    ShippingMethod = Convert.ToInt32(dataRow["ShippingMethod"]),
                    Vehicle = dataRow["Vehicle"].ToString(),
                };
                ShippmentStatisticsList.Add(shippmentstatistics);
            }
            return ShippmentStatisticsList;
        }

        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_ShippmentStatistics", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }
    }
}