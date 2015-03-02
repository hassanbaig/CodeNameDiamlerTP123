using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class AddAdditionalInfo : System.Web.UI.Page
    {
        private AdditionalInfoDataProvider additionalInfoDataProvider;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        private void Initialize()
        {
            lblResponseMessage.Text = "";
            additionalInfoDataProvider = new AdditionalInfoDataProvider();
        }

        private void ClearControls()
        {
            txtShortName.Text = "";
            txtAdditionalInfo.Text = "";
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            object additionalInfoId = additionalInfoDataProvider.Add(txtShortName.Text, txtAdditionalInfo.Text);
            if (additionalInfoId != null)
            {
                ClearControls();
                lblResponseMessage.Text = "Record has been added successfully. New ID is " + additionalInfoId;
            }
        }
    }
}