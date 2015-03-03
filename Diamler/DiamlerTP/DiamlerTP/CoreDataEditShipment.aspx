<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CoreDataEditShipment.aspx.cs" Inherits="DiamlerTP.CoreDataEditShipment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>Edit shipment</b></h2>                
                <br /><br />
            </asp:TableHeaderCell>
            
        </asp:TableHeaderRow>                          
        
        <asp:TableRow CssClass="form-group">            
            <asp:TableCell>                
                <div style="margin:20px;">
                Shipment:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlShipment" AutoPostBack="true" runat="server" DataSourceID="SqlDataSourceForShipment" DataTextField="SearchName" DataValueField="ID" OnSelectedIndexChanged="ddlShipment_SelectedIndexChanged"></asp:DropDownList>                                                                    
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>                
                <div style="margin:20px;">
                Search Name:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtSearchName" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Name 1:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtName1" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Name 2:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtName2" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Street 1:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtStreet1" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Street 2:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtStreet2" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Post Code:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                City:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Region:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtRegion" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Country:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlCountry" runat="server" DataSourceID="SqlDataSourceForCountry" DataTextField="Countries" DataValueField="Countries" ></asp:DropDownList>                                                                    
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Contact Person:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlContactPerson" runat="server" DataSourceID="SqlDataSourceForContactPerson" DataTextField="FirstName" DataValueField="ID" ></asp:DropDownList>                                                    
                </div>
            </asp:TableCell>
        </asp:TableRow>

         <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Main Tel:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtMainTel" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

         <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Main Fax:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtMainFax" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

         <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Main Email:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtMainEmail" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Location:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>


         <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Flight No:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtFlightNo" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

         <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Function:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:DropDownList ID="ddlFunction" runat="server"></asp:DropDownList>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Open Transport:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtOpenTransport" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Close Transport:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtCloseTransport" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Operational Area:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtOperationalArea" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>
        
        <asp:TableRow CssClass="form-group">            
            <asp:TableCell>                
                <div style="margin:20px;">
                Remarks:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtRemarks" runat="server" TextMode="MultiLine"></asp:TextBox>
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
    <asp:SqlDataSource ID="SqlDataSourceForCountry" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_CountryList]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForShipment" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Shippment] ORDER BY [ID] DESC"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForContactPerson" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_ContactPerson]"></asp:SqlDataSource>
</asp:Content>
