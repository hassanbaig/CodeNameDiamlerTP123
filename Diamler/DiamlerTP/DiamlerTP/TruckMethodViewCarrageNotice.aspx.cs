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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCMROpen_Click(object sender, EventArgs e)
        {
            string textVal = ddlOrder.Text;
            Response.Redirect("ReportViewerForm.aspx?ID=" + textVal + "&ReportType=" + 6);
        }
    }
}