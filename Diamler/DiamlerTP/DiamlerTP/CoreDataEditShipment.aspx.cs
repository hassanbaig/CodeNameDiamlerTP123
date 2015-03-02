using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class CoreDataEditShipment : System.Web.UI.Page
    {
        private ShippmentDataProvider shipmentDataProvider;

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
            shipmentDataProvider = new ShippmentDataProvider();
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
            txtOpenTransport.Text = "";
            txtCloseTransport.Text = "";
            txtOperationalArea.Text = "";
            txtRemarks.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            object shipmentId = shipmentDataProvider.Update(Convert.ToInt32(ddlShipment.SelectedValue),txtSearchName.Text, txtName1.Text, txtName2.Text, txtStreet1.Text, txtStreet2.Text, txtPostCode.Text, txtCity.Text, txtRegion.Text, ddlCountry.SelectedValue, Convert.ToInt32(ddlContactPerson.SelectedValue), txtMainTel.Text, txtMainFax.Text, txtMainEmail.Text, txtLocation.Text, txtOpenTransport.Text, txtCloseTransport.Text, txtOperationalArea.Text, txtRemarks.Text, txtFlightNo.Text, ddlFunction.SelectedValue);
            if (shipmentId != null)
            {
                ClearControls();
                ddlShipment.DataBind();
            }
        }
        
        protected void ddlShipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shippment shippment = shipmentDataProvider.GetShipmentInfo(Convert.ToInt32(ddlShipment.SelectedValue));
            txtSearchName.Text = shippment.SearchName;
            txtName1.Text = shippment.Name1;
            txtName2.Text = shippment.Name2;
            txtStreet1.Text = shippment.Street1;
            txtStreet2.Text = shippment.Street2;
            txtPostCode.Text = shippment.PostCode;
            txtCity.Text = shippment.City;
            txtRegion.Text = shippment.Region;
            ddlCountry.SelectedValue = shippment.Country;
            ddlContactPerson.SelectedValue = shippment.ContactPerson.ToString();
            txtMainTel.Text = shippment.MainTel;
            txtMainFax.Text = shippment.MainFax;
            txtMainEmail.Text = shippment.MainEmail;
            txtLocation.Text = shippment.Location;
            txtOpenTransport.Text = shippment.OpenTransport;
            txtCloseTransport.Text = shippment.CloseTransport;
            txtOperationalArea.Text = shippment.OperationalArea;
            txtRemarks.Text = shippment.Remarks;
            txtFlightNo.Text = shippment.FlightNo;
            ddlFunction.SelectedValue = shippment.Function;            
        }
    }
}