using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class TruckMethodEditShipmentSelection : System.Web.UI.Page
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
            txtDestinationPrice.Text = "";
            txtReturnPrice.Text = "";
        }
     
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            orderDataProvider.Update(Convert.ToInt32(ddlOrder.SelectedValue), txtDestinationPrice.Text, txtReturnPrice.Text);
            ClearControls();
            lblResponseMessage.Text = "Record has been updated successfully.";
        }

        protected void ddlOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order order = orderDataProvider.GetOrderInfo(Convert.ToInt32(ddlOrder.SelectedValue));           
            txtDestinationPrice.Text = order.DestinationPrice;
            txtReturnPrice.Text = order.ReturnPrice;
        }
    }
}