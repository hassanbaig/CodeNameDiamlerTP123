using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace DiamlerTP.DAL
{
    public class TransportWayDataProvider
    {
         private readonly DataProvider _dataProvider;

         public TransportWayDataProvider()
        {
            _dataProvider = new DataProvider();
        }

         public TransportWay GetTransportWay(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_TransportWay", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                TransportWay TransportWay = new TransportWay
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Name = dataRow["TransportWay"].ToString(),
                    TransportWayAbbreviation = dataRow["TransportWayAbbreviation"].ToString(),
                    
                };
                return TransportWay;
            }
            return null;
        }

         public List<TransportWay> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_TransportWay", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<TransportWay> TransportWayList = new List<TransportWay>();
            foreach (DataRow dataRow in dt.Rows)
            {
                TransportWay transportway = new TransportWay
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Name = dataRow["TransportWay"].ToString(),
                    TransportWayAbbreviation = dataRow["TransportWayAbbreviation"].ToString(),
                };
                TransportWayList.Add(transportway);
            }
            return TransportWayList;
        }

        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_TransportWay", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }
    }
}