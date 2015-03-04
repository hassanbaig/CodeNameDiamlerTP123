using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DiamlerTP.DAL
{
    public class ClientDataProvider
    {
        private readonly DataProvider _dataProvider;

        public ClientDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public Client GetClient(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_Client", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                Client Client = new Client
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Title = Convert.ToInt32(dataRow["Title"]),
                    FName = dataRow["LastName"].ToString(),
                    LName = dataRow["FirstName"].ToString(),
                    Department = dataRow["Department"].ToString(),
                    Tel = dataRow["Tel"].ToString(),
                    IndustrialPlant = dataRow["IndustrialPlant"].ToString(),
                    
                    
                };
                return Client;
            }
            return null;
        }

        public List<Client> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_Client", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<Client> ClientList = new List<Client>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Client client= new Client
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Title = Convert.ToInt32(dataRow["Title"]),
                    FName = dataRow["LastName"].ToString(),
                    LName = dataRow["FirstName"].ToString(),
                    Department = dataRow["Department"].ToString(),
                    Tel = dataRow["Tel"].ToString(),
                    IndustrialPlant = dataRow["IndustrialPlant"].ToString(),
                };
                ClientList.Add(client);
            }
            return ClientList;
        }

        public Client GetClientInfo(int id)
        {
            DataSet ds = _dataProvider.GetData(@"SELECT * FROM T_Client WHERE ID=" + id);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];

            Client client = new Client
            {
                ID = Convert.ToInt32(dr["ID"]),
                Title = Convert.ToInt32(dr["Title"].ToString()),
                FName = dr["FName"].ToString(),
                LName = dr["LName"].ToString(),
                Department = dr["Department"].ToString(),
                Tel = dr["Tel"].ToString(),
                IndustrialPlant = dr["IndustrialPlant"].ToString()
            };
            return client;
        }

        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_Client", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }
    }
}