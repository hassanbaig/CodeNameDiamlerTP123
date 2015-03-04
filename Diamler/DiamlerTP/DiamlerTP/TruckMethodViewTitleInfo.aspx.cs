using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class TruckMethodViewTitleInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOpenTitleInfo_Click(object sender, EventArgs e)
        {
            string textVal = ddlOrder.SelectedValue;
            Response.Redirect("ReportViewerForm.aspx?ID=" + textVal + "&ReportType=" + 3);
        }
    }
}