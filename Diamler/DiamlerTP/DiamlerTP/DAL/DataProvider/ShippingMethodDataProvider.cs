using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DiamlerTP.DAL
{
    public class ShippingMethodDataProvider
    {
        private DataProvider _dataProvider;

        public ShippingMethodDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public List<ShippingMethod> GetShippingMethod()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_ShippingMethod"));
            DataTable dt = ds.Tables[0];
            List<ShippingMethod> shippingMethods = new List<ShippingMethod>();
            foreach (DataRow dataRow in dt.Rows)
            {
                ShippingMethod shippingMethod = new ShippingMethod();
                shippingMethod.Id = Convert.ToInt32(dataRow["Id"]);
                shippingMethod.Name = dataRow["Name"].ToString();
                shippingMethods.Add(shippingMethod);
            }
            return shippingMethods;
        }


        public List<Client> GetClientData()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_Client"));
            DataTable dt = ds.Tables[0];
            List<Client> Clients = new List<Client>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Client Client = new Client();
                Client.ID = Convert.ToInt32(dataRow["Id"]);
                Client.FName = dataRow["FName"].ToString();
                Clients.Add(Client);
            }
            return Clients;
        }


        public List<AdditionalInfo> GetAdditionalInfoData()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_AdditionalInformation"));
            DataTable dt = ds.Tables[0];
            List<AdditionalInfo> AdditionalInfos = new List<AdditionalInfo>();
            foreach (DataRow dataRow in dt.Rows)
            {
                AdditionalInfo additionalinfo = new AdditionalInfo();
                additionalinfo.ID = Convert.ToInt32(dataRow["Id"]);
                additionalinfo.Shortname = dataRow["Shortname"].ToString();
                AdditionalInfos.Add(additionalinfo);
            }
            return AdditionalInfos;
        }

        public List<EmployeeInfo> GetemployeeInfoData()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_EmployeeInfo"));
            DataTable dt = ds.Tables[0];
            List<EmployeeInfo> EmployeeInfos = new List<EmployeeInfo>();
            foreach (DataRow dataRow in dt.Rows)
            {
                EmployeeInfo employeeInfotMethod = new EmployeeInfo();
                employeeInfotMethod.ID = Convert.ToInt32(dataRow["ID"]);
                employeeInfotMethod.LastName = dataRow["LastName"].ToString();
                EmployeeInfos.Add(employeeInfotMethod);
            }
            return EmployeeInfos;
        }
             internal object GetEmployeeInfo()
        {
            throw new NotImplementedException();
        }
    }
}