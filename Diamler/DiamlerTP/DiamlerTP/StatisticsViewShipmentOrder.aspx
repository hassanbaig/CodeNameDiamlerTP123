<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StatisticsViewShipmentOrder.aspx.cs" Inherits="DiamlerTP.StatisticsViewShipmentOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>View shipment order</b></h2>                
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
                 <asp:DropDownList ID="ddlOrder" runat="server" DataSourceID="SqlDataSourceForOrder" DataTextField="ID" DataValueField="ID" ></asp:DropDownList>                                            
                </div>
            </asp:TableCell>
        </asp:TableRow>

          <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Entry Date:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                <asp:Calendar ID="calEntryDate" runat="server"></asp:Calendar>
                </div>
            </asp:TableCell>
        </asp:TableRow>


        <asp:TableRow CssClass="form-group">            
            <asp:TableCell>
                <div>
                    <asp:Button ID="btnViewReport" runat="server" Text="View Report" OnClick="btnViewReport_Click" />
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <hr/>                
                <div style="color:red; background-color:lightgray;"><b>Shipment Order Report</b></div>
                <hr/>                
            </asp:TableCell>            
        </asp:TableRow>

       <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
               Total Cars:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtTotalCars" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>
        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
               Total Price:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtTotalPrice" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
               Cars in "MTC":
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtMTC" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>
         <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
               Cars in "MTC" Price:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtMTCPrice" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
               Cars in "Marketing Vertrieb":
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtMarketingVertrieb" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>
         <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
               Cars in "Marketing Vertrieb" Price:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtMarketingVertriebPrice" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
               Cars in "W50 Diverse":
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtW50Diverse" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>
        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
               Cars in "W50 Diverse" Price:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtW50DiversePrice" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        </asp:Table>
    <asp:SqlDataSource ID="SqlDataSourceForOrder" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Order] ORDER BY [ID] DESC"></asp:SqlDataSource>
</asp:Content>
