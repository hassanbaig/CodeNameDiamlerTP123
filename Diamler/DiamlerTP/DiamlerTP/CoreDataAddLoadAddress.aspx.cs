using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class CoreDataAddLoadAddress : System.Web.UI.Page
    {
        private LoadAdressDataProvider loadAdressDataProvider;
        private ContactPersonDataProvider contactPersonDataProvider;
        protected void Page_Load(object sender, EventArgs e)
        {

            Initialize();
            fillCombos();
            this.DataBind(true);
        }

        private void Initialize()
        {
            lblResponseMessage.Text = "";
            loadAdressDataProvider = new LoadAdressDataProvider();
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
            txtSearchName.Text = "";
            txtName1.Text = "";
            txtName2.Text = "";
            txtStreet1.Text = "";
            txtStreet2.Text = "";
            txtPostCode.Text = "";
            txtCity.Text = "";
            txtRegion.Text = "";
            ddlCountry.SelectedIndex = 0;           
            ddlTitle.SelectedIndex = 0;            
            txtFirstName.Text = "";
            txtLastName.Text = "";
            ddlDepartment.SelectedIndex = 0;
            txtTel.Text = "";
            txtMobile.Text = "";
            ddlType.SelectedIndex = 0;
            ddlIndustrialPlant.SelectedIndex = 0;            
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            object loadAddressId = loadAdressDataProvider.Add(txtSearchName.Text, txtName1.Text, txtName2.Text, txtStreet1.Text, txtStreet2.Text, txtPostCode.Text, txtCity.Text, txtRegion.Text, ddlCountry.SelectedValue);
            if (loadAddressId != null)
            {                
                contactPersonDataProvider.Add(Convert.ToInt32(loadAddressId),Convert.ToInt32(ddlTitle.SelectedValue),txtFirstName.Text,txtLastName.Text,ddlDepartment.SelectedValue,txtTel.Text,txtMobile.Text,ddlType.SelectedValue,ddlIndustrialPlant.SelectedValue);
                ClearControls();
                lblResponseMessage.Text = "Record has been added successfully. New ID is " + loadAddressId;
            }
        }
    }
}