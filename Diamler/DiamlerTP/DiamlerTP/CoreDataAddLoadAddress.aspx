<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CoreDataAddLoadAddress.aspx.cs" Inherits="DiamlerTP.CoreDataAddLoadAddress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>Add load address</b></h2>                
                <br /><br />
            </asp:TableHeaderCell>
            
        </asp:TableHeaderRow>                
         
        <asp:TableRow CssClass="form-group">            
            <asp:TableCell>                
                <div style="margin:20px;">
                Search Name:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:TextBox ID="txtSearchName" runat="server" ></asp:TextBox>
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
                <asp:TextBox ID="txtName1" runat="server" ></asp:TextBox>
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
                <asp:TextBox ID="txtName2" runat="server" ></asp:TextBox>
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
                <asp:TextBox ID="txtStreet1" runat="server" ></asp:TextBox>
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
                <asp:TextBox ID="txtStreet2" runat="server" ></asp:TextBox>
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
                <asp:TextBox ID="txtPostCode" runat="server" ></asp:TextBox>
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
                <asp:TextBox ID="txtCity" runat="server" ></asp:TextBox>
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
                <asp:TextBox ID="txtRegion" runat="server" ></asp:TextBox>
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
                <hr/>                
                <div style="color:red; background-color:lightgray;"><b>Contact Person</b></div>
                <hr/>                
            </asp:TableCell>            
        </asp:TableRow>

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

    <asp:SqlDataSource ID="SqlDataSourceForCountry" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_CountryList]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForTitle" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Title]"></asp:SqlDataSource>
</asp:Content>
