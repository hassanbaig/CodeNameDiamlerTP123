using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class EditAdditionalInfo : System.Web.UI.Page
    {
        private AdditionalInfoDataProvider additionalInfoDataProvider;
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
            additionalInfoDataProvider = new AdditionalInfoDataProvider();
        }        
        private void ClearControls()
        {
            txtShortName.Text = "";
            txtAdditionalInfo.Text = "";
        }        
        protected void ddlAdditionalInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdditionalInfo contactPerson = additionalInfoDataProvider.GetAdditionalInformationInfo(Convert.ToInt32(ddlAdditionalInfo.SelectedValue));
            txtShortName.Text = contactPerson.Shortname;
            txtAdditionalInfo.Text = contactPerson.AdditionInfo;
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            object additionalInfoId = additionalInfoDataProvider.Update(Convert.ToInt32(ddlAdditionalInfo.SelectedValue),txtShortName.Text,txtAdditionalInfo.Text);
            if (additionalInfoId != null)
            {
                ClearControls();
                ddlAdditionalInfo.DataBind();
            }
        }
    }
}