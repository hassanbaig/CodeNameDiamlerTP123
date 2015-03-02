using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class CoreDataEditEmployeeInfo : System.Web.UI.Page
    {
        private EmployeeInfoDataProvider employeeInfoDataProvider;

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
            employeeInfoDataProvider = new EmployeeInfoDataProvider();
        }

        private void ClearControls()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtTel.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtAbbreviation.Text = "";
            ddlStatus.SelectedIndex = 0;
            ddlTitle.SelectedIndex = 0;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            object employeeId = employeeInfoDataProvider.Update(Convert.ToInt32(ddlEmployee.SelectedValue),txtFirstName.Text, txtLastName.Text, txtTel.Text, txtMobile.Text, txtEmail.Text, txtAbbreviation.Text, Convert.ToInt32(ddlStatus.SelectedValue), Convert.ToInt32(ddlTitle.SelectedValue));
            if (employeeId != null)
            {
                ClearControls();
                ddlEmployee.DataBind();
            }
        }


        protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeInfo employeeInfo = employeeInfoDataProvider.GetEmployeeInformationInfo(Convert.ToInt32(ddlEmployee.SelectedValue));
            txtLastName.Text = employeeInfo.LastName;
            txtFirstName.Text = employeeInfo.FirstName;
            txtTel.Text = employeeInfo.Tel;
            txtMobile.Text = employeeInfo.Mobile;
            txtEmail.Text = employeeInfo.Email;
            txtAbbreviation.Text = employeeInfo.Abberviation;
            ddlStatus.SelectedValue = employeeInfo.Status.ToString();
            ddlTitle.SelectedValue = employeeInfo.Title.ToString();
        }
    }
}