<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TruckMethodAddShipmentSelection.aspx.cs" Inherits="DiamlerTP.TruckMethodAddShipmentSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>Add shipment selection by truck method</b></h2>                
                <br /><br />
            </asp:TableHeaderCell>
            
        </asp:TableHeaderRow>
        
               
        
        <asp:TableRow CssClass="form-group">            
            <asp:TableCell>                
                <div style="margin:20px;">
                Order Id:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                 <asp:DropDownList ID="ddlOrder" runat="server" DataSourceID="SqlDataSourceForOrder" DataTextField="ID" DataValueField="ID" ></asp:DropDownList>                                            
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Shipment Id:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlShipmentId" runat="server" DataSourceID="SqlDataSourceForShipment" DataTextField="SearchName" DataValueField="ID" ></asp:DropDownList>                                
                </div>
            </asp:TableCell>            
        </asp:TableRow>
    
        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Shipment Contact Person:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlShipmentContactPerson" runat="server" DataSourceID="SqlDataSourceForShipmentContactPerson" DataTextField="LastNameSP" DataValueField="ID" ></asp:DropDownList>                                                    
                </div>
            </asp:TableCell>            
        </asp:TableRow>

         <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Destination Price:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtDestinationPrice" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

         <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Return Price:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtReturnPrice" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:Button ID="btnViewOrderDetails" runat="server" Text="View Order Details" OnClick="btnViewOrderDetails_Click"/>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Button ID="btnTransportOrderAddressSame" runat="server" Text="Transport Order Address (Same)" OnClick="btnTransportOrderAddressSame_Click" />
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:Button ID="btnTransportOrderAddressDifferent" runat="server" Text="Transport Order Address (Different)" OnClick="btnTransportOrderAddressDifferent_Click"/>
                </div>
            </asp:TableCell>            
            <asp:TableCell>
                <div>
                    <asp:Button ID="btnTransportOrderAddressOneWay" runat="server" Text="Transport Order Address (One-way)" OnClick="btnTransportOrderAddressOneWay_Click"/>
                </div>
            </asp:TableCell>
        </asp:TableRow>

         <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <hr/>                
                <div style="color:red; background-color:lightgray;"><b>Order Details</b></div>
                <hr/>                
            </asp:TableCell>            
        </asp:TableRow>

        
      <asp:TableFooterRow>
            <asp:TableHeaderCell>

            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:Label ID="lblResponseMessage" runat="server" Text=""></asp:Label>
            </asp:TableCell>
        </asp:TableFooterRow>
            </asp:Table>
    
    <asp:GridView ID="gvOrderDetails" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="OID" HeaderText="OrderID" />
            <asp:BoundField DataField="V" HeaderText="VehicleType" />
            <asp:BoundField DataField="W" HeaderText="TransportWay" />
        </Columns>
    </asp:GridView>
        
    <asp:SqlDataSource ID="SqlDataSourceForOrder" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Order] Order By [ID] DESC"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForShipment" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Shippment] Order By [ID] DESC"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForShipmentContactPerson" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_ShippmentContactPerson] Order By [ID] DESC"></asp:SqlDataSource>    

      <%--<SelectParameters>
            <asp:ControlParameter ControlID="ddlOrder" Name="OrderID" PropertyName="SelectedValue" Type="Int64" />
        </SelectParameters>--%>
</asp:Content>
