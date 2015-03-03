using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class TruckMethodAddShipmentSelection : System.Web.UI.Page
    {
        private OrderDataProvider orderDataProvider;
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
            orderDetailsDataProvider = new OrderDetailsDataProvider();
        }

        private void ClearControls()
        {
            ddlOrder.SelectedIndex = 0;
            ddlShipmentId.SelectedIndex = 0;
            ddlShipmentContactPerson.SelectedIndex = 0;
            txtDestinationPrice.Text = "";
            txtReturnPrice.Text = "";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            orderDataProvider.Update(Convert.ToInt32(ddlOrder.SelectedValue), Convert.ToInt32(ddlShipmentId.SelectedValue), Convert.ToInt32(ddlShipmentContactPerson.SelectedValue), txtDestinationPrice.Text, txtReturnPrice.Text);

            ClearControls();
            lblResponseMessage.Text = "Record has been updated successfully.";
        }

        protected void btnTransportOrderAddressSame_Click(object sender, EventArgs e)
        {

        }

        protected void btnTransportOrderAddressDifferent_Click(object sender, EventArgs e)
        {

        }

        protected void btnTransportOrderAddressOneWay_Click(object sender, EventArgs e)
        {

        }

        protected void btnViewOrderDetails_Click(object sender, EventArgs e)
        {
            gvOrderDetails.DataSource = orderDetailsDataProvider.GetOrderDetailsForGridView(Convert.ToInt64(ddlOrder.SelectedValue));
            gvOrderDetails.DataBind();
        }
    }
}