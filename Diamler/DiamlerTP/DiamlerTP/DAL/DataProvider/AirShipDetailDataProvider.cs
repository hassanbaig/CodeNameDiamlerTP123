using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace DiamlerTP.DAL
{
    public class AirShipDetailDataProvider
    {
        private readonly DataProvider _dataProvider;

        public AirShipDetailDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public AirShipDetail GetAirShipDetailData(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_AirShipDetail", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                AirShipDetail AirShipDetail = new AirShipDetail
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
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
                    MBSPos = dataRow["MBSPos"].ToString(),


                };
                return AirShipDetail;
            }
            return null;
        }

        public List<AirShipDetail> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_AirShipDetail", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<AirShipDetail> AirShipDetailList = new List<AirShipDetail>();
            foreach (DataRow dataRow in dt.Rows)
            {
                AirShipDetail airshipdetail = new AirShipDetail
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
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
                    MBSPos = dataRow["MBSPos"].ToString(),
                };
                AirShipDetailList.Add(airshipdetail);
            }
            return AirShipDetailList;
        }
        public AirShipDetail GetAirShipDetailInfo(int id)
        {
            DataSet ds = _dataProvider.GetData(@"SELECT * FROM T_AirShipDetail WHERE MBSNo=" + id);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];

            AirShipDetail airShipDetail = new AirShipDetail
            {
                ID = Convert.ToInt64(dr["ID"]),
                MBSNo = dr["MBSNo"].ToString(),
                FlightDate = Convert.ToDateTime(dr["FlightDate"]),
                Flight = dr["Flight"].ToString(),
                AWB = dr["AWB"].ToString(),
                Shipper = dr["Shipper"].ToString(),
                ExportKind = dr["ExportKind"].ToString(),
                TIBCarnetNo = dr["TIBCarnetNo"].ToString(),
                GoodsKind = dr["GoodsKind"].ToString(),
                ChassisNo = dr["ChassisNo"].ToString(),
                ShippmentFromSifi = Convert.ToDateTime(dr["ShippmentFromSifi"]),
                Arrival = Convert.ToDateTime(dr["Arrival"]),
                Destination = dr["Destination"].ToString(),
                ReturnDate = dr["ReturnDate"].ToString(),
                Client = Convert.ToInt32(dr["Client"]),
                CustomClearence = dr["CustomClearence"].ToString(),
                MBSPos = dr["MBSPos"].ToString()
            };
            return airShipDetail;
        }
        public object Add(int orderId, DateTime date, int loadAddress)
        {
            object orderDetailId = 0;
            try
            {
                 string[] arrColumn = { "Date", "LoadAdress", "OrderId" };
                 string[] arrValue = { "'" + date + "'", "" + loadAddress + "", "" + orderId + "" };
                orderDetailId = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_OrderAdress", arrColumn, arrValue));
            }
            catch (Exception ex)
            {
            }
            return orderDetailId;
        }      
        public void Update(int orderId, string noOfVehicles)
        {            
            try
            {
                string[] arrColumn = { "VechicleNo" };
                string[] arrValue = { "'" + noOfVehicles + "'" };

                _dataProvider.ManipulateData(QueryCreater.UpdateQuery("T_Order", arrColumn, arrValue, orderId));
            }
            catch (Exception ex)
            {
            }
        }
        public void Update(int orderId, string mbsNo, DateTime flightDate, string flight, string awb, string shipper, string exportKind, string tibCarnetNo, string goodsKind, string chassisNo, DateTime shipmentFromSifi, DateTime returnDate, int client, string customClearance)
        {
            try
            {
                string[] arrColumn = { "MBSNo", "FlightDate", "Flight", "AWB", "Shipper", "ExportKind", "TIBCarnetNo", "GoodsKind", "ChassisNo", "ShippmentFromSifi", "ReturnDate", "Client", "CustomClearence" };
                string[] arrValue = { "'" + mbsNo + "'", "'" + flightDate + "'", "'" + flight + "'", "'" + awb + "'", "'" + shipper + "'", "'" + exportKind + "'", "'" + tibCarnetNo + "'", "'" + goodsKind + "'", "'" + chassisNo + "'", "'" + shipmentFromSifi + "'", "'" + returnDate.ToShortDateString() + "'", "" + client + "", "'" + customClearance + "'" };
                _dataProvider.ManipulateData(QueryCreater.UpdateQuery("T_AirShipDetail", arrColumn, arrValue, orderId));
            }
            catch (Exception ex)
            {
            }
        }
        public object Add(string mbsNo, DateTime flightDate, string flight, string awb, string shipper, string exportKind, string tibCarnetNo, string goodsKind, string chassisNo, DateTime shipmentFromSifi, DateTime returnDate, int client, string customClearance)
        {
            object airShipDetailId = 0;
            try
            {
                string[] arrColumn = { "MBSNo", "FlightDate", "Flight", "AWB", "Shipper","ExportKind","TIBCarnetNo","GoodsKind","ChassisNo","ShippmentFromSifi","ReturnDate","Client","CustomClearence" };
                string[] arrValue = { "'" + mbsNo + "'", "'" + flightDate + "'", "'" + flight + "'", "'" + awb + "'", "'" + shipper + "'", "'" + exportKind + "'", "'" + tibCarnetNo + "'", "'" + goodsKind + "'", "'" + chassisNo + "'", "'" + shipmentFromSifi + "'", "'" + returnDate.ToShortDateString() + "'", "" + client + "", "'" + customClearance + "'" };
                airShipDetailId = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_AirShipDetail", arrColumn, arrValue));
            }
            catch (Exception ex)
            {
            }
            return airShipDetailId;
        }
        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_AirShipDetail", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }
    }
}