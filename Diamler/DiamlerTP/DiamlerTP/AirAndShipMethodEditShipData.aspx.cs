using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class AirAndShipMethodEditShipData : System.Web.UI.Page
    {       
        private AirShipDetailDataProvider airShipDetailDataProvider;
        protected void Page_Load(object sender, EventArgs e)
        {
            Initialize();
            if(!IsPostBack)
            { this.DataBind(true); }
        }
        private void Initialize()
        {
            lblResponseMessage.Text = "";          
            airShipDetailDataProvider = new AirShipDetailDataProvider();
        }
        protected void ddlOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            AirShipDetail airShipDetail = airShipDetailDataProvider.GetAirShipDetailInfo(Convert.ToInt32(ddlOrder.SelectedValue));
            txtMBSNo.Text = airShipDetail.MBSNo;
            calFlightDate.SelectedDate = airShipDetail.FlightDate;
            txtFlight.Text = airShipDetail.Flight;
            txtAWB.Text = airShipDetail.AWB;
            txtShipper.Text = airShipDetail.Shipper;
            txtExportKind.Text = airShipDetail.ExportKind;
            txtTIBCarnetNo.Text = airShipDetail.TIBCarnetNo;
            txtGoodsKind.Text = airShipDetail.GoodsKind;
            txtChassisNo.Text = airShipDetail.ChassisNo;
            calShipmentFromSifi.SelectedDate = airShipDetail.ShippmentFromSifi;
            calArrival.SelectedDate = airShipDetail.Arrival;
            txtDestination.Text = airShipDetail.Destination;
            txtReturnDate.Text = airShipDetail.ReturnDate;
            ddlClient.SelectedValue = airShipDetail.Client.ToString();
            txtCustomClearance.Text = airShipDetail.CustomClearence;
        }

        private void ClearAll()
        {
            
        }
     
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            airShipDetailDataProvider.Update(Convert.ToInt32(ddlOrder.SelectedValue),txtMBSNo.Text,calFlightDate.SelectedDate,txtFlight.Text,txtAWB.Text,txtShipper.Text,
                txtExportKind.Text,txtTIBCarnetNo.Text,txtGoodsKind.Text,txtChassisNo.Text,calShipmentFromSifi.SelectedDate,Convert.ToDateTime(txtReturnDate.Text),Convert.ToInt32(ddlClient.SelectedValue),txtCustomClearance.Text);
             ClearAll();
        }
    }
}