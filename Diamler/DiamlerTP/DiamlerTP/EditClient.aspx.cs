using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class EditClient : System.Web.UI.Page
    {
        private ContactPersonDataProvider contactPersonDataProvider;

        protected void Page_Load(object sender, EventArgs e)
        {
            Initialize();
            if (!IsPostBack)
            {
                fillCombos();
                this.DataBind(true);
            }
        }                            
        private void Initialize()
        {
            lblResponseMessage.Text = "";
            contactPersonDataProvider = new ContactPersonDataProvider();
        }
        private void fillCombos()
        {
            ddlDepartment.Items.Clear();
            ddlIndustrialPlant.Items.Clear();
            ddlType.Items.Clear();
            List<string> departments = new List<string>();
            List<string> industrialPlants = new List<string>();
            List<string> types = new List<string>();

            departments.Add("PK/AF2");
            departments.Add("MS/M");
            departments.Add("EP/STD/Ep/Gee/");

            industrialPlants.Add("MTC");
            industrialPlants.Add("Marketing Vertrieb");
            industrialPlants.Add("W50 Diverse");


            types.Add("Auftraggeber");
            types.Add("Belader");
            types.Add("Disponent");
            types.Add("Fahrer");

            ddlDepartment.DataSource = departments;
            ddlIndustrialPlant.DataSource = industrialPlants;
            ddlType.DataSource = types;
        }
        private void ClearControls()
        {
            ddlTitle.SelectedIndex = 0;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            ddlDepartment.SelectedIndex = 0;
            txtTel.Text = "";
            txtMobile.Text = "";
            ddlType.SelectedIndex = 0;
            ddlIndustrialPlant.SelectedIndex = 0;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            object contactPersonId = contactPersonDataProvider.Update(Convert.ToInt32(ddlClient.SelectedValue), Convert.ToInt32(ddlLoadAddress.SelectedValue), Convert.ToInt32(ddlTitle.SelectedValue), txtFirstName.Text, txtLastName.Text, ddlDepartment.SelectedValue, txtTel.Text, txtMobile.Text, ddlType.SelectedValue, ddlIndustrialPlant.SelectedValue);
            if (contactPersonId != null)
            {
                ClearControls();
                ddlClient.DataBind();
            }
        }




        protected void ddlClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPerson contactPerson = contactPersonDataProvider.GetClientInfo(Convert.ToInt64(ddlClient.SelectedValue));
            ddlLoadAddress.SelectedValue = contactPerson.Company.ToString();
            ddlTitle.SelectedValue = contactPerson.Title.ToString();
            txtLastName.Text = contactPerson.LastName;
            txtFirstName.Text = contactPerson.FirstName;
            ddlDepartment.SelectedValue = contactPerson.Department.ToString();
            txtTel.Text = contactPerson.Tel;
            txtMobile.Text = contactPerson.Mobile;
            ddlType.SelectedValue = contactPerson.Typ.ToString();
            ddlIndustrialPlant.SelectedValue = contactPerson.Industrialplant;
        }    
    }
}