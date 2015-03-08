using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiamlerTP.DAL;

namespace DiamlerTP
{
    public partial class TruckMethodViewCarrageNotice : System.Web.UI.Page
    {
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
            orderDetailsDataProvider = new OrderDetailsDataProvider();
        }

        protected void btnCMROpen_Click(object sender, EventArgs e)
        {
            string textVal = ddlOrder.SelectedValue;
            Response.Redirect("ReportViewerForm.aspx?ID=" + textVal + "&ReportType=" + 6);
        }

        protected void ddlOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<VehicleList> vehicleList = orderDetailsDataProvider.GetVehicleList(Convert.ToInt32(ddlOrder.SelectedValue));
            gvVehicleList.DataSource = vehicleList;
            gvVehicleList.DataBind();
        }
    }
}