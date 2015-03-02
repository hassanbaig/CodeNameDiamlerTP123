<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AirAndShipMethodAddOrder.aspx.cs" Inherits="DiamlerTP.AirAndShipMethodAddOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>Add order by air and truck method</b></h2>                
                <br /><br />
            </asp:TableHeaderCell>
            
        </asp:TableHeaderRow>
        
        
      <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Entry Date:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:Calendar ID="calEntryDate" runat="server"></asp:Calendar>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Employee Info:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlEmployeeInfo" runat="server" DataSourceID="SqlDataSourceForEmployeeInfo" DataTextField="LastName" DataValueField="ID" ></asp:DropDownList>                                                   
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Shipping Method:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlShippingMethod" runat="server" DataSourceID="SqlDataSourceForShippingMethod" DataTextField="Name" DataValueField="ID" ></asp:DropDownList>                                                                       
                </div>
            </asp:TableCell>            
        </asp:TableRow>


        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Client:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlClient" runat="server" DataSourceID="SqlDataSourceForClient" DataTextField="LName" DataValueField="ID" ></asp:DropDownList>                                                                                           
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
                    <asp:DropDownList ID="ddlShipment" runat="server" DataSourceID="SqlDataSourceForShipment" DataTextField="Name1" DataValueField="ID" ></asp:DropDownList>                                                                                           
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Main Reference:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtMainReference" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>
                
        
        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                No. of Vehicles:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtNoOfVehicles" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>
        
        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Special Order Requirement:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtSpecialOrderRequirement" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

                
        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div class="form-group" style="margin:20px;">
                TPL Internal Info:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtTPLInternalInfo" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"/>
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

    <asp:SqlDataSource ID="SqlDataSourceForEmployeeInfo" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_EmployeeInfo]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForShippingMethod" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_ShippingMethod]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForClient" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Client]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForShipment" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Shippment]"></asp:SqlDataSource>    
</asp:Content>
