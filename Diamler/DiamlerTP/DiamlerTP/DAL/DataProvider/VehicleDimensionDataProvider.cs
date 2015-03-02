using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DiamlerTP.DAL
{
    public class VehicleDimensionDataProvider
    {
        private readonly DataProvider _dataProvider;

        public VehicleDimensionDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public VehicleDimension GetVehicleDimension(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_VehicleDimension", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                VehicleDimension VehicleDimension = new VehicleDimension
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    VehicleDescription = dataRow["VehicleDescription"].ToString(),
                    Model = dataRow["Model"].ToString(),
                    VLength = dataRow["VLength"].ToString(),
                    VWidth = dataRow["VWidth"].ToString(),
                    VHeight = dataRow["VHeight"].ToString(),
                    VWeight = dataRow["VWeight"].ToString(),
                    WheelBase = dataRow["WheelBase"].ToString(),
                    VehicleGroundSpace = dataRow["VehicleGroundSpace"].ToString(),
                    SlopeAngle = dataRow["SlopeAngle"].ToString(),
                    FoldedMirrorWidth = dataRow["FoldedMirrorWidth"].ToString(),
                    VPrice = dataRow["VPrice"].ToString(),
                    
                };
                return VehicleDimension;
            }
            return null;
        }

        public List<VehicleDimension> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_VehicleDimension", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<VehicleDimension> VehicleDimensionList = new List<VehicleDimension>();
            foreach (DataRow dataRow in dt.Rows)
            {
                VehicleDimension vehicledimension = new VehicleDimension
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    VehicleDescription = dataRow["VehicleDescription"].ToString(),
                    Model = dataRow["Model"].ToString(),
                    VLength = dataRow["VLength"].ToString(),
                    VWidth = dataRow["VWidth"].ToString(),
                    VHeight = dataRow["VHeight"].ToString(),
                    VWeight = dataRow["VWeight"].ToString(),
                    WheelBase = dataRow["WheelBase"].ToString(),
                    VehicleGroundSpace = dataRow["VehicleGroundSpace"].ToString(),
                    SlopeAngle = dataRow["SlopeAngle"].ToString(),
                    FoldedMirrorWidth = dataRow["FoldedMirrorWidth"].ToString(),
                    VPrice = dataRow["VPrice"].ToString(),
                };
                VehicleDimensionList.Add(vehicledimension);
            }
            return VehicleDimensionList;
        }

        public object Add(string description, string model, string length, string width, string height, string weight, string wheelBase, string groundSpace, string slopeAngle, string foldedMirrorWidth, string price)
        {
            object vehicleDimensionId = 0;
            try
            {
                string[] arrColumn = { "VehicleDescription", "Model", "VLength", "VWidth", "VHeight", "VWeight", "WheelBase", "VehicleGroundSpace", "SlopeAngle", "FoldedMirrorWidth", "VPrice" };
                string[] arrValue = { "'" + description + "'", "'" + model + "'", "'" + length + "'", "'" + width + "'", "'" + height + "'", "'" + weight + "'", "'" + wheelBase + "'", "'" + groundSpace + "'", "'" + slopeAngle + "'", "'" + foldedMirrorWidth + "'", "'" + price + "'" };

                vehicleDimensionId = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_VehicleDimension", arrColumn, arrValue));
            }
            catch (Exception ex)
            {
            }
            return vehicleDimensionId;
        }

        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_VehicleDimension", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }
    }
}