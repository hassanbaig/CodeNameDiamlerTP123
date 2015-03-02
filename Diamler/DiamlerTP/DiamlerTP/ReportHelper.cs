using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace TestReportWebApp
{
    public class ReportHelper
    {
        public static DataSet LoadReport()
        {
            SqlConnection conn = new SqlConnection("Data Source=Shinersoft;Initial Catalog=SSDesktopApp1;Integrated Security=True");
            string query = "Select * from Country";
            SqlDataAdapter adap = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            return ds;
        }
    }
}