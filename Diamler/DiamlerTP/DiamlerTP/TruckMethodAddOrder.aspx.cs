using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{    
    public partial class TruckMethodAddOrder : System.Web.UI.Page
    {
        private OrderDataProvider orderDataProvider;
        private OrderAdressDataProvider orderAdressDataProvider;
        private OrderDetailsDataProvider orderDetailsDataProvider;
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
            orderAdressDataProvider = new OrderAdressDataProvider();
            orderDetailsDataProvider = new OrderDetailsDataProvider();
        }
        private void ClearControls()
        {

        }
        protected void btnForwardingRequestSame_Click(object sender, EventArgs e)
        {

        }

        protected void btnForwardingRequestDifferent_Click(object sender, EventArgs e)
        {

        }

        protected void btnForwardingRequestOneWay_Click(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
                orderAdressDataProvider.Add(Convert.ToInt32(ddlOrder.SelectedValue), Convert.ToInt64(ddlFTLoadLoadAddress.SelectedValue), Convert.ToInt64(ddlFTLoadContactPerson1.SelectedValue), Convert.ToInt64(ddlFTLoadContactPerson2.SelectedValue), calFTLoadDate.SelectedDate + TimeSpan.Parse(txtFTLoadTime.Text), "FT", 1);
                orderAdressDataProvider.Add(Convert.ToInt32(ddlOrder.SelectedValue), Convert.ToInt64(ddlFTUnloadUnloadAddress.SelectedValue), Convert.ToInt64(ddlFTUnloadContactPerson1.SelectedValue), Convert.ToInt64(ddlFTUnloadContactPerson2.SelectedValue), calFTUnloadDate.SelectedDate + TimeSpan.Parse(txtFTUnloadTime.Text), "FT", 0);
                orderAdressDataProvider.Add(Convert.ToInt32(ddlOrder.SelectedValue), Convert.ToInt64(ddlRTLoadLoadAddress.SelectedValue), Convert.ToInt64(ddlRTLoadContactPerson1.SelectedValue), Convert.ToInt64(ddlRTLoadContactPerson2.SelectedValue), calRTLoadDate.SelectedDate + TimeSpan.Parse(txtRTLoadTime.Text), "RT", 1);
                orderAdressDataProvider.Add(Convert.ToInt32(ddlOrder.SelectedValue), Convert.ToInt64(ddlRTUnloadUnloadAddress.SelectedValue), Convert.ToInt64(ddlRTUnloadContactPerson1.SelectedValue), Convert.ToInt64(ddlRTUnloadContactPerson2.SelectedValue), calRTUnloadDate.SelectedDate + TimeSpan.Parse(txtRTUnloadTime.Text), "RT", 0);

                orderDetailsDataProvider.Add(Convert.ToInt32(ddlOrder.SelectedValue), txtDesignatedFinasNo.Text, txtNumberPlate.Text, txtChassisNo.Text, txtReceipt.Text, txtLength.Text, txtWidth.Text, txtHeight.Text, txtWeight.Text, txtPrice.Text, txtTruckType.Text, Convert.ToInt32(ddlTransportWay.SelectedValue));
                               
        }

        protected void btnSaveOrder_Click(object sender, EventArgs e)
        {
            object orderId = orderDataProvider.Add(Convert.ToDateTime(calEntryDate.SelectedDate), Convert.ToInt32(ddlEmployeeInfo.SelectedValue), Convert.ToInt32(ddlShippingMethod.SelectedValue), txtNoOfVehicles.Text, Convert.ToInt32(ddlClient.SelectedValue), txtMainReference.Text, txtReferenceInfo.Text, Convert.ToDateTime(calDeadline.SelectedDate), Convert.ToInt32(ddlAdditionalInfo.SelectedValue), txtTPLInternalInfo.Text, txtSpecialOrderRequirement.Text);
            if (orderId != null)
            {
                lblResponseMessage.Text = "Record has been added successfully. New ID is " + orderId;
                ddlOrder.DataBind();
            }
        }
    }
}