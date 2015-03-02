using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiamlerTP.DAL;
using DiamlerTP.DAL.Model;

namespace DiamlerTP
{
    public partial class TransportAuftragDetails : System.Web.UI.Page
    {
        private OrderDataProvider _orderProvider;
        private ShippingMethodDataProvider _shippingMethodDataProvider;
        private OrderAdressDataProvider _orderAdressDataProvider;
        private List<ShippingMethod> _shippingMethods;
        private List<Client> _clientMethods;
        private List<EmployeeInfo> _employeeInfo;
        private List<AdditionalInfo> _additionalData;
        private List<Order> _orders;
        private List<OrderAdress> _orderAdresses; 
        protected Order Order;

        protected void Page_Load(object sender, EventArgs e)
        {
            _orderProvider = new OrderDataProvider();
            _shippingMethodDataProvider = new ShippingMethodDataProvider();
            _orderAdressDataProvider = new OrderAdressDataProvider();
            _shippingMethods = _shippingMethodDataProvider.GetShippingMethod();
            _clientMethods = _shippingMethodDataProvider.GetClientData();
            _additionalData = _shippingMethodDataProvider.GetAdditionalInfoData();
            _employeeInfo = _shippingMethodDataProvider.GetemployeeInfoData();

            if (!IsPostBack)
            {
                divAlerts.Visible = false;
            }
            

        }

        protected void ddlOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlOrder = (DropDownList)sender;

            if (int.Parse(ddlOrder.SelectedValue) > 0)
            {
                OrderFormView.ChangeMode(FormViewMode.ReadOnly);
                Order = _orderProvider.GetOrder(Convert.ToInt32(((DropDownList) sender).SelectedValue));
                OrderFormView.DataSource = new List<Order>() { Order };
                OrderFormView.DataBind();
                _orderAdresses = _orderAdressDataProvider.GetOrderAdress(Order.Id);
                gridViewTransport.DataSource = _orderAdresses;
                gridViewTransport.DataBind();
            }
            else
            {
                OrderFormView.ChangeMode(FormViewMode.Insert);
            }

        }

        protected void OrderDetailsView_PreRender(object sender, EventArgs e)
        {
            DropDownList ddlEmployeeInfo = (DropDownList)OrderFormView.FindControl("ddlEmployeeInfo");
            DropDownList ddlTransportType = (DropDownList)OrderFormView.FindControl("ddlTransportType");
            DropDownList ddlAuftraggeber = (DropDownList)OrderFormView.FindControl("ddlClient");
            DropDownList ddlAddionalInformation = (DropDownList)OrderFormView.FindControl("ddlAddionalInformation");
            DropDownList ddlOrder = (DropDownList)OrderFormView.FindControl("ddlOrder");

            if (OrderFormView.CurrentMode == FormViewMode.Insert || OrderFormView.CurrentMode == FormViewMode.Edit)
            {
                ddlEmployeeInfo.DataSource = _employeeInfo;
                ddlEmployeeInfo.DataBind();

                ddlTransportType.DataSource = _shippingMethods;
                ddlTransportType.DataBind();

                ddlAuftraggeber.DataSource = _clientMethods;
                ddlAuftraggeber.DataBind();

                ddlAddionalInformation.DataSource = _additionalData;
                ddlAddionalInformation.DataBind();
            }
            if (OrderFormView.CurrentMode == FormViewMode.Insert || OrderFormView.CurrentMode == FormViewMode.ReadOnly)
            {
                _orders = _orderProvider.GetOrdersByRange(1, 200);
                ddlOrder.DataSource = _orders;
                ddlOrder.DataBind();
            }
            if (OrderFormView.CurrentMode == FormViewMode.ReadOnly)
            {
                ddlOrder.SelectedValue = Order.Id.ToString();
            }
            if (OrderFormView.CurrentMode == FormViewMode.Edit)
            {
                ddlEmployeeInfo.SelectedValue = Order.EmployeeInfo.ToString();
                ddlAuftraggeber.SelectedValue = Order.Client.ToString();
                ddlAddionalInformation.SelectedValue = Order.AdditionalInformatio;
                ddlTransportType.SelectedValue = Order.ShippingMethod.ToString();
            }

        }

        protected void OrderFormView_ItemCommand(object sender, FormViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                OrderFormView.ChangeMode(FormViewMode.Edit);
                Order = _orderProvider.GetOrder(Convert.ToInt32(((FormView) sender).DataKey.Value));
                OrderFormView.DataSource = new List<Order>() { Order };
                OrderFormView.DataBind();
                
                gridViewTransport.DataSource = new List<int>();
                gridViewTransport.DataBind();
            }
            if (e.CommandName == "New")
            {
                DropDownList ddlEmployeeInfo = (DropDownList)OrderFormView.FindControl("DDLEmployeeInfo");
                DropDownList ddlTransportType = (DropDownList) OrderFormView.FindControl("ddlTransportType");
                TextBox txtNoOfVehicle = (TextBox)OrderFormView.FindControl("txtNoOfVehicle");
                DropDownList ddlClient = (DropDownList) OrderFormView.FindControl("ddlClient");
                TextBox txtAssignment = (TextBox) OrderFormView.FindControl("txtAssignment");
                TextBox txtAssignmentInfo = (TextBox) OrderFormView.FindControl("txtAssignmentInfo");
                TextBox txtAppointOffer = (TextBox) OrderFormView.FindControl("txtAppointOffer");
                DropDownList ddlAddionalInformation = (DropDownList) OrderFormView.FindControl("ddlAddionalInformation");
                TextBox txtOrderSpecialityBox = (TextBox) OrderFormView.FindControl("txtOrderSpeciality");
                TextBox txtInternalInfo = (TextBox) OrderFormView.FindControl("txtInternalInfo");

                Order = new Order()
                {
                    EmployeeInfo = int.Parse(ddlEmployeeInfo.SelectedValue),
                    ShippingMethod = int.Parse(ddlTransportType.SelectedValue),
                    VechicleNo = txtNoOfVehicle.Text,
                    Client = int.Parse(ddlClient.SelectedValue),
                    MainReceipt = txtAssignment.Text,
                    ReceiptInfo = txtAssignmentInfo.Text,
                    Tender = DateTime.ParseExact(txtAppointOffer.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    AdditionalInformatio = ddlAddionalInformation.SelectedValue,
                    SpecialInstruction = txtOrderSpecialityBox.Text,
                    InternalInfo = txtInternalInfo.Text,
                    EntryDate = DateTime.Now
                };

                int id = _orderProvider.InsertOrder(Order);
                if (id == 1)
                {
                    OrderFormView.ChangeMode(FormViewMode.ReadOnly);
                    Order = _orderProvider.GetOrder(_orderProvider.GetCount());
                    if (Order != null)
                    {
                        OrderFormView.DataSource = new List<Order>() {Order};
                        OrderFormView.DataBind();
                    }
                }
            }
        }

        protected void OrderFormView_ModeChanged(object sender, EventArgs e)
        {
        }

        protected void OrderFormView_ModeChanging(object sender, FormViewModeEventArgs e)
        {

        }

        protected void OrderFormView_ItemInserting(object sender, FormViewInsertEventArgs e)
        {
            
        }

        protected void listViewTransport_ItemCommand(object sender, ListViewCommandEventArgs e)
        {

        }



    }
}