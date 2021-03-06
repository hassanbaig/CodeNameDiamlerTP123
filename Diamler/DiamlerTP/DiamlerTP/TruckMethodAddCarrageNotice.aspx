﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TruckMethodAddCarrageNotice.aspx.cs" Inherits="DiamlerTP.TruckMethodAddCarrageNotice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>Add carrage notice by truck method</b></h2>                
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
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
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
                    <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

         <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                    
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Button ID="Button4" runat="server" Text="CMR Open" />
                </div>
            </asp:TableCell>            
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Button ID="Button5" runat="server" Text="Export to excel" />
                </div>
            </asp:TableCell>
        </asp:TableRow>


        
        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Button ID="Button1" runat="server" Text="Add" />
                </div>
            </asp:TableCell> 
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Button ID="Button2" runat="server" Text="View Vehicle List" />
                </div>
            </asp:TableCell>            
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Button ID="Button6" runat="server" Text="View Shipment Contact Person" />
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

         <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <hr/>                
                <div style="color:red; background-color:lightgray;"><b>Shipment Contact Person</b></div>
                <hr/>                
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:GridView ID="GridView2" runat="server"></asp:GridView>
                </div>
            </asp:TableCell>            
        </asp:TableRow>
        
        </asp:Table>
</asp:Content>