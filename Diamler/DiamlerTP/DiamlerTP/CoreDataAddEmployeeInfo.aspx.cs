using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiamlerTP
{
    public partial class CoreDataAddEmployeeInfo : System.Web.UI.Page
    {       
        private EmployeeInfoDataProvider employeeInfoDataProvider;
        protected void Page_Load(object sender, EventArgs e)
        {
            Initialize();
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
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                object employeeId = employeeInfoDataProvider.Add(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtMobile.Text, txtEmail.Text, txtAbbreviation.Text, Convert.ToInt32(ddlStatus.SelectedValue), Convert.ToInt32(ddlTitle.SelectedValue));
                if (employeeId != null)
                {                    
                    ClearControls();
                    lblResponseMessage.Text = "Record has been added successfully. New ID is " + employeeId;
                }
            }
        }
    }
}