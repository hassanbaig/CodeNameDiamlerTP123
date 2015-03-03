<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TruckMethodEditShipmentSelection.aspx.cs" Inherits="DiamlerTP.TruckMethodEditShipmentSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>Edit shipment selection by truck method</b></h2>                
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
                 <asp:DropDownList ID="ddlOrder" AutoPostBack="true" runat="server" DataSourceID="SqlDataSourceForOrder" DataTextField="ID" DataValueField="ID" OnSelectedIndexChanged="ddlOrder_SelectedIndexChanged"></asp:DropDownList>                                            
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
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
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
  
        
    <asp:SqlDataSource ID="SqlDataSourceForOrder" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Order] Order By [ID] DESC"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForShipment" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Shippment] Order By [ID] DESC"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForShipmentContactPerson" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_ShippmentContactPerson] Order By [ID] DESC"></asp:SqlDataSource>    

</asp:Content>
