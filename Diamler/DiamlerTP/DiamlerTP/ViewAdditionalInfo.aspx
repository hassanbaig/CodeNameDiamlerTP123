<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewAdditionalInfo.aspx.cs" Inherits="DiamlerTP.ViewAdditionalInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>View Additional Info</b></h2>                
                <br /><br />
            </asp:TableHeaderCell>
            
        </asp:TableHeaderRow>
                 
        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>                
                <div style="margin:20px;">
                Short Name:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:DropDownList ID="ddlShortName" AutoPostBack="true" runat="server" DataSourceID="SqlDataSourceForAdditionalInfo" DataTextField="Shortname" DataValueField="AdditionInfo" OnSelectedIndexChanged="ddlShortName_SelectedIndexChanged" ></asp:DropDownList>      
                </div>
            </asp:TableCell>
        </asp:TableRow>
                
        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Additional Info:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtAdditionalInfo" runat="server" TextMode="MultiLine" Height="80" Width="800"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>
                
         <asp:TableFooterRow>
            <asp:TableHeaderCell>

            </asp:TableHeaderCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableFooterRow>
        </asp:Table>     
    <asp:SqlDataSource ID="SqlDataSourceForAdditionalInfo" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_AdditionalInformation]">
    </asp:SqlDataSource>
</asp:Content>
