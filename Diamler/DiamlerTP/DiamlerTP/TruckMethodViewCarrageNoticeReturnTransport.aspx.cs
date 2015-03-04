using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class TruckMethodViewCarrageNoticeReturnTransport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCMROpen_Click(object sender, EventArgs e)
        {
            string textVal = txtCMR.Text;
            Response.Redirect("ReportViewerForm.aspx?ID=" + textVal + "&ReportType=" + 6);
        }

        protected void btnViewVehicleList_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}