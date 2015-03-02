using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DiamlerTP.DAL;

namespace DiamlerTP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private EmployeeInfoDataProvider _EmployeeProvider;
        protected List<EmployeeInfo> EmloyeeInfo;
        protected void Page_Load(object sender, EventArgs e)
        {
            _EmployeeProvider = new EmployeeInfoDataProvider();
             EmloyeeInfo = _EmployeeProvider.GetemployeeByRange();
            GridView1.DataSource = EmloyeeInfo;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }

}