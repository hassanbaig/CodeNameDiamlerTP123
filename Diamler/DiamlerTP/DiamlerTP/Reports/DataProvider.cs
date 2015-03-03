using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CrystalReportWebApp.DAL
{
 
    public class DataProvider
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private readonly SqlConnection _sqlConnection;

        public DataProvider()
        {
            _sqlConnection = new SqlConnection(_connectionString);
        }

        public void Open()
        {
            _sqlConnection.Open();
        }

        public void Close()
        {
            _sqlConnection.Close();
        }

        public DataSet GetData(string commandString)
        {
            SqlCommand cmd = new SqlCommand(commandString, _sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            return ds;
        }

        public DataSet RunSP(string commandString,int ID)
        {
            SqlCommand cmd = new SqlCommand(commandString, _sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@OrderId", SqlDbType.Int).Value = ID;


            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);

            return ds;
        }


        public int ManipulateData(string commandString)
        {
            string selectIdentity = "SELECT @@Identity";
            using (SqlCommand cmd = new SqlCommand(commandString, _sqlConnection))
            {
                if (_sqlConnection.State == ConnectionState.Open)
                { Close(); }
                Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = selectIdentity;
                var ID = cmd.ExecuteScalar();
                return Convert.ToInt32(ID);
            }
        }
    }
}