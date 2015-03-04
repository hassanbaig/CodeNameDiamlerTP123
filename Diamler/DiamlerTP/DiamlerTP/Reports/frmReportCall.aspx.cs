using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalReportWebApp.DAL;

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
            Response.Redirect("frmReportViewer.aspx?ID=" + textVal + "&ReportType=" + 1); 
        }

        protected void btnRpt2_Click(object sender, EventArgs e)
        {
            string textVal = txtFR2way.Text;
            Response.Redirect("frmReportViewer.aspx?ID=" + textVal + "&ReportType=" + 2);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string textVal = txtTitleLayout.Text;
            Response.Redirect("frmReportViewer.aspx?ID=" + textVal + "&ReportType=" + 3);
        }

        protected void ButtonInsurance_Click(object sender, EventArgs e)
        {
            string textVal = txtInsurance.Text;
            Response.Redirect("frmReportViewer.aspx?ID=" + textVal + "&ReportType=" + 4);
        }

        protected void ButtonTransOrdReq_Click(object sender, EventArgs e)
        {
            string textVal = txtTransportOrdReq.Text;
            Response.Redirect("frmReportViewer.aspx?ID=" + textVal + "&ReportType=" + 5);
        }

        protected void ButtonCMR_Click(object sender, EventArgs e)
        {
            string textVal = txtCMR.Text;
            Response.Redirect("frmReportViewer.aspx?ID=" + textVal + "&ReportType=" + 6);
        }
    }
}