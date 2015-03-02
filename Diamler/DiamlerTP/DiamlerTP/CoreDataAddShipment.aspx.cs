using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class CoreDataAddShipment : System.Web.UI.Page
    {
        private ShippmentDataProvider shipmentDataProvider;
        private ShippmentContactPersonDataProvider shipmentContactPersonDataProvider;
        protected void Page_Load(object sender, EventArgs e)
        {         
            Initialize();
            fillCombos();
            this.DataBind(true);
        }

        private void Initialize()
        {
            lblResponseMessage.Text = "";
            shipmentDataProvider = new ShippmentDataProvider();
            shipmentContactPersonDataProvider = new ShippmentContactPersonDataProvider();
        }
        private void fillCombos()
        {           
            ddlFunction.Items.Clear();
            ddlFunction2.Items.Clear();
            List<string> functions = new List<string>();

            functions.Add("Disponent");
            functions.Add("Fahrer");
            functions.Add("Beides");

            ddlFunction.DataSource = functions;
            ddlFunction2.DataSource = functions;
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
            ddlContactPerson.SelectedIndex = 0;
            txtMainTel.Text = "";
            txtMainFax.Text = "";
            txtMainEmail.Text = "";
            txtLocation.Text = "";
            txtFlightNo.Text = "";
            ddlFunction.SelectedIndex = 0;
            ddlFunction2.SelectedIndex = 0;
            ddlTitle.SelectedIndex = 0;
            txtOpenTransport.Text = "";
            txtCloseTransport.Text = "";
            txtOperationalArea.Text = "";
            txtRemarks.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";            
            txtMobile.Text = "";
            txtEmail.Text = "";            
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            object shipmentId = shipmentDataProvider.Add(txtSearchName.Text, txtName1.Text, txtName2.Text, txtStreet1.Text, txtStreet2.Text, txtPostCode.Text, txtCity.Text, txtRegion.Text, ddlCountry.SelectedValue, Convert.ToInt32(ddlContactPerson.SelectedValue), txtMainTel.Text, txtMainFax.Text, txtMainEmail.Text, txtLocation.Text, txtOpenTransport.Text, txtCloseTransport.Text, txtOperationalArea.Text, txtRemarks.Text, txtFlightNo.Text, ddlFunction.SelectedValue);
           if(shipmentId!=null)
           {
               ClearControls();
           lblResponseMessage.Text = "Record has been added successfully. New ID is " + shipmentId;
           ddlShipment.DataBind();
           }
        }

        protected void btnSaveContactPerson_Click(object sender, EventArgs e)
        {
               shipmentContactPersonDataProvider.Add(Convert.ToInt32(ddlShipment.SelectedValue), Convert.ToInt32(ddlTitle.SelectedValue), txtFirstName.Text, txtLastName.Text, txtMobile.Text, txtEmail.Text, ddlFunction2.SelectedValue);                            
        }
    }
}