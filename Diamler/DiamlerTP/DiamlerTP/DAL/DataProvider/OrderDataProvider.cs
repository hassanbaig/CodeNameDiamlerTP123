using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.WebSockets;

namespace DiamlerTP.DAL
{
    public class OrderDataProvider
    {
        private readonly DataProvider _dataProvider;

        public OrderDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public Order GetOrder(int id)
        {
            DataSet ds = _dataProvider.GetData(@"SELECT *, 
                                                (SELECT FirstName + ' ' + LastName FROM T_EmployeeInfo WHERE ID=EmployeeInfo) AS EmployeeInfoName,
                                                (SELECT Name FROM T_ShippingMethod WHERE Id = ShippingMethod) AS ShippingMethodName,
                                                (SELECT FName  + ' ' +  LName FROM T_Client WHERE Id = Client) AS ClientName,
                                                (SELECT FirstNameSp  + ' ' +  LastNameSp FROM T_ShippmentContactPerson WHERE Id = ShippmentContactPerson ) AS ShipmentContactPersonName,
                                                (SELECT Name FROM T_Status WHERE ID = Status) AS StatusName,
                                                (SELECT Name1 + ' ' + Name2 FROM T_Shippment WHERE ID = Shippment) AS ShippmentName,
                                                (SELECT Shortname FROM T_AdditionalInformation WHERE ID = AdditionalInformation) AS AdditionalInformationName
                                                FROM T_Order WHERE Id=" + id);
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                Order order = new Order
                {
                    Id = Convert.ToInt64(dataRow["ID"]),
                    //EntryDate = DateTime.ParseExact(dataRow["EntryDate"].ToString(), "M/d/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    EmployeeInfo = Convert.ToInt32(dataRow["EmployeeInfo"]),
                    EmployeeInfoName = dataRow["EmployeeInfoName"].ToString(),
                    ShippingMethodName = dataRow["ShippingMethodName"].ToString(),
                    ShippingMethod = Convert.ToInt32(dataRow["ShippingMethod"]),
                    MainReceipt = dataRow["MainReceipt"].ToString(),
                    AdditionalInformatio = dataRow["AdditionalInformation"].ToString(),
                    AdditionalInformationName = dataRow["AdditionalInformationName"].ToString(),
                    Status = Convert.ToInt32(dataRow["Status"]),
                    StatusName = dataRow["StatusName"].ToString(),
                    Client = Convert.ToInt32(dataRow["Client"]),
                    ClientName = dataRow["ClientName"].ToString(),
                    SpecialInstruction = dataRow["SpecialInstruction"].ToString(),
                    Shippment = (!string.IsNullOrEmpty(dataRow["Shippment"].ToString()) ? Convert.ToInt32(dataRow["Shippment"]) : 0),
                    DestinationPrice = dataRow["DestinationPrice"].ToString(),
                    ReturnPrice = dataRow["ReturnPrice"].ToString(),
                    ShippmentContactPerson = Convert.ToInt32((!string.IsNullOrEmpty(dataRow["ShippmentContactPerson"].ToString())) ? dataRow["ShippmentContactPerson"].ToString() : "0"),
                    ShipmentContactPersonName = dataRow["ShipmentContactPersonName"].ToString(),
                    VechicleNo = dataRow["VechicleNo"].ToString(),
                    InternalInfo = dataRow["InternalInfo"].ToString(),
                    Insurance = dataRow["Insurance"].ToString(),
                    Carnet = dataRow["Carnet"].ToString(),
                    ReceiptInfo = dataRow["ReceiptInfo"].ToString(),
                    //Tender = DateTime.ParseExact(dataRow["Tender"].ToString(), "M/d/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                };
                return order;
            }
            return null;
        }

        public Order GetOrderInfo(int id)
        {
            DataSet ds = _dataProvider.GetData(@"SELECT * FROM T_Order WHERE ID=" + id);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            
                Order order = new Order
                {
                    Id = Convert.ToInt64(dr["ID"]),
                    EntryDate = DateTime.Parse(dr["EntryDate"].ToString()),
                    EmployeeInfo = Convert.ToInt32(dr["EmployeeInfo"]),                                        
                    ShippingMethod = Convert.ToInt32(dr["ShippingMethod"]),
                    MainReceipt = dr["MainReceipt"].ToString(),
                    AdditionalInformatio = dr["AdditionalInformation"].ToString(),                                        
                    Client = Convert.ToInt32(dr["Client"]),                    
                    SpecialInstruction = dr["SpecialInstruction"].ToString(),
                    DestinationPrice = dr["DestinationPrice"].ToString(),
                    ReturnPrice = dr["ReturnPrice"].ToString(),
                    VechicleNo = dr["VechicleNo"].ToString(),
                    InternalInfo = dr["InternalInfo"].ToString(),
                    ReceiptInfo = dr["ReceiptInfo"].ToString(),
                    Tender = DateTime.Parse(dr["Tender"].ToString())
                };
                return order;
        }

        public List<Order> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_Order", pageNo, pageSize);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<Order> orderList = new List<Order>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Order order = new Order
                {
                    Id = Convert.ToInt64(dataRow["ID"]),
                    EntryDate = DateTime.ParseExact(dataRow["EntryDate"].ToString(), "M/d/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    EmployeeInfo = Convert.ToInt32(dataRow["EmployeeInfo"]),
                    ShippingMethod = Convert.ToInt32(dataRow["ShippingMethod"]),
                    MainReceipt = dataRow["MainReceipt"].ToString(),
                    AdditionalInformatio = dataRow["AdditionalInformation"].ToString(),
                    Status = Convert.ToInt32(dataRow["Status"]),
                    Client = Convert.ToInt32(dataRow["Client"]),
                    SpecialInstruction = dataRow["SpecialInstruction"].ToString(),
                    Shippment = (!string.IsNullOrEmpty(dataRow["Shippment"].ToString()) ? Convert.ToInt32(dataRow["Shippment"]) : 0),
                    DestinationPrice = dataRow["DestinationPrice"].ToString(),
                    ReturnPrice = dataRow["ReturnPrice"].ToString(),
                    ShippmentContactPerson = Convert.ToInt32((!string.IsNullOrEmpty(dataRow["ShippmentContactPerson"].ToString())) ? dataRow["ShippmentContactPerson"].ToString() : "0" ),
                    VechicleNo = dataRow["VechicleNo"].ToString(),
                    InternalInfo = dataRow["InternalInfo"].ToString(),
                    Insurance = dataRow["Insurance"].ToString(),
                    Carnet = dataRow["Carnet"].ToString(),
                    ReceiptInfo = dataRow["ReceiptInfo"].ToString(),
                    Tender = DateTime.ParseExact(dataRow["Tender"].ToString(), "M/d/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                };
                orderList.Add(order);
            }
            return orderList;
        }

        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_Order", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }
        public object Add(DateTime entryDate, int employeeInfo, int shippingMethod, string noOfVehicles, int client, string mainRefrence, string receiptInfo, DateTime deadline, int additionalInfo, string internalInfo, string specialInstruction)
        {
            object orderId = 0;
            try
            {
                string[] arrColumn = { "EntryDate", "EmployeeInfo", "ShippingMethod", "VechicleNo", "Client", "MainReceipt", "ReceiptInfo", "Tender", "AdditionalInformation", "InternalInfo", "SpecialInstruction" };
                string[] arrValue = { "'" + entryDate + "'", "" + employeeInfo + "", "" + shippingMethod + "", "'" + noOfVehicles + "'", "" + client + "", "'" + mainRefrence + "'", "'" + receiptInfo + "'", "'" + deadline + "'", "" + additionalInfo + "", "'" + internalInfo + "'", "'" + specialInstruction + "'" };

                orderId = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_Order", arrColumn, arrValue));
            }
            catch (Exception ex)
            {
            }
            return orderId;
        }
        public object Add(DateTime entryDate, int employeeInfo, int shippingMethod, string noOfVehicles, int client, string mainRefrence, int shipment, string internalInfo, string specialInstruction)
        {
            object orderId = 0;
            try
            {
                string[] arrColumn = { "EntryDate", "EmployeeInfo", "ShippingMethod", "VechicleNo", "Client", "MainReceipt", "Shippment", "InternalInfo", "SpecialInstruction" };
                string[] arrValue = { "'" + entryDate + "'", "" + employeeInfo + "", "" + shippingMethod + "", "'" + noOfVehicles + "'", "" + client + "", "'" + mainRefrence + "'",  "" + shipment + "", "'" + internalInfo + "'", "'" + specialInstruction + "'" };

                orderId = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_Order", arrColumn, arrValue));
            }
            catch (Exception ex)
            {
            }
            return orderId;
        }
        public object Update(int orderId, DateTime entryDate, int employeeInfo, int shippingMethod, string noOfVehicles, int client, string mainRefrence, string receiptInfo, string internalInfo, string specialInstruction)
        {
            object oId = 0; 
            try
            {
                string[] arrColumn = { "EntryDate", "EmployeeInfo", "ShippingMethod", "VechicleNo", "Client", "MainReceipt","ReceiptInfo", "InternalInfo", "SpecialInstruction" };
                string[] arrValue = { "'" + entryDate + "'", "" + employeeInfo + "", "" + shippingMethod + "", "'" + noOfVehicles + "'", "" + client + "", "'" + mainRefrence + "'", "'" + receiptInfo + "'", "'" + internalInfo + "'", "'" + specialInstruction + "'" };

               oId = _dataProvider.ManipulateData(QueryCreater.UpdateQuery("T_Order", arrColumn, arrValue, orderId));
            }
            catch (Exception ex)
            {
            }
            return oId;
        }
        public object Update(int orderId, int shipment, int shipmentContactPerson, string destinationPrice, string returnPrice)
        {
            object oId = 0;
            try
            {
                string[] arrColumn = { "Shippment", "ShippmentContactPerson","DestinationPrice","ReturnPrice" };
                string[] arrValue = { "" + shipment + "", "" + shipmentContactPerson + "", "'" + destinationPrice + "'", "'" + returnPrice + "'" };

               oId = _dataProvider.ManipulateData(QueryCreater.UpdateQuery("T_Order", arrColumn, arrValue, orderId));
            }
            catch (Exception ex)
            {
            }
            return oId;
        }
        public int InsertOrder(Order order)
        {
            string[] arrColumn =
            {
                "EntryDate",                 
                "EmployeeInfo",
                "ShippingMethod", 
                "MainReceipt", 
                "AdditionalInformation",
                "Status",
                "Client", 
                "SpecialInstruction",
                "VechicleNo", 
                "InternalInfo",
                "ReceiptInfo",
                "Tender"
            };
            string[] arrValue =
            {
                "'" + DateTime.Now.ToString("M/d/yyyy") + "'",
                "" + order.EmployeeInfo + "",
                "" + order.ShippingMethod + "", 
                "'" + order.MainReceipt + "'", 
                "'" + order.AdditionalInformatio + "'",
                "" + order.Status + "",
                "" + order.Client + "", 
                "'" + order.SpecialInstruction + "'", 
                "'" + order.VechicleNo + "'", 
                "'" + order.InternalInfo + "'",
                "'" + order.ReceiptInfo + "'", 
                "'" + order.Tender.ToString("M/d/yyyy") + "'"
            };

            return Convert.ToInt32(_dataProvider.ManipulateData(QueryCreater.InsertQuery("T_Order", arrColumn, arrValue)));
        }

    }
}