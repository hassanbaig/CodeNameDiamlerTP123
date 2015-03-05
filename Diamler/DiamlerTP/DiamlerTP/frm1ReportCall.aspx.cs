using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class frm1ReportCall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCMR_Click(object sender, EventArgs e)
        {
            string textVal = txtCMR.Text;
            Response.Redirect("frm2ReportView.aspx?ID=" + textVal + "&ReportType=" + 6);
        }
    }
}