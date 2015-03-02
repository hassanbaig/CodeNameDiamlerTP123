using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiamlerTP.DAL;

namespace CrystalReportWebApp
{
    public partial class frmReportCall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRpt1_Click(object sender, EventArgs e)
        {
            string textVal = txtFR1way.Text;
            Response.Redirect("frmReportViewer.aspx?FR1=" + textVal); 
        }

        protected void btnRpt2_Click(object sender, EventArgs e)
        {
            string textVal = txtFR2way.Text;
            Response.Redirect("frmReportViewer.aspx?FR2=" + textVal); 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string textVal = txtTitleLayout.Text;
            Response.Redirect("frmReportViewer.aspx?TitleLayout=" + textVal); 
        }

        protected void ButtonInsurance_Click(object sender, EventArgs e)
        {
            string textVal = txtInsurance.Text;
            Response.Redirect("frmReportViewer.aspx?Insurance=" + textVal); 
        }

        protected void ButtonTransOrdReq_Click(object sender, EventArgs e)
        {
            string textVal = txtTransportOrdReq.Text;
            Response.Redirect("frmReportViewer.aspx?TransportOrder=" + textVal); 
        }
    }
}