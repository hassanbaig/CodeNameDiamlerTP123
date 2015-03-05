using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiamlerTP.DAL;

namespace DiamlerTP
{
    public partial class StatisticsViewShipmentOrder : System.Web.UI.Page
    {
        private OrderDataProvider orderDataProvider;
        private ClientDataProvider clientDataProvider;
        private OrderDetailsDataProvider orderDetailsDataProvider;
        protected void Page_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            orderDataProvider = new OrderDataProvider();
            clientDataProvider = new ClientDataProvider();
            orderDetailsDataProvider = new OrderDetailsDataProvider();
        }
        protected void btnViewReport_Click(object sender, EventArgs e)
        {
            txtTotalPrice.Text = orderDetailsDataProvider.GetPriceSum(Convert.ToInt32(ddlOrder.SelectedValue)).ToString();
        }

        private void Fill(List<Order> data)
        {
            int totalCars, totalPrice, carsInMTC, carsInMTCPrice, carsInMarketingVertrieb, carsInMarketingVertriebPrice, carsInW50Diverse, carsInW50DiversePrice;
            totalCars = 0;
            totalPrice = 0;
            carsInMTC = 0;
            carsInMTCPrice = 0;
            carsInMarketingVertrieb = 0;
            carsInMarketingVertriebPrice = 0;
            carsInW50Diverse = 0;
            carsInW50DiversePrice = 0;

            foreach (Order item in data)
            {
                totalCars += Convert.ToInt32(item.VechicleNo);                
            }

        }
    }
}