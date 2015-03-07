using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DiamlerTP.DAL
{
    public class OrderDetailsDataProvider
    {
        private readonly DataProvider _dataProvider;

        public OrderDetailsDataProvider()
        {
            _dataProvider = new DataProvider();
        }
        public int GetPriceSum(int id)
        {
            return _dataProvider.GetPriceSum(id);

        }
        public OrderDetails GetOrderDetails(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_OrderDetails", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                OrderDetails OrderDetail = new OrderDetails
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    OrderID = Convert.ToInt32(dataRow["OrderID"]),
                    VehicleType = dataRow["VehicleType"].ToString(),
                    DesignatedFinasNo = dataRow["DesignatedFinasNo"].ToString(),
                    NumberPlate = dataRow["NumberPlate"].ToString(),
                    ChassisNo = dataRow["ChassisNo"].ToString(),
                    Receipt = dataRow["Receipt"].ToString(),
                    Length = dataRow["Length"].ToString(),
                    Width = dataRow["Width"].ToString(),
                    Height = dataRow["Height"].ToString(),
                    Weight = dataRow["Weight"].ToString(),
                    Price = dataRow["Price"].ToString(),
                    TruckType = dataRow["TruckType"].ToString(),
                    TransportWay = Convert.ToInt32(dataRow["TransportWay"]),
                    ModelYear = dataRow["ModelYear"].ToString(),
                    Capacity = dataRow["Capacity"].ToString(),
                    TruckNumberPlate = dataRow["TruckNumberPlate"].ToString(),
                    Shipping = dataRow["Shipping"].ToString(),
                    Carnet = dataRow["Carnet"].ToString(),
                    
                    
                };
                return OrderDetail;
            }
            return null;
        }

        public List<OrderDetails> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_Client", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<OrderDetails> OrderDetailsList = new List<OrderDetails>();
            foreach (DataRow dataRow in dt.Rows)
            {
                OrderDetails orderdetails = new OrderDetails
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    OrderID = Convert.ToInt32(dataRow["OrderID"]),
                    VehicleType = dataRow["VehicleType"].ToString(),
                    DesignatedFinasNo = dataRow["DesignatedFinasNo"].ToString(),
                    NumberPlate = dataRow["NumberPlate"].ToString(),
                    ChassisNo = dataRow["ChassisNo"].ToString(),
                    Receipt = dataRow["Receipt"].ToString(),
                    Length = dataRow["Length"].ToString(),
                    Width = dataRow["Width"].ToString(),
                    Height = dataRow["Height"].ToString(),
                    Weight = dataRow["Weight"].ToString(),
                    Price = dataRow["Price"].ToString(),
                    TruckType = dataRow["TruckType"].ToString(),
                    TransportWay = Convert.ToInt32(dataRow["TransportWay"]),
                    ModelYear = dataRow["ModelYear"].ToString(),
                    Capacity = dataRow["Capacity"].ToString(),
                    TruckNumberPlate = dataRow["TruckNumberPlate"].ToString(),
                    Shipping = dataRow["Shipping"].ToString(),
                    Carnet = dataRow["Carnet"].ToString(),
                };
                OrderDetailsList.Add(orderdetails);
            }
            return OrderDetailsList;
        }

        public object Add(int orderId, string designatedFinasNo, string numberPlate, string chassisNo, string receipt, string length, string width, string heigth, string weight, string price, string truckType, int transportWay)
        {
            object orderDetailsId = 0;
            try
            {
                string[] arrColumn = { "OrderId", "DesignatedFinasNo", "NumberPlate", "ChassisNo", "Receipt", "Length", "Width", "Height", "Weight", "Price", "TruckType", "TransportWay" };
                string[] arrValue = { "" + orderId + "", "'" + designatedFinasNo + "'", "'" + numberPlate + "'", "'" + chassisNo + "'", "'" + receipt + "'", "'" + length + "'", "'" + width + "'", "'" + heigth + "'", "'" + weight + "'", "'" + price + "'", "'" + truckType + "'", "" + transportWay + "" };

                orderDetailsId = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_OrderDetails", arrColumn, arrValue));
            }
            catch (Exception ex)
            {
            }
            return orderDetailsId;
        }
        
        public DataTable GetOrderDetailsForGridView(long orderId)
        {
            return _dataProvider.GetOrderDetails(orderId);
        }
        
        
        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_OrderDetails", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }
    }
}