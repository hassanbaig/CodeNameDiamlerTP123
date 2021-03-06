﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TruckMethodAddInsurance.aspx.cs" Inherits="DiamlerTP.TruckMethodAddInsurance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>Add insurance by truck method</b></h2>                
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
                Insurance:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
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
                <div>
                    <asp:Button ID="Button4" runat="server" Text="Insured" />
                </div>
            </asp:TableCell>   
             <asp:TableCell>
                <div>
                    <asp:Button ID="Button2" runat="server" Text="View Vehicle List" />
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
</asp:Content>
