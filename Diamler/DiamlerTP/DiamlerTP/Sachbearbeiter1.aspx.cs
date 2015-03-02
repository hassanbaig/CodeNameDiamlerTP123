using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiamlerTP.DAL;

namespace DiamlerTP
{
    public partial class Sachbearbeiter1 : System.Web.UI.Page
    {
        private EmployeeInfoDataProvider _EmployeeDataProvider;
        private List<Status> _statusmethod;
        private StatusDataProvider _statusDataProvider;
        private TitleDataProvider _titleDataProvider;
        private List<Title> _DataTitle;
        private string[] arrColumn;
        private string[] arrValue;
        protected EmployeeInfo EmployeeInfo;
        private DataProvider _dataProvider;
        protected void Page_Load(object sender, EventArgs e)
        {
            _EmployeeDataProvider = new EmployeeInfoDataProvider();
            _dataProvider = new DataProvider();
            EmployeeInfo = new EmployeeInfo();
            _statusDataProvider = new StatusDataProvider();
            _statusmethod = _statusDataProvider.GetStatusData();
            _titleDataProvider = new TitleDataProvider();
            _DataTitle = _titleDataProvider.GetTitle();
            if (!IsPostBack)
            {
                DDLAktiv.DataSource = _statusmethod;
                DDLAktiv.DataBind();

                DDLAnrede.DataSource = _DataTitle;
                DDLAnrede.DataBind();
                divAlert.Visible = false;
            }

        }


        protected void btnSave_Click1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DDLAnrede.SelectedValue))
            {
                divAlert.Visible = true;
                divAlert.InnerText = "Bitte Wählen Sie Anrede";
            }
            else
                if (string.IsNullOrEmpty(DDLAktiv.SelectedValue))
                {
                    divAlert.Visible = true;
                    divAlert.InnerText = "Bitte Wählen Sie Aktiv";
                }
                else
                {
                    arrColumn = new string[8];
                    arrValue = new string[8];
                    arrColumn[0] = "Title";
                    arrColumn[1] = "LastName";
                    arrColumn[2] = "FirstName";
                    arrColumn[3] = "Tel";
                    arrColumn[4] = "Mobile";
                    arrColumn[5] = "Email";
                    arrColumn[6] = "Abbreviation";
                    arrColumn[7] = "Status";
                    arrValue[0] = "'" + DDLAnrede.SelectedValue + "'";
                    arrValue[1] = "'" + txtVorname.Text + "'";
                    arrValue[2] = "'" + txtNachname.Text + "'";
                    arrValue[3] = "'" + txtTel.Text + "'";
                    arrValue[4] = "'" + txtMobile.Text + "'";
                    arrValue[5] = "'" + txtEmail.Text + "'";
                    arrValue[6] = "'" + txtKurzzeichen.Text + "'";
                    arrValue[7] = "'" + DDLAktiv.SelectedValue + "'";


                    object result = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_EmployeeInfo", arrColumn, arrValue));

                    if (result != null)
                    {
                        lblsuccess.Visible = true;
                    }

                }

        }
    }
}