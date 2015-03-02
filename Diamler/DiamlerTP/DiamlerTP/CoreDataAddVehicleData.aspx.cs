using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class CoreDataAddVehicleData : System.Web.UI.Page
    {
        private VehicleDimensionDataProvider vehicleDimensionDataProvider;
        protected void Page_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        private void Initialize()
        {
            lblResponseMessage.Text = "";
            vehicleDimensionDataProvider = new VehicleDimensionDataProvider();
        }

        private void ClearControls()
        {
            txtDescription.Text = "";
            txtModel.Text = "";
            txtLength.Text = "";
            txtWidth.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtWheelBase.Text = "";
            txtGroundSpace.Text = "";
            txtSlopeAngle.Text = "";
            txtFoldedMirrorWidth.Text = "";
            txtPrice.Text = "";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            object affectedRows = vehicleDimensionDataProvider.Add(txtDescription.Text, txtModel.Text, txtLength.Text, txtWidth.Text, txtHeight.Text, txtWeight.Text, txtWheelBase.Text, txtGroundSpace.Text, txtSlopeAngle.Text, txtFoldedMirrorWidth.Text, txtPrice.Text);
            if (affectedRows != null)
            {                
                ClearControls();
                lblResponseMessage.Text = "Record has been added successfully";
            }
        }
    }
}