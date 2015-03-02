using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DiamlerTP.DAL
{
    public class ContactPersonDataProvider
    {
        private readonly DataProvider _dataProvider;

        public ContactPersonDataProvider()
        {
            _dataProvider = new DataProvider();
        }

        public ContactPerson GetContactPerson(int id)
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_ContactPerson", null, "Id=" + id));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                ContactPerson ContactPerson = new ContactPerson
                {
                    ID = Convert.ToInt32(dataRow["ID"]),
                    Company = Convert.ToInt32(dataRow["Company"]),
                    Title = Convert.ToInt32(dataRow["Title"]),
                    LastName = dataRow["LastName"].ToString(),
                    FirstName = dataRow["FirstName"].ToString(),
                    Department = dataRow["Department"].ToString(),
                    Tel = dataRow["Tel"].ToString(),
                    Mobile = dataRow["Mobile"].ToString(),
                    Typ = dataRow["Typ"].ToString(),
                    Industrialplant = dataRow["Industrialplant"].ToString()
                };
                return ContactPerson;
            }
            return null;
        }

        public ContactPerson GetClientInfo(long id)
        {
            DataSet ds = _dataProvider.GetData(@"SELECT * FROM T_ContactPerson WHERE ID=" + id);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];

            ContactPerson contactPerson = new ContactPerson
            {
                ID = Convert.ToInt64(dr["ID"]),
                Company = Convert.ToInt32(dr["Company"]),
                Title = Convert.ToInt32(dr["Title"]),
                LastName = dr["LastName"].ToString(),
                FirstName = dr["FirstName"].ToString(),
                Department = dr["Department"].ToString(),
                Tel = dr["Tel"].ToString(),
                Mobile = dr["Mobile"].ToString(),
                Typ = dr["Typ"].ToString(),
                Industrialplant = dr["Industrialplant"].ToString()
            };
            return contactPerson;
        }
        public object Update(int contactPersonId,int company, int title, string firstName, string lastName, string department, string tel, string mobile, string type, string industrialPlant)
        {
            object oId = 0;
            try
            {
                string[] arrColumn = { "Company", "Title", "LastName", "FirstName", "Department", "Tel", "Mobile", "Typ", "Industrialplant" };
                string[] arrValue = { "" + company + "", "" + title + "", "'" + firstName + "'", "'" + lastName + "'", "'" + department + "'", "'" + tel + "'", "'" + mobile + "'", "'" + type + "'", "'" + industrialPlant + "'" };
                oId = _dataProvider.ManipulateData(QueryCreater.UpdateQuery("T_ContactPerson", arrColumn, arrValue, contactPersonId));
            }
            catch (Exception ex)
            {
            }
            return oId;
        }
        public List<ContactPerson> GetPerson()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_ContactPerson", null, null, "DESC"));
            DataTable dt = ds.Tables[0];
            List<ContactPerson> persons = new List<ContactPerson>();
            foreach (DataRow dataRow in dt.Rows)
            {
                persons.Add(new ContactPerson {
                                   ID = Convert.ToInt64(dataRow["ID"]),
                                   Company = Convert.ToInt32(dataRow["Company"]),
                                   Title = Convert.ToInt32(dataRow["Title"]),
                                   LastName = dataRow["LastName"].ToString(),
                                   FirstName = dataRow["FirstName"].ToString(),
                                   Department = dataRow["Department"].ToString(),
                                   Tel = dataRow["Tel"].ToString(),
                                   Mobile = dataRow["Mobile"].ToString(),
                                   Typ = dataRow["Typ"].ToString(),
                                   Industrialplant = dataRow["Industrialplant"].ToString()
                               });
            }
            return persons;
        }
        public List<ContactPerson> GetOrdersByRange(int pageNo = 1, int pageSize = 20)
        {
            string limitQuery = QueryCreater.SelectPagingQuery("T_ContactPerson", pageSize, pageNo);
            DataSet ds = _dataProvider.GetData(limitQuery);
            DataTable dt = ds.Tables[0];
            List<ContactPerson> ContactPersonList = new List<ContactPerson>();
            foreach (DataRow dataRow in dt.Rows)
            {
                ContactPerson contactperson = new ContactPerson
                {
                    ID = Convert.ToInt64(dataRow["ID"]),
                    Company = Convert.ToInt32(dataRow["Company"]),
                    Title = Convert.ToInt32(dataRow["Title"]),
                    LastName = dataRow["LastName"].ToString(),
                    FirstName = dataRow["FirstName"].ToString(),
                    Department = dataRow["Department"].ToString(),
                    Tel = dataRow["Tel"].ToString(),
                    Mobile = dataRow["Mobile"].ToString(),
                    Typ = dataRow["Typ"].ToString(),
                    Industrialplant = dataRow["Industrialplant"].ToString(),
                };
                ContactPersonList.Add(contactperson);
            }
            return ContactPersonList;
        }

        public object Add(Nullable<int> company, int title, string firstName, string lastName, string department, string tel, string mobile, string type, string industrialPlant)
        {
            object contactPersonId = 0;
            try
            {
                string[] arrColumn = { "Company", "Title", "FirstName", "LastName", "Department", "Tel", "Mobile", "Typ", "Industrialplant" };
                string[] arrValue = { "'" + company + "'", "" + title + "", "'" + firstName + "'", "'" + lastName + "'", "'" + department + "'", "'" + tel + "'", "'" + mobile + "'", "'" + type + "'", "'" + industrialPlant + "'" };

                contactPersonId = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_ContactPerson", arrColumn, arrValue));
            }
            catch (Exception ex)
            {
            }
            return contactPersonId;
        }

        public int GetCount()
        {
            DataSet ds = _dataProvider.GetData(QueryCreater.SelectQuery("T_ContactPerson", new[] { "Max(id) AS count" }));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dataRow in dt.Rows)
            {
                return Convert.ToInt32(string.IsNullOrEmpty(dataRow["count"].ToString()) ? "0" : dataRow["count"]);
            }
            return 0;
        }

    }
}