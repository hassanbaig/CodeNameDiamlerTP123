using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestReportWebApp;
using CrystalReportWebApp.DAL;
using CrystalReportWebApp.Forward_Request_Reports;
using CrystalReportWebApp.TitleLayout;
using CrystalReportWebApp.Versicherung;

namespace CrystalReportWebApp
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
                    CrystalReportWebApp.TransportOrderRequest.Transport_Order_Address creport5 = new TransportOrderRequest.Transport_Order_Address();                    
                    creport5.SetDataSource(dview);
                    CrystalReportViewer1.ReportSource = creport5;
                    CrystalReportViewer1.DataBind();
                    break;

                case "6":
                    ds = obj.RunSP("CMR_SP", IDVal);
                    dview.Table = ds.Tables[0];
                    CrystalReportWebApp.CMR.CMR creport6 = new CrystalReportWebApp.CMR.CMR();
                    creport6.SetDataSource(dview);
                    CrystalReportViewer1.ReportSource = creport6;
                    CrystalReportViewer1.DataBind();
                    break;

                default:
                    break;
            }


            // string FR1 = Request.QueryString["FR1"].ToString();

            //  string FR2 = Request.QueryString["FR2"].ToString();

            //  string TitleLayout = Request.QueryString["TitleLayout"].ToString();

            //  string Insurance = Request.QueryString["Insurance"].ToString();

            // string TransportOrder = Request.QueryString["TransportOrder"].ToString();

            //  string CMR = Request.QueryString["CMR"].ToString();

            //if (FR1 != string.Empty)
            //{
            //    int ID = Convert.ToInt32(FR1);

            //    DAL.DataProvider obj = new DataProvider();
            //    DataSet ds = obj.RunSP("Forward_Request", ID);

            //    DataView dview = new DataView();
            //    dview.Table = ds.Tables[0];
            //    OneWayRequest creport = new OneWayRequest();             
            //    creport.SetDataSource(dview);
            //    CrystalReportViewer1.ReportSource = creport;
            //    CrystalReportViewer1.DataBind();
            //}

            //if (FR2 != string.Empty)
            //{
            //    int ID = Convert.ToInt32(FR2);

            //    DAL.DataProvider obj = new DataProvider();
            //    DataSet ds = obj.RunSP("ForwardRequest", ID);

            //    DataView dview = new DataView();
            //    dview.Table = ds.Tables[0];
            //    TwoWay creport = new TwoWay();
            //    creport.SetDataSource(dview);
            //    CrystalReportViewer1.ReportSource = creport;
            //    CrystalReportViewer1.DataBind();
            //}

            //if (TitleLayout != string.Empty)
            //{
            //    int ID = Convert.ToInt32(TitleLayout);

            //    DAL.DataProvider obj = new DataProvider();
            //    DataSet ds = obj.RunSP("Title_Laout", ID);

            //    DataView dview = new DataView();
            //    dview.Table = ds.Tables[0];
            //    Layout creport = new Layout();
            //    creport.SetDataSource(dview);
            //    CrystalReportViewer1.ReportSource = creport;
            //    CrystalReportViewer1.DataBind();
            //}

            //if (Insurance != string.Empty)
            //{
            //    int ID = Convert.ToInt32(Insurance);

            //    DAL.DataProvider obj = new DataProvider();
            //    DataSet ds = obj.RunSP("Insurance_Vers", ID);

            //    DataView dview = new DataView();
            //    dview.Table = ds.Tables[0];
            //    CrystalReportWebApp.Versicherung.Insurance creport = new Versicherung.Insurance();                
            //    creport.SetDataSource(dview);
            //    CrystalReportViewer1.ReportSource = creport;
            //    CrystalReportViewer1.DataBind();
            //}

            //if (TransportOrder != string.Empty)
            //{
            //    int ID = Convert.ToInt32(TransportOrder);

            //    DAL.DataProvider obj = new DataProvider();
            //    DataSet ds = obj.RunSP("Transport_Order", ID);
            //    DataView dview = new DataView();
            //    dview.Table = ds.Tables[0];
            //    CrystalReportWebApp.TransportOrderRequest.Transport_Order_Address creport = new TransportOrderRequest.Transport_Order_Address();                               
            //    creport.SetDataSource(dview);
            //    CrystalReportViewer1.ReportSource = creport;
            //    CrystalReportViewer1.DataBind();
            //}

            //if (CMR != string.Empty)
            //{
            //    int ID = Convert.ToInt32(CMR);

            //    DAL.DataProvider obj = new DataProvider();
            //    DataSet ds = obj.RunSP("CMR_SP", ID);
            //    DataView dview = new DataView();
            //    dview.Table = ds.Tables[0];
            //    CrystalReportWebApp.CMR.CMR creport = new CrystalReportWebApp.CMR.CMR();
            //    creport.SetDataSource(dview);
            //    CrystalReportViewer1.ReportSource = creport;
            //    CrystalReportViewer1.DataBind();
            //}

        }
    }
}