using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace DiamlerTP.DAL
{
    public class ShippmentVehicleDataProvider
    {
        private readonly DataProvider _dataProvider;

        public ShippmentVehicleDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public ShippmentVehicle GetShippmentVehicle(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_ShippmentVehicle", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                ShippmentVehicle ShippmentVehicle = new ShippmentVehicle
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Shippment = Convert.ToInt32(dataRow["Shippment"]),
                    NumberPlate = dataRow["NumberPlate"].ToString(),
                    
                };
                return ShippmentVehicle;
            }
            return null;
        }

        public List<ShippmentVehicle> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_ShippmentVehicle", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<ShippmentVehicle> ShippmentVehicleList = new List<ShippmentVehicle>();
            foreach (DataRow dataRow in dt.Rows)
            {
                ShippmentVehicle shippmentvehicle = new ShippmentVehicle
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Shippment = Convert.ToInt32(dataRow["Shippment"]),
                    NumberPlate = dataRow["NumberPlate"].ToString(),
                };
                ShippmentVehicleList.Add(shippmentvehicle);
            }
            return ShippmentVehicleList;
        }

        public ShippmentVehicle GetShipmentVehicleInfo(int id)
        {
            DataSet ds = _dataProvider.GetData(@"SELECT * FROM T_ShippmentVehicle WHERE ID=" + id);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];

            ShippmentVehicle shippmentVehicle = new ShippmentVehicle
            {
                ID = Convert.ToInt32(dr["ID"]),
                Shippment = Convert.ToInt32(dr["Shippment"]),
                NumberPlate = dr["NumberPlate"].ToString()
            };
            return shippmentVehicle;
        }
        public object Update(int shipmentVehicleId,int shipment, string numberPlate)
        {
            object oId = 0;
            try
            {
                string[] arrColumn = { "Shippment", "NumberPlate" };
                string[] arrValue = { "" + shipment + "", "'" + numberPlate + "'" };
                oId = _dataProvider.ManipulateData(QueryCreater.UpdateQuery("T_ShippmentVehicle", arrColumn, arrValue, shipmentVehicleId));
            }
            catch (Exception ex)
            {
            }
            return oId;
        }

        public object Add(int shipment, string numberPlate)
        {
            object shipmentVehicleId = 0;
            try
            {
                string[] arrColumn = { "Shippment", "NumberPlate"};
                string[] arrValue = { "" + shipment + "", "'" + numberPlate + "'" };

                shipmentVehicleId = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_ShippmentVehicle", arrColumn, arrValue));
            }
            catch (Exception ex)
            {
            }
            return shipmentVehicleId;
        }
        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_ShippmentVehicle", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }
    }
}