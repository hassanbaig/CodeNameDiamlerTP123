using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using DiamlerTP.DAL.Model;

namespace DiamlerTP.DAL
{
    public class OrderAdressDataProvider
    {
        private readonly DataProvider _dataProvider;

        public OrderAdressDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public List<OrderAdress> GetOrderAdress(long orderId)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_OrderAdress", new[]
            {
                "*", 
                "(SELECT FirstName + ' ' + LastName + ' ' + (SELECT IndustrialPlant FROM T_Client WHERE Id=Company) + ' ' + Department FROM T_ContactPerson WHERE Id= T_OrderAdress.ContactPerson) as ContactPerson1Name",
                "(SELECT FirstName + ' ' + LastName + ' ' + (SELECT IndustrialPlant FROM T_Client WHERE Id=Company) + ' ' + Department FROM T_ContactPerson WHERE Id= T_OrderAdress.ContactPerson2) as  ContactPerson2Name",
                "(SELECT Name1 + ' ' + Name2 + ', ' + Street1 + ' ' + Street2 + ', ' + City + ', ' + Country FROM T_LoadAdress WHERE Id= T_OrderAdress.LoadAdress) as  Address"
            }, "OrderId =" + orderId));
            DataTable dt = ds.Tables[0];
            return (from DataRow dataRow in dt.Rows
                select new OrderAdress
                {
                    Id = Convert.ToInt32(dataRow["ID"]), 
                    LoadAdress = Convert.ToInt32(dataRow["LoadAdress"]), 
                    Address = dataRow["Address"].ToString(),
                    ContactPerson1 = Convert.ToInt32(dataRow["ContactPerson"]), 
                    ContactPerson2 = Convert.ToInt32(dataRow["ContactPerson2"]), 
                    ContactPerson1Name = dataRow["ContactPerson1Name"].ToString(),
                    ContactPerson2Name = dataRow["ContactPerson2Name"].ToString(),
                    DateTime = DateTime.ParseExact(dataRow["Date"].ToString(), "M/d/yyyy HH:mm:ss", CultureInfo.InvariantCulture), 
                    Type = dataRow["Type"].ToString(), 
                    IsLoad = Convert.ToBoolean(dataRow["IsLoad"].ToString())
                }).ToList();
        }
       
        public object Add(int orderId, long loadAddress, long contactPerson1, long contactPerson2, DateTime date, string type, int isLoad)
        {
            object orderAddressId = 0;
            try
            {
                string[] arrColumn = { "LoadAdress", "ContactPerson", "ContactPerson2", "Date", "Type", "Isload", "OrderId" };
                string[] arrValue = { "" + loadAddress + "", "" + contactPerson1 + "", "" + contactPerson2 + "", "'" + date + "'", "'" + type + "'", "" + isLoad + "", "" + orderId + "" };

                orderAddressId = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_OrderAdress", arrColumn, arrValue));
            }
            catch (Exception ex)
            {
            }
            return orderAddressId;
        }

        public object Add(int orderId, long loadAddress, DateTime date)
        {
            object oId = 0;
            try
            {
                string[] arrColumn = { "OrderId", "LoadAdress", "Date" };
                string[] arrValue = { "" + orderId + "", "" + loadAddress + "", "'" + date + "'" };

                oId = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_OrderAdress", arrColumn, arrValue));
            }
            catch (Exception ex)
            {
            }
            return oId;
        }
    }
}