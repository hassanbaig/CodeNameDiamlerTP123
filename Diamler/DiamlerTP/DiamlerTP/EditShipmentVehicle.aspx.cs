using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class EditShipmentVehicle : System.Web.UI.Page
    {
        private ShippmentVehicleDataProvider shippmentVehicleDataProvider;

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
            shippmentVehicleDataProvider = new ShippmentVehicleDataProvider();
        }
        
        private void ClearControls()
        {
            ddlShipmentId.SelectedIndex = 0;
            txtNumberPlate.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            object shipmentVehicleId = shippmentVehicleDataProvider.Update(Convert.ToInt32(ddlShipmentVehicle.SelectedValue),Convert.ToInt32(ddlShipmentId.SelectedValue),txtNumberPlate.Text);
            if (shipmentVehicleId != null)
            {
                ClearControls();
                ddlShipmentVehicle.DataBind();
            }
        }
        protected void ddlShipmentVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShippmentVehicle shippmentContactPerson = shippmentVehicleDataProvider.GetShipmentVehicleInfo(Convert.ToInt32(ddlShipmentVehicle.SelectedValue));
            ddlShipmentId.SelectedValue = shippmentContactPerson.Shippment.ToString();
            txtNumberPlate.Text = shippmentContactPerson.NumberPlate;
            ddlShipmentId.DataBind();
        }
    }
}