using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DiamlerTP.DAL
{
    public class ShippmentContactPersonDataProvider
    {
        private readonly DataProvider _dataProvider;

        public ShippmentContactPersonDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public ShippmentContactPerson GetShippmentContactPerson(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_ShippmentContactPerson", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                ShippmentContactPerson ShippmentContactPerson = new ShippmentContactPerson
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Shippment = Convert.ToInt32(dataRow["Shippment"]),
                    Title = Convert.ToInt32(dataRow["Title"]),
                    LastNameSp = dataRow["LastNameSp"].ToString(),
                    FirstNameSp = dataRow["FirstNameSp"].ToString(),
                    Mobile = dataRow["Mobile"].ToString(),
                    Email = dataRow["Email"].ToString(),
                    Function = dataRow["funktion"].ToString(),
                    
                    
                };
                return ShippmentContactPerson;
            }
            return null;
        }

        public List<ShippmentContactPerson> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_ShippmentContactPerson", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<ShippmentContactPerson> ShippmentContactPersonList = new List<ShippmentContactPerson>();
            foreach (DataRow dataRow in dt.Rows)
            {
                ShippmentContactPerson shippmentcontactperson = new ShippmentContactPerson
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Shippment = Convert.ToInt32(dataRow["Shippment"]),
                    Title = Convert.ToInt32(dataRow["Title"]),
                    LastNameSp = dataRow["LastNameSp"].ToString(),
                    FirstNameSp = dataRow["FirstNameSp"].ToString(),
                    Mobile = dataRow["Mobile"].ToString(),
                    Email = dataRow["Email"].ToString(),
                    Function = dataRow["funktion"].ToString(),
                };
                ShippmentContactPersonList.Add(shippmentcontactperson);
            }
            return ShippmentContactPersonList;
        }
        public ShippmentContactPerson GetShipmentContactPersonInfo(int id)
        {
            DataSet ds = _dataProvider.GetData(@"SELECT * FROM T_ShippmentContactPerson WHERE ID=" + id);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];

            ShippmentContactPerson shippmentContactPerson = new ShippmentContactPerson
            {
                ID = Convert.ToInt32(dr["ID"]),
                Shippment = Convert.ToInt32(dr["Shippment"]),
                Title = Convert.ToInt32(dr["Title"].ToString()),
                LastNameSp = dr["LastNameSp"].ToString(),
                FirstNameSp = dr["FirstNameSp"].ToString(),
                Mobile = dr["Mobile"].ToString(),
                Email = dr["Email"].ToString(),
                Function= dr["funktion"].ToString(),                
            };
            return shippmentContactPerson;
        }
        public object Update(int shipmentContactPerson,int shipmentId, int title, string firstName, string lastName, string mobile, string email, string function)
        {
            object laId = 0;
            try
            {
                string[] arrColumn = { "Shippment", "Title", "FirstNameSp", "LastNameSp", "Mobile", "Email", "funktion" };
                string[] arrValue = { "" + shipmentId + "", "" + title + "", "'" + firstName + "'", "'" + lastName + "'", "'" + mobile + "'", "'" + email + "'", "'" + function + "'" };
                laId = _dataProvider.ManipulateData(QueryCreater.UpdateQuery("T_ShippmentContactPerson", arrColumn, arrValue, shipmentContactPerson));
            }
            catch (Exception ex)
            {
            }
            return laId;
        }
        public object Add(int shipmentId, int title, string firstName, string lastName, string mobile, string email, string function)
        {
            object affectedRows = 0;
            try
            {
                string[] arrColumn = { "Shippment", "Title", "FirstNameSp", "LastNameSp", "Mobile", "Email", "funktion"};
                string[] arrValue = { "" + shipmentId + "", "" + title + "", "'" + firstName + "'", "'" + lastName + "'", "'" + mobile + "'", "'" + email + "'", "'" + function + "'"};

                affectedRows = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_ShippmentContactPerson", arrColumn, arrValue));
            }
            catch (Exception ex)
            {
            }
            return affectedRows;
        }

        public int GetShipmentId(int shipmentId, int title, string firstName, string lastName, string mobile, string email, string function)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable(); ;
            int shipmentContactPersonId = 0;
            try
            {
                string query = "SELECT DISTINCT * FROM [T_ShippmentContactPerson] WHERE [Shippment] = '" + shipmentId +
                                "' AND [Title] = '" + title +
                                "' AND [FirstNameSp] = '" + firstName +
                                "' AND [LastNameSp] = '" + lastName +
                                "' AND [Mobile] = '" + mobile +
                                "' AND [Email] = '" + email +
                                "' AND [funktion] = '" + function +                                
                                " ORDER BY [ID] ASC";
                ds = _dataProvider.GetData(query);
                dt = ds.Tables[0];
                foreach (DataRow dataRow in dt.Rows)
                { shipmentContactPersonId = Convert.ToInt32(dataRow["ID"]); }
            }
            catch (Exception ex)
            {
            }
            return shipmentContactPersonId;
        }

        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_ShippmentContactPerson", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }
    }
}