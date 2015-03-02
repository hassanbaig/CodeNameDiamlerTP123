using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiamlerTP.DAL;
using System.Data;


namespace DiamlerTP
{
    public partial class AuftragDetails : System.Web.UI.Page
    {
        private ContactPersonDataProvider _ContactPersonDataProvider;
        private ContactPerson _ContactPerson;
        private List<ContactPerson> _contactpersonlist;
        private TitleDataProvider _titleDataProvider;
        private List<Title> _titlemethod;
        private string[] arrColumn;
        private string[] arrValue;
        protected Client _Modelclient;
        private DataProvider _dataProvider;
        protected void Page_Load(object sender, EventArgs e)
        {
            _ContactPersonDataProvider = new ContactPersonDataProvider();
            _dataProvider = new DataProvider();
            _titleDataProvider = new TitleDataProvider();
            _ContactPerson = new ContactPerson();
            _titlemethod = _titleDataProvider.GetTitle();
            DDLAnrede.DataSource = _titlemethod;
            DDLAnrede.DataBind();
            _contactpersonlist = _ContactPersonDataProvider.GetPerson();
            DDLTyp.DataSource = _contactpersonlist;
            DDLTyp.DataBind();
            DDLAbteilung.DataSource = _contactpersonlist;
            DDLAbteilung.DataBind();
            DDLFirma.DataSource = _contactpersonlist;
            DDLFirma.DataBind();
            DDLWerksverrechnung.DataSource = _contactpersonlist;
            DDLWerksverrechnung.DataBind();
        
        }


        protected void btnSave_Click2(object sender, EventArgs e)
        {

            arrColumn = new string[9];
            arrValue = new string[9];
            arrColumn[0] = "Company";
            arrColumn[1] = "Title";
            arrColumn[2] = "LastName";
            arrColumn[3] = "FirstName";
            arrColumn[4] = "Department";
            arrColumn[5] = "Tel";
            arrColumn[6] = "Mobile";
            arrColumn[7] = "Typ";
            arrColumn[8] = "IndustrialPlant";
            arrValue[0] = "'" + DDLFirma.SelectedValue + "'";
            arrValue[1] = "'" + DDLAnrede.SelectedValue + "'";
            arrValue[2] = "'" + txtName.Text + "'";
            arrValue[3] = "'" + txtVorname.Text + "'";
            arrValue[4] = "'" + DDLAbteilung.SelectedValue + "'";
            arrValue[5] = "'" + txtTel.Text + "'";
            arrValue[6] = "'" + txtMobile.Text + "'";
            arrValue[7] = "'" + DDLTyp.SelectedValue + "'";
            arrValue[8] = "'" + DDLWerksverrechnung.SelectedValue + "'";

            object result = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_ContactPerson", arrColumn, arrValue));

            if (result != null)
            {
                lblsuccess.Visible = true;
            }

        }
    }

}
