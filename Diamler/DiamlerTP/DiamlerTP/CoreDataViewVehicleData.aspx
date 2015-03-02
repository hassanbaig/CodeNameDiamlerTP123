<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CoreDataViewVehicleData.aspx.cs" Inherits="DiamlerTP.CoreDataViewVehicleData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
             <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>View vehicle data</b></h2>                
                <br /><br />
            </asp:TableHeaderCell>
            
        </asp:TableHeaderRow>
                 
         <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Vehicle Description:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
    <asp:DropDownList ID="ddlDescription" AutoPostBack="true" runat="server" DataSourceID="SqlDataSourceForVehicle" DataTextField="VehicleDescription" DataValueField="VehicleDescription"></asp:DropDownList>                                                
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Model:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
    <asp:DropDownList ID="ddlModel" AutoPostBack="true" runat="server" DataSourceID="SqlDataSourceForVehicle" DataTextField="Model" DataValueField="Model" ></asp:DropDownList>                                                
                </div>
            </asp:TableCell>            
        </asp:TableRow>
               
               <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <hr/>                
                <div style="color:red; background-color:lightgray;"><b>Vehicle Data</b></div>
                <hr/>                
            </asp:TableCell>            
        </asp:TableRow>        
        </asp:Table>

    <asp:GridView ID="gvVehicles" runat="server" AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True" DataSourceID="SqlDataSourceForGrid" DataKeyNames="ID">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="VehicleDescription" HeaderText="VehicleDescription" SortExpression="VehicleDescription" />
            <asp:BoundField DataField="Model" HeaderText="Model" SortExpression="Model" />
            <asp:BoundField DataField="VLength" HeaderText="VLength" SortExpression="VLength" />
            <asp:BoundField DataField="VWidth" HeaderText="VWidth" SortExpression="VWidth" />
            <asp:BoundField DataField="VHeight" HeaderText="VHeight" SortExpression="VHeight" />
            <asp:BoundField DataField="VWeight" HeaderText="VWeight" SortExpression="VWeight" />
            <asp:BoundField DataField="WheelBase" HeaderText="WheelBase" SortExpression="WheelBase" />
            <asp:BoundField DataField="VehicleGroundSpace" HeaderText="VehicleGroundSpace" SortExpression="VehicleGroundSpace" />
            <asp:BoundField DataField="SlopeAngle" HeaderText="SlopeAngle" SortExpression="SlopeAngle" />
            <asp:BoundField DataField="FoldedMirrorWidth" HeaderText="FoldedMirrorWidth" SortExpression="FoldedMirrorWidth" />
            <asp:BoundField DataField="VPrice" HeaderText="VPrice" SortExpression="VPrice" />
        </Columns>
    </asp:GridView>    

    <asp:SqlDataSource ID="SqlDataSourceForGrid" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_VehicleDimension]"
         FilterExpression="(([VehicleDescription] LIKE '%{0}%') OR ([Model] LIKE '%{1}%'))">
                <FilterParameters>
            <asp:ControlParameter ControlID="ddlDescription" Name="VehicleDescription" PropertyName="SelectedValue" Type="String" />
            <asp:ControlParameter ControlID="ddlModel" Name="Model" PropertyName="SelectedValue" Type="String" />
                </FilterParameters>        
    </asp:SqlDataSource>    

    <asp:SqlDataSource ID="SqlDataSourceForVehicle" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_VehicleDimension]"></asp:SqlDataSource>    
</asp:Content>
