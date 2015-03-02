<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditAdditionalInfo.aspx.cs" Inherits="DiamlerTP.EditAdditionalInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>Edit additional info</b></h2>                
                <br /><br />
            </asp:TableHeaderCell>
            
        </asp:TableHeaderRow>
        
        <asp:TableRow CssClass="form-group">            
            <asp:TableCell>                
                <div style="margin:20px;">
                Additional Info:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:DropDownList ID="ddlAdditionalInfo" AutoPostBack="true" runat="server" DataSourceID="SqlDataSourceForAdditionalInfo" DataTextField="Shortname" DataValueField="ID" OnSelectedIndexChanged="ddlAdditionalInfo_SelectedIndexChanged"></asp:DropDownList>                                
                </div>
            </asp:TableCell>
        </asp:TableRow>
                 
        <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>                
                <div style="margin:20px;">
                Short Name:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtShortName" runat="server" ></asp:TextBox>
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
                <asp:TextBox ID="txtAdditionalInfo" runat="server" TextMode="MultiLine" ></asp:TextBox>
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

    <asp:SqlDataSource ID="SqlDataSourceForAdditionalInfo" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_AdditionalInformation] ORDER BY [ID] DESC"></asp:SqlDataSource>
</asp:Content>
