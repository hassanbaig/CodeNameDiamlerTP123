using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DiamlerTP.DAL.DataProviderTable
{
    public class AirStatisticsDataProvider
    {
        private readonly DataProvider _dataProvider;

        public AirStatisticsDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public AirStatistics GetAirStatisticsData(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_AirStatistics", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                AirStatistics AirStatistics = new AirStatistics
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Transport = dataRow["Transport"].ToString(),
                    PlantDepartment = dataRow["PlantDepartment"].ToString(),
                    Country = dataRow["Country"].ToString(),
                    MBSNo = dataRow["MBSNo"].ToString(),
                    FlightDate = Convert.ToDateTime(dataRow["FlightDate"]),
                    Flight = dataRow["Flight"].ToString(),
                    AWB = dataRow["AWB"].ToString(),
                    Shipper = dataRow["Shipper"].ToString(),
                    ExportKind = dataRow["ExportKind"].ToString(),
                    TIBCarnetNo = dataRow["TIBCarnetNo"].ToString(),
                    GoodsKind = dataRow["GoodsKind"].ToString(),
                    ChassisNo = dataRow["ChassisNo"].ToString(),
                    ShippmentFromSifi = Convert.ToDateTime(dataRow["ShippmentFromSifi"]),
                    Arrival = Convert.ToDateTime(dataRow["Arrival"]),
                    Destination = dataRow["Destination"].ToString(),
                    ReturnDate = dataRow["ReturnDate"].ToString(),
                    Client = Convert.ToInt32(dataRow["Client"]),
                    CustomClearence = dataRow["CustomClearence"].ToString(),
                    StorageFolderNo = dataRow["StorageFolderNo"].ToString(),
                    AdditionInfo = dataRow["AdditionInfo"].ToString(),
                    
                    
                };
                return AirStatistics;
            }
            return null;
        }

        public List<AirStatistics> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_AirStatistics", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<AirStatistics> AirStatisticsList = new List<AirStatistics>();
            foreach (DataRow dataRow in dt.Rows)
            {
                AirStatistics airstatistics = new AirStatistics
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Transport = dataRow["Transport"].ToString(),
                    PlantDepartment = dataRow["PlantDepartment"].ToString(),
                    Country = dataRow["Country"].ToString(),
                    MBSNo = dataRow["MBSNo"].ToString(),
                    FlightDate = Convert.ToDateTime(dataRow["FlightDate"]),
                    Flight = dataRow["Flight"].ToString(),
                    AWB = dataRow["AWB"].ToString(),
                    Shipper = dataRow["Shipper"].ToString(),
                    ExportKind = dataRow["ExportKind"].ToString(),
                    TIBCarnetNo = dataRow["TIBCarnetNo"].ToString(),
                    GoodsKind = dataRow["GoodsKind"].ToString(),
                    ChassisNo = dataRow["ChassisNo"].ToString(),
                    ShippmentFromSifi = Convert.ToDateTime(dataRow["ShippmentFromSifi"]),
                    Arrival = Convert.ToDateTime(dataRow["Arrival"]),
                    Destination = dataRow["Destination"].ToString(),
                    ReturnDate = dataRow["ReturnDate"].ToString(),
                    Client = Convert.ToInt32(dataRow["Client"]),
                    CustomClearence = dataRow["CustomClearence"].ToString(),
                    StorageFolderNo = dataRow["StorageFolderNo"].ToString(),
                    AdditionInfo = dataRow["AdditionInfo"].ToString(),
                    
                };
                AirStatisticsList.Add(airstatistics);
            }
            return AirStatisticsList;
        }

        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_AirStatistics", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }

    }
}