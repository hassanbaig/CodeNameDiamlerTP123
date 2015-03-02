using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class TruckMethodEditOrder : System.Web.UI.Page
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
     
        private void ClearAll()
        {
            txtTPLInternalInfo.Text = "";
            txtSpecialOrderRequirement.Text = "";
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            object orderId = orderDataProvider.Update(Convert.ToInt32(ddlOrder.SelectedValue), Convert.ToDateTime(calEntryDate.SelectedDate), Convert.ToInt32(ddlEmployeeInfo.SelectedValue), Convert.ToInt32(ddlShippingMethod.SelectedValue), txtNoOfVehicles.Text, Convert.ToInt32(ddlClient.SelectedValue), txtMainReference.Text,txtReferenceInfo.Text, txtTPLInternalInfo.Text, txtSpecialOrderRequirement.Text);
            if (orderId != null)
            { ClearAll(); }
        }
        protected void ddlOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order order = orderDataProvider.GetOrderInfo(Convert.ToInt32(ddlOrder.SelectedValue));
            calEntryDate.SelectedDate = order.EntryDate;
            ddlEmployeeInfo.SelectedValue = order.EmployeeInfo.ToString();
            ddlShippingMethod.SelectedValue = order.ShippingMethod.ToString();
            ddlClient.SelectedValue = order.Client.ToString();
            txtMainReference.Text = order.MainReceipt;
            txtReferenceInfo.Text = order.ReceiptInfo;
            calDeadline.SelectedDate = order.Tender;
            ddlAdditionalInfo.SelectedValue = order.AdditionalInformatio;
            txtTPLInternalInfo.Text = order.InternalInfo;
            txtSpecialOrderRequirement.Text = order.SpecialInstruction;
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
    }
}