using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class AddShipmentVehicle : System.Web.UI.Page
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
        protected void btnSave_Click(object sender, EventArgs e)
        {
            object shipmentVehicleId = shippmentVehicleDataProvider.Add(Convert.ToInt32(ddlShipmentId.SelectedValue), txtNumberPlate.Text);
            if (shipmentVehicleId != null)
            {
                lblResponseMessage.Text = "Record has been added successfully. New ID is " + shipmentVehicleId;
            }
        }
    }
}