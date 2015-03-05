using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class TruckMethodViewCarrageNotice : System.Web.UI.Page
    {
        private OrderDataProvider orderDataProvider;
        protected void Page_Load(object sender, EventArgs e)
        {
            Initialize();
            if(!IsPostBack)
            { this.DataBind(true); }
        }
        private void Initialize()
        { orderDataProvider = new OrderDataProvider(); }
        protected void btnCMROpen_Click(object sender, EventArgs e)
        {
            string textVal = ddlOrder.Text;
            Response.Redirect("ReportViewerForm.aspx?ID=" + textVal + "&ReportType=" + 6);
        }

        protected void ddlOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<OrderDetails> order = orderDataProvider.GetOrderDetailsInfo(Convert.ToInt32(ddlOrder.SelectedValue));
            gvVehicleList.DataSource = order;
            gvVehicleList.DataBind();
        }
    }
}