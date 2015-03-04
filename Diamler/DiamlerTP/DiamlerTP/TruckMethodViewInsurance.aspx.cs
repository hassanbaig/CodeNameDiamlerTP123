using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiamlerTP.DAL;
namespace DiamlerTP
{
    public partial class TruckMethodViewInsurance : System.Web.UI.Page
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
            orderDataProvider = new OrderDataProvider();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            string textVal = ddlOrder.Text;
            Response.Redirect("ReportViewerForm.aspx?ID=" + textVal + "&ReportType=" + 4);
        }

        protected void ddlOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order order = orderDataProvider.GetInsurance(Convert.ToInt32(ddlOrder.SelectedValue));
            txtInsurance.Text = order.Insurance;
        }
    }
}