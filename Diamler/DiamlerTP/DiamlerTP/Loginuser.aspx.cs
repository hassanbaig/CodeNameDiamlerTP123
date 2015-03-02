using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiamlerTP.DAL;
using System.Data;
using System.Data.SqlClient;

namespace DiamlerTP
{
    public partial class Loginuser : System.Web.UI.Page
    {
        private LoginDataProvider _LoginDataProvider;
        private Login _login;
        private DataProvider _dataprovider;
        private string[] arrColumn;
        private string[] arrValue;

    
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            
            int temp = Convert.ToInt32(arrValue[0].ToString());
             if (temp==1)
             {
                 string password="Select from Password Login where'" + txtpassword.Text + "'";
                 
             }
            arrColumn = new string[2];
             arrValue  = new string[2];
           
            arrColumn[0] = "Email";
            arrColumn[1] = "Password";
            
            arrValue[0] = "'" + txtusername.Text + "'";
            arrValue[1] = "'" + txtpassword.Text + "'";
           
           
        }

        private object ExecuteScalar()
        {
            throw new NotImplementedException();
        }

    }
}