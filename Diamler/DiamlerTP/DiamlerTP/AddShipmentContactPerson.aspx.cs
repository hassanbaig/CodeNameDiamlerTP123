using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class AddShipmentContactPerson : System.Web.UI.Page
    {
        private ShippmentContactPersonDataProvider shipmentContactPersonDataProvider;
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
            shipmentContactPersonDataProvider = new ShippmentContactPersonDataProvider();
        }
        private void fillCombos()
        {
            ddlFunction.Items.Clear();
            List<string> functions = new List<string>();

            functions.Add("Disponent");
            functions.Add("Fahrer");
            functions.Add("Beides");

            ddlFunction.DataSource = functions;
        }
        private void ClearControls()
        {
            ddlFunction.SelectedIndex = 0;
            ddlTitle.SelectedIndex = 0;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            object shipmentContactPersonId = shipmentContactPersonDataProvider.Add(Convert.ToInt32(ddlShipmentId.SelectedValue), Convert.ToInt32(ddlTitle.SelectedValue), txtFirstName.Text, txtLastName.Text, txtMobile.Text, txtEmail.Text, ddlFunction.SelectedValue);
            if (shipmentContactPersonId != null)
            {
                ClearControls();
                lblResponseMessage.Text = "Record has been added successfully. New ID is " + shipmentContactPersonId;
            }
        }
    }
}