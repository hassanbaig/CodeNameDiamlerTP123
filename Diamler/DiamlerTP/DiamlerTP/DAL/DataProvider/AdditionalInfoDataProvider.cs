using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace DiamlerTP.DAL
{
    public class AdditionalInfoDataProvider
    {
        private readonly DataProvider _dataProvider;

        public AdditionalInfoDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public AdditionalInfo GetAdditionalInfo(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_AdditionalInformation", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                AdditionalInfo AdditionalInfo = new AdditionalInfo
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Shortname = dataRow["Shortname"].ToString(),
                    AdditionInfo = dataRow["AdditionInfo"].ToString(),
                    
                };
                return AdditionalInfo;
            }
            return null;
        }

        public AdditionalInfo GetAdditionalInformationInfo(int id)
        {
            DataSet ds = _dataProvider.GetData(@"SELECT * FROM T_AdditionalInformation WHERE ID=" + id);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];

            AdditionalInfo additionalInfo = new AdditionalInfo
            {
                ID = Convert.ToInt32(dr["ID"]),
                Shortname = dr["Shortname"].ToString(),
                AdditionInfo = dr["AdditionInfo"].ToString(),
                
            };
            return additionalInfo;
        }
        public object Update(int additionalInfoId, string shortName, string additionalInformation)
        {
            object oId = 0;
            try
            {
                string[] arrColumn = { "Shortname", "AdditionInfo" };
                string[] arrValue = { "'" + shortName + "'", "'" + additionalInformation + "'"};
                oId = _dataProvider.ManipulateData(QueryCreater.UpdateQuery("T_AdditionalInformation", arrColumn, arrValue, additionalInfoId));
            }
            catch (Exception ex)
            {
            }
            return oId;
        }
        public List<AdditionalInfo> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_AdditionalInformation", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<AdditionalInfo> AdditionalInfoList = new List<AdditionalInfo>();
            foreach (DataRow dataRow in dt.Rows)
            {
                AdditionalInfo additionalinfo = new AdditionalInfo
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Shortname = dataRow["Shortname"].ToString(),
                    AdditionInfo = dataRow["AdditionInfo"].ToString(),
                };
                AdditionalInfoList.Add(additionalinfo);
            }
            return AdditionalInfoList;
        }
        public object Add(string shortName, string additionalInfo)
        {
            object additionalInfoId = 0;
            try
            {
                string[] arrColumn = { "Shortname", "AdditionInfo"};
                string[] arrValue = { "'" + shortName + "'", "'" + additionalInfo + "'" };

                additionalInfoId = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_AdditionalInformation", arrColumn, arrValue));
            }
            catch (Exception ex)
            {
            }
            return additionalInfoId;
        }
        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_AdditionalInformation", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }
    }
}