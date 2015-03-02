using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DiamlerTP.DAL;

namespace DiamlerTP
{
    public partial class Spedition : System.Web.UI.Page
    {
        private ShippmentDataProvider _ShippmentDataProvider;
        private Shippment _shippment;
        private List<Shippment> _shippments;
        private string[] arrColumn;
        private string[] arrValue;
        private DataProvider _dataProvider;

        protected void Page_Load(object sender, EventArgs e)
        {

            _ShippmentDataProvider = new ShippmentDataProvider();
            _dataProvider = new DataProvider();
            _shippments = new List<Shippment>();
            _shippments = _ShippmentDataProvider.GetShippmentdata();
            DDLLand.DataSource = _shippments;
            DDLLand.DataBind();
            DDLFunktion.DataSource = _shippments;
            DDLFunktion.DataBind();
            DDLLand.DataSource = _shippments;
            DDLLand.DataBind();
            DDLSpedition.DataSource = _shippments;
            DDLSpedition.DataBind();

        }

        protected void btn_Click(object sender, EventArgs e)
        {

            arrColumn = new string[19];
            arrValue = new string[19];
            arrColumn[0] = "SearchName";
            arrColumn[1] = "Name1";
            arrColumn[2] = "Name2";
            arrColumn[3] = "Street1";
            arrColumn[4] = "Street2";
            arrColumn[5] = "PostCode";
            arrColumn[6] = "City";
            arrColumn[7] = "Region";
            arrColumn[8] = "Country";
            arrColumn[9] = "SearchName";
            arrColumn[10] = "MainTel";
            arrColumn[11] = "MainFax";
            arrColumn[12] = "MainEmail";
            arrColumn[13] = "FlightNo";
            arrColumn[14] = "Function";
            arrColumn[15] = "OpenTransport";
            arrColumn[16] = "CloseTransport";
            arrColumn[17] = "OperationalArea";
            arrColumn[18] = "Remarks";
           
            arrValue[0] = "'" + txtSuchname.Text + "'";
            arrValue[1] = "'" + txtName1.Text + "'";
            arrValue[2] = "'" + txtName2.Text + "'";
            arrValue[3] = "'" + txtStrasse1.Text + "'";
            arrValue[4] = "'" + txtStrasse2.Text + "'";
            arrValue[5] = "'" + txtPlz.Text + "'";
            arrValue[6] = "'" + txtStadt.Text + "'";
            arrValue[7] = "'" + txtRegion.Text + "'";
            arrValue[8] = "'" + DDLLand.SelectedValue + "'";
            arrValue[9] = "'" + DDLSpedition.SelectedValue + "'";
            arrValue[10] = "'" + txtHauptTel.Text + "'";
            arrValue[11] = "'" + txtHauptFax.Text + "'";
            arrValue[12] = "'" + txtHauptEmail.Text + "'";
            arrValue[13] = "'" + txtLftNr.Text + "'";
            arrValue[14] = "'" + DDLFunktion.SelectedValue + "'";
            arrValue[15] = "'" + txtOffeneTransporte.Text + "'";
            arrValue[16] = "'" + txtGeshlosseneTransporte.Text + "'";
            arrValue[17] = "'" + txtEinstazgiebete.Text + "'";
            arrValue[18] = "'" + txtBemerkungen.Text + "'";


            object result = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_Shippment", arrColumn, arrValue));

            if (result != null)
            {
                lblsuccess.Visible = true;
            }

        }

    }
}