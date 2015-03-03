using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class AirAndShipMethodEditOrder : System.Web.UI.Page
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

        private void ClearAll()
        {
            txtTPLInternalInfo.Text = "";
            txtSpecialOrderRequirement.Text = "";
        }     
        protected void ddlOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order order = orderDataProvider.GetOrderInfo(Convert.ToInt32(ddlOrder.SelectedValue));
            calEntryDate.SelectedDate = order.EntryDate;
            ddlEmployeeInfo.SelectedValue = ((order.EmployeeInfo.ToString() != "0") ? order.EmployeeInfo.ToString() : "1");
            ddlShippingMethod.SelectedValue = ((order.ShippingMethod.ToString() != "0") ? order.ShippingMethod.ToString() : "1");
            ddlClient.SelectedValue = ((order.Client.ToString() != "0") ? order.Client.ToString() : "1");
            ddlShipment.SelectedValue = ((order.Shippment.ToString() != "0") ? order.Shippment.ToString() : "1");
            txtMainReference.Text = order.MainReceipt;
            txtNoOfVehicles.Text = order.VechicleNo;
            txtTPLInternalInfo.Text = order.InternalInfo;
            txtSpecialOrderRequirement.Text = order.SpecialInstruction;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            object orderId = orderDataProvider.Update(Convert.ToInt32(ddlOrder.SelectedValue), Convert.ToDateTime(calEntryDate.SelectedDate), Convert.ToInt32(ddlEmployeeInfo.SelectedValue), Convert.ToInt32(ddlShippingMethod.SelectedValue), txtNoOfVehicles.Text, Convert.ToInt32(ddlClient.SelectedValue),Convert.ToInt32(ddlShipment.SelectedValue), txtMainReference.Text, txtTPLInternalInfo.Text, txtSpecialOrderRequirement.Text);
            if (orderId != null)
            { ClearAll(); }
        }
    }
}