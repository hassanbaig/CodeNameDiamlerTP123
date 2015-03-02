using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class CoreDataEditLoadAddress : System.Web.UI.Page
    {
        private LoadAdressDataProvider loadAddressDataProvider;

        protected void Page_Load(object sender, EventArgs e)
        {
            Initialize();
            if (!IsPostBack)
            {                
                this.DataBind(true);
            }
        }
        private void Initialize()
        {
            lblResponseMessage.Text = "";
            loadAddressDataProvider = new LoadAdressDataProvider();
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
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            object contactPersonId = loadAddressDataProvider.Update(Convert.ToInt32(ddlLoadAddress.SelectedValue),txtSearchName.Text,txtName1.Text,txtName2.Text, txtStreet1.Text,txtStreet2.Text,txtPostCode.Text, txtCity.Text,txtRegion.Text, ddlCountry.SelectedValue.ToString());
            if (contactPersonId != null)
            {
                ClearControls();
                ddlLoadAddress.DataBind();
            }
        }
        protected void ddlLoadAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAdress loadAdress = loadAddressDataProvider.GetLoadAddressInfo(Convert.ToInt64(ddlLoadAddress.SelectedValue));
            txtSearchName.Text = loadAdress.SearchName;
            txtName1.Text = loadAdress.Name1;
            txtName2.Text = loadAdress.Name2;
            txtStreet1.Text = loadAdress.Street1;
            txtStreet2.Text = loadAdress.Street2;
            txtPostCode.Text = loadAdress.PostCode;
            txtCity.Text = loadAdress.City;
            txtRegion.Text = loadAdress.Region;
            ddlCountry.SelectedValue = loadAdress.Country;
        }     
    }
}