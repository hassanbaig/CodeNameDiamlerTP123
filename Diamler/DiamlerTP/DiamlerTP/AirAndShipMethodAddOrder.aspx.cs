using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class AirAndShipMethodAddOrder : System.Web.UI.Page
    {
        private OrderDataProvider orderDataProvider;
        protected void Page_Load(object sender, EventArgs e)
        {
            Initialize();
            if (!IsPostBack)
            {
                this.DataBind(true);
            }
        }
        private void Initialize()
        {
            lblResponseMessage.Text = "";
            orderDataProvider = new OrderDataProvider();            
        }
        private void ClearControls()
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            object orderId = orderDataProvider.Add(Convert.ToDateTime(calEntryDate.SelectedDate), Convert.ToInt32(ddlEmployeeInfo.SelectedValue), Convert.ToInt32(ddlShippingMethod.SelectedValue), txtNoOfVehicles.Text, Convert.ToInt32(ddlClient.SelectedValue), txtMainReference.Text, Convert.ToInt32(ddlShipment.SelectedValue), txtTPLInternalInfo.Text, txtSpecialOrderRequirement.Text);
            if (orderId != null)
            {
                lblResponseMessage.Text = "Record has been added successfully. New ID is " + orderId;
            }
        }
    }
}