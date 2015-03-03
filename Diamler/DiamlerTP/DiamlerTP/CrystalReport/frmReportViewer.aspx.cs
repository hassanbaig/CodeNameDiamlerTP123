using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestReportWebApp;
using DiamlerTP.DAL;
using DiamlerTP.CrystalReport;

namespace DiamlerTP
{
    public partial class frmReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string OrderID = Request.QueryString["ID"].ToString();
            string ReportType = Request.QueryString["ReportType"].ToString();
            DisplayRecord(OrderID, ReportType);
        }

        public void DisplayRecord(string ID, string ReportType)
        {
            int IDVal = Convert.ToInt32(ID);
            DAL.DataProvider obj = new DataProvider();
            DataSet ds = new DataSet();
            DataView dview = new DataView();

            switch (ReportType)
            {
                case "1":
                    ds = obj.RunSP("Forward_Request", IDVal);

                    dview.Table = ds.Tables[0];
                    OneWayRequest creport = new OneWayRequest();
                    creport.SetDataSource(dview);
                    CrystalReportViewer1.ReportSource = creport;
                    CrystalReportViewer1.DataBind();
                    break;

                case "2":
                    ds = obj.RunSP("Forward_Request", IDVal);

                    dview.Table = ds.Tables[0];
                    TwoWay creport2 = new TwoWay();
                    creport2.SetDataSource(dview);
                    CrystalReportViewer1.ReportSource = creport2;
                    CrystalReportViewer1.DataBind();
                    break; 

                case "3":
                    ds = obj.RunSP("Title_Laout", IDVal);
                    dview.Table = ds.Tables[0];
                    Layout creport3 = new Layout();
                    creport3.SetDataSource(dview);
                    CrystalReportViewer1.ReportSource = creport3;
                    CrystalReportViewer1.DataBind();
                    break;

                case "4":
                    ds = obj.RunSP("Insurance_Vers", IDVal);
                    dview.Table = ds.Tables[0];
                    Insurance creport4 = new Insurance();
                    creport4.SetDataSource(dview);
                    CrystalReportViewer1.ReportSource = creport4;
                    CrystalReportViewer1.DataBind();
                    break;

                case "5":
                    ds = obj.RunSP("Transport_Order", IDVal);
                    dview.Table = ds.Tables[0];
                    Transport_Order_Address creport5 = new Transport_Order_Address();                  
                    creport5.SetDataSource(dview);
                    CrystalReportViewer1.ReportSource = creport5;
                    CrystalReportViewer1.DataBind();
                    break;

                case "6":
                    ds = obj.RunSP("CMR_SP", IDVal);
                    dview.Table = ds.Tables[0];
                    CMR creport6 = new CMR();                    
                    creport6.SetDataSource(dview);
                    CrystalReportViewer1.ReportSource = creport6;
                    CrystalReportViewer1.DataBind();
                    break;

                default:
                    break;
            }

        }
    }
}