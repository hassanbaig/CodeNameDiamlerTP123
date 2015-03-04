<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddClient.aspx.cs" Inherits="DiamlerTP.AddClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>Add Client</b></h2>                
                <br /><br />
            </asp:TableHeaderCell>
            
        </asp:TableHeaderRow>
                 
        <asp:TableRow CssClass="form-group">            
            <asp:TableCell>                
                <div style="margin:20px;">
                Title:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:DropDownList ID="ddlTitle" runat="server" DataSourceID="SqlDataSourceForTitle" DataTextField="Name" DataValueField="ID" ></asp:DropDownList>                                
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">            
            <asp:TableCell>                
                <div style="margin:20px;">
                First Name:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">            
            <asp:TableCell>                
                <div style="margin:20px;">
                Last Name:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>
         <asp:TableRow CssClass="form-group">            
            <asp:TableCell>                
                <div style="margin:20px;">
                Department:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlDepartment" runat="server"></asp:DropDownList>                                
                </div>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow CssClass="form-group">            
            <asp:TableCell>                
                <div style="margin:20px;">
                Tel:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>
       <asp:TableRow CssClass="form-group">            
            <asp:TableCell>                
                <div style="margin:20px;">
                Mobile:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>
        </asp:TableRow>
              <asp:TableRow CssClass="form-group">            
            <asp:TableCell>                
                <div style="margin:20px;">
                Type:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:DropDownList ID="ddlType" runat="server"></asp:DropDownList>
                </div>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow CssClass="form-group">            
            <asp:TableCell>                
                <div style="margin:20px;">
                Industrial Plant:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlIndustrialPlant" runat="server"></asp:DropDownList>                    
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
        
    <asp:SqlDataSource ID="SqlDataSourceForTitle" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Title]"></asp:SqlDataSource>
</asp:Content>
