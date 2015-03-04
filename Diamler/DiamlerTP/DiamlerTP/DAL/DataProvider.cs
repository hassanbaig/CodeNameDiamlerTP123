using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DiamlerTP.DAL
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

        public DataSet RunSP(string commandString, int ID)
        {
            SqlCommand cmd = new SqlCommand(commandString, _sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@OrderId", SqlDbType.Int).Value = ID;


            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);

            return ds;
        }

        public object ManipulateData(string commandString)
        {
            string selectIdentity = "SELECT @@Identity";
            using (SqlCommand cmd = new SqlCommand(commandString, _sqlConnection))
            {
                if (_sqlConnection.State == ConnectionState.Open)
                { Close(); }
                Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = selectIdentity;
                object ID = cmd.ExecuteScalar();               
                return ID;
            }
        }
        public int GetPriceSum(int Id)
        {
            int result = 0;
            string commandString = "SELECT SUM(Price) FROM T_OrderDetails WHERE OrderID = " + Id;
            using (SqlCommand cmd = new SqlCommand(commandString, _sqlConnection))
            {
                if (_sqlConnection.State == ConnectionState.Open)
                { Close(); }
                Open();
                result = (int)cmd.ExecuteScalar();         
            }
           return result;
        }

        public DataTable GetOrderDetails(long orderId)
        {
            //data reader we will use to read data from our tables
            SqlDataReader rdr;

            //data table we will format and databind to our gridview
            DataTable dt = new DataTable();
            //add the 4 columns we will use to our table
            dt.Columns.Add("OID");
            dt.Columns.Add("DesFin");
            dt.Columns.Add("NumPla");
            dt.Columns.Add("ChaNo");
            dt.Columns.Add("Len");
            dt.Columns.Add("Wid");
            dt.Columns.Add("Hei");
            dt.Columns.Add("Wei");
            dt.Columns.Add("Pri");
            dt.Columns.Add("Rec");
            dt.Columns.Add("Mod");
            dt.Columns.Add("TruTyp");            
            dt.Columns.Add("TraWay");
            int transportWay = 0;
            DataRow dr;
            _sqlConnection.ConnectionString = _connectionString;
            SqlCommand cmd = new SqlCommand("SELECT T_OrderDetails.OrderID OID, T_OrderDetails.DesignatedFinasNo DesFin,T_OrderDetails.NumberPlate NumPla,T_OrderDetails.ChassisNo ChaNo,T_OrderDetails.Length Len,T_OrderDetails.Width Wid,T_OrderDetails.Height Hei,T_OrderDetails.Weight Wei,T_OrderDetails.Price Pri,T_OrderDetails.Receipt Rec,T_OrderDetails.ModelYear Mod,T_OrderDetails.TruckType TruTyp ,T_OrderDetails.TransportWay,T_TransportWay.TransportWay TraWay  FROM T_OrderDetails INNER JOIN T_TransportWay ON T_OrderDetails.TransportWay = T_TransportWay.ID WHERE ([OrderID] = " + orderId + ")", _sqlConnection);
            cmd.CommandType = CommandType.Text;
            using (_sqlConnection)
            {             
                _sqlConnection.Open();
                    rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    dr = dt.NewRow();
                    dr["OID"] = rdr["OID"].ToString();
                    dr["DesFin"] = rdr["DesFin"].ToString();
                    dr["NumPla"] = rdr["NumPla"].ToString();
                    dr["ChaNo"] = rdr["ChaNo"].ToString();
                    dr["Len"] = rdr["Len"].ToString();
                    dr["Wid"] = rdr["Wid"].ToString();
                    dr["Hei"] = rdr["Hei"].ToString();
                    dr["Wei"] = rdr["Wei"].ToString();
                    dr["Pri"] = rdr["Pri"].ToString();
                    dr["Rec"] = rdr["Rec"].ToString();
                    dr["Mod"] = rdr["Mod"].ToString();
                    dr["TruTyp"] = rdr["TruTyp"].ToString();
                    dr["TraWay"] = rdr["TraWay"].ToString(); 
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                }
                
            }            
            return dt;
        }
    }
}