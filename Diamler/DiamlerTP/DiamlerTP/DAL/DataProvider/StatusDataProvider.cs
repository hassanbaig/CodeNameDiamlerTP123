using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DiamlerTP.DAL
{
    public class StatusDataProvider
    {
        private DataProvider _dataProvider;

        public StatusDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public List<Status> GetStatusData()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_Status"));
            DataTable dt = ds.Tables[0];
            List<Status> Statuss = new List<Status>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Status Status = new Status();
                Status.ID = Convert.ToInt32(dataRow["ID"]);
                Status.Name = dataRow["Name"].ToString();
                Statuss.Add(Status);
            }
            return Statuss;

        }
        public List<Status> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_Title", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<Status> StatusList = new List<Status>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Status status = new Status
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Name = dataRow["Name"].ToString(),
                };
                StatusList.Add(status);
            }
            return StatusList;
        }

        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_Status", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }

    }

}