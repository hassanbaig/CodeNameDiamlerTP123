using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class AirAndShipMethodAddShipData : System.Web.UI.Page
    {
        private AirShipDetailDataProvider airShipDetailDataProvider;
        protected void Page_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        private void Initialize()
        {
            airShipDetailDataProvider = new AirShipDetailDataProvider();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            airShipDetailDataProvider.Add(Convert.ToInt32(ddlOrder.SelectedValue), calShipmentDate.SelectedDate, Convert.ToInt32(ddlShipmentAddress.SelectedValue));
            airShipDetailDataProvider.Add(Convert.ToInt32(ddlOrder.SelectedValue), calArrivalPlanned.SelectedDate, Convert.ToInt32(ddlReceivingAddress.SelectedValue));
            airShipDetailDataProvider.Update(Convert.ToInt32(ddlOrder.SelectedValue), txtNoOfVehicles.Text);
            airShipDetailDataProvider.Add(txtMBSNo.Text, calFlightDate.SelectedDate, txtFlight.Text, txtAWB.Text, txtShipper.Text, txtExportKind.Text, txtTIBCarnetNo.Text, txtGoodsKind.Text, txtChassisNo.Text, calShipmentFromSifi.SelectedDate, calReturnDate.SelectedDate, Convert.ToInt32(ddlClient.SelectedValue), txtCustomClearance.Text);
        }
    }
}