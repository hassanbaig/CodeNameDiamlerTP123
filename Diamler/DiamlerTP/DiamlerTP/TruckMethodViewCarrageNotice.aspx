﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TruckMethodViewCarrageNotice.aspx.cs" Inherits="DiamlerTP.TruckMethodViewCarrageNotice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>View carrage notice by truck method</b></h2>                
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
                Shipment:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlShipment" runat="server"></asp:DropDownList>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

         <asp:TableRow CssClass="form-group">            
            <asp:TableCell>
                <div>                   
                    <asp:Button ID="btnCMROpen" runat="server" Text="CMR Open" OnClick="btnCMROpen_Click"/>
                </div>
            </asp:TableCell>                        
        </asp:TableRow>
    
        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Button ID="btnViewVehicleList" runat="server" Text="View Vehicle List"/>
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

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                </div>
            </asp:TableCell>            
        </asp:TableRow>
        </asp:Table>
    <asp:SqlDataSource ID="SqlDataSourceForOrder" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Order] Order By [ID] DESC"></asp:SqlDataSource>
</asp:Content>
