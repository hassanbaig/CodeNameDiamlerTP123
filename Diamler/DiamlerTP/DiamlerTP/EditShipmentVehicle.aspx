<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditShipmentVehicle.aspx.cs" Inherits="DiamlerTP.EditShipmentVehicle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>Edit shipment vehicle</b></h2>                
                <br /><br />
            </asp:TableHeaderCell>            
        </asp:TableHeaderRow>                 

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Shipment Vehicle:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlShipmentVehicle" AutoPostBack="true" runat="server" DataSourceID="SqlDataSourceForShipmentVehicle" DataTextField="NumberPlate" DataValueField="ID" OnSelectedIndexChanged="ddlShipmentVehicle_SelectedIndexChanged"></asp:DropDownList>                                
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
                    <asp:DropDownList ID="ddlShipmentId" runat="server" DataSourceID="SqlDataSourceForShipment" DataTextField="SearchName" DataValueField="ID" ></asp:DropDownList>                                
                </div>
            </asp:TableCell>            
        </asp:TableRow>

     <asp:TableRow CssClass="form-group">            
            <asp:TableCell>                
                <div style="margin:20px;">
                Number Plate:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtNumberPlate" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>
     
     <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"/>
                </div>
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
    
    <asp:SqlDataSource ID="SqlDataSourceForShipmentVehicle" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_shippmentVehicle] Order By [ID] DESC"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForShipment" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Shippment] Order By [ID] DESC"></asp:SqlDataSource>
</asp:Content>
