using DiamlerTP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DiamlerTP
{
    public partial class Auftragabber : System.Web.UI.Page
    {
        private OrderDataProvider _orderProvider;
        protected List<Order> orders;
        protected void Page_Load(object sender, EventArgs e)
        {
            _orderProvider = new OrderDataProvider();
            orders = _orderProvider.GetOrdersByRange();
            GridView1.DataSource = orders;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }
    }
}