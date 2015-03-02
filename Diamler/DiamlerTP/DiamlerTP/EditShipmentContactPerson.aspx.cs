using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class EditShipmentContactPerson : System.Web.UI.Page
    {
        private ShippmentContactPersonDataProvider shippmentContactPersonDataProvider;

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
            shippmentContactPersonDataProvider = new ShippmentContactPersonDataProvider();
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
            ddlShipment.SelectedIndex = 0;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            object shipmentContactPersonId = shippmentContactPersonDataProvider.Update(Convert.ToInt32(ddlShipmentContactPerson.SelectedValue),Convert.ToInt32(ddlShipment.SelectedValue),Convert.ToInt32(ddlTitle.SelectedValue),txtFirstName.Text, txtLastName.Text, txtMobile.Text, txtEmail.Text,ddlFunction.SelectedValue);
            if (shipmentContactPersonId != null)
            {
                ClearControls();
                ddlShipmentContactPerson.DataBind();
            }
        }
        protected void ddlShipmentContactPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShippmentContactPerson shippmentContactPerson = shippmentContactPersonDataProvider.GetShipmentContactPersonInfo(Convert.ToInt32(ddlShipmentContactPerson.SelectedValue));
            ddlShipment.SelectedValue = shippmentContactPerson.Shippment.ToString();
            ddlTitle.SelectedValue = shippmentContactPerson.Title.ToString();
            txtLastName.Text = shippmentContactPerson.LastNameSp;
            txtFirstName.Text = shippmentContactPerson.FirstNameSp;
            txtMobile.Text = shippmentContactPerson.Mobile;
            txtEmail.Text = shippmentContactPerson.Email;
            ddlFunction.SelectedValue = shippmentContactPerson.Function;
        }     

    }
}