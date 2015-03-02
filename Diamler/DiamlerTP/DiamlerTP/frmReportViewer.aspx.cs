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
using DiamlerTP;

namespace CrystalReportWebApp
{
    public partial class frmReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string FR1 = Request.QueryString["TitleLayout"].ToString();
                DisplayRecord(FR1); }
        }

        public void DisplayRecord(string Insurance)
        {

          

          //  string FR2 = Request.QueryString["FR2"].ToString();

          //  string TitleLayout = Request.QueryString["TitleLayout"].ToString();

          //  string Insurance = Request.QueryString["Insurance"].ToString();

           // string TransportOrder = Request.QueryString["TransportOrder"].ToString();

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

          if (Insurance != string.Empty)
          {
              int ID = Convert.ToInt32(Insurance);

              DataProvider obj = new DataProvider();
              DataSet ds = obj.RunSP("Insurance_Vers", ID);

              DataView dview = new DataView();
              dview.Table = ds.Tables[0];
              Insurance creport = new Insurance();
              creport.SetDataSource(dview);
              CrystalReportViewer1.ReportSource = creport;
              CrystalReportViewer1.DataBind();
          }

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

        }
    }
}