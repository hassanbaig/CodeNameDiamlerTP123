<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AirAndShipMethodEditShipData.aspx.cs" Inherits="DiamlerTP.AirAndShipMethodEditShipData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>Edit shipment data by air and truck method</b></h2>                
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
                <div style="margin:20px;">
                 <asp:DropDownList ID="ddlOrder" AutoPostBack="true" runat="server" DataSourceID="SqlDataSourceForOrder" DataTextField="ID" DataValueField="ID" OnSelectedIndexChanged="ddlOrder_SelectedIndexChanged" ></asp:DropDownList>                                            
                </div>
            </asp:TableCell>
        </asp:TableRow>
             
        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <hr/>                
                <div style="color:red; background-color:lightgray;"><b>Air Ship Details</b></div>
                <hr/>                
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                MBS No:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:TextBox ID="txtMBSNo" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

         <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Flight Date:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Calendar ID="calFlightDate" runat="server"></asp:Calendar>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Flight:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:TextBox ID="txtFlight" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                AWB:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:TextBox ID="txtAWB" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

                <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Shipper:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:TextBox ID="txtShipper" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

                <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Export Kind:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:TextBox ID="txtExportKind" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

                <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                TIB Carnet No:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:TextBox ID="txtTIBCarnetNo" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Goods Kind:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:TextBox ID="txtGoodsKind" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Chassis No:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:TextBox ID="txtChassisNo" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Shipment From Sifi:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Calendar ID="calShipmentFromSifi" runat="server"></asp:Calendar>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

         <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Arrival:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Calendar ID="calArrival" runat="server"></asp:Calendar>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

          <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
               Destination:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:TextBox ID="txtDestination" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>
        

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Return Date:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                     <asp:TextBox ID="txtReturnDate" runat="server"></asp:TextBox>
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
                <div style="margin:20px;">
                    <asp:DropDownList ID="ddlClient" runat="server" DataSourceID="SqlDataSourceForClient" DataTextField="FName" DataValueField="ID" ></asp:DropDownList>                                            
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Custom Clearance:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:TextBox ID="txtCustomClearance" runat="server"></asp:TextBox>
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


    <asp:SqlDataSource ID="SqlDataSourceForOrder" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Order] Order By [ID] DESC"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForLoadAddress" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_LoadAdress]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForClient" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Client]"></asp:SqlDataSource>
</asp:Content>
