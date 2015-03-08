<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TruckMethodViewCarrageNoticeReturnTransport.aspx.cs" Inherits="DiamlerTP.TruckMethodViewCarrageNoticeReturnTransport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>View carrage notice return transport by truck method</b></h2>                
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
                 <asp:DropDownList ID="ddlOrder" AutoPostBack="true" runat="server" DataSourceID="SqlDataSourceForOrder" DataTextField="ID" DataValueField="ID" OnSelectedIndexChanged="ddlOrder_SelectedIndexChanged" ></asp:DropDownList>                                            
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Shipment:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlShipment" DataSourceID="SqlDataSourceShipment" DataTextField="SearchName" DataValueField="ID" runat="server"></asp:DropDownList>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

         <asp:TableRow CssClass="form-group">            
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Button ID="btnCMROpen" runat="server" Text="CMR Open" OnClick="btnCMROpen_Click"/>
                </div>
            </asp:TableCell>                        
        </asp:TableRow>     

      <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <hr/>                
                <div style="color:red; background-color:lightgray;"><b>Vehicle List</b></div>
                <hr/>                
            </asp:TableCell>            
        </asp:TableRow>
        
        </asp:Table>

    <asp:GridView ID="gvVehicleList" runat="server"></asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourceShipment" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Shippment] Order By [ID] DESC"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForOrder" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Order] Order By [ID] DESC"></asp:SqlDataSource>
</asp:Content>
