<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TruckMethodEditOrder.aspx.cs" Inherits="DiamlerTP.TruckMethodEditOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>Edit order by truck method</b></h2>                
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
                    <asp:DropDownList ID="ddlOrder" runat="server" AutoPostBack="true" DataSourceID="SqlDataSourceForOrder" DataTextField="ID" DataValueField="ID" OnSelectedIndexChanged="ddlOrder_SelectedIndexChanged"></asp:DropDownList>                                                         
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
                <div>
                <asp:Calendar ID="calEntryDate" runat="server"></asp:Calendar>
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Employee Info:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlEmployeeInfo" runat="server" DataSourceID="SqlDataSourceForEmployeeInfo" DataTextField="LastName" DataValueField="ID" ></asp:DropDownList>                                                   
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Shipping Method:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlShippingMethod" runat="server" DataSourceID="SqlDataSourceForShippingMethod" DataTextField="Name" DataValueField="ID" ></asp:DropDownList>                                                                       
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                No. of Vehicles:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtNoOfVehicles" runat="server"></asp:TextBox>
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
                <div>
                    <asp:DropDownList ID="ddlClient" runat="server" DataSourceID="SqlDataSourceForClient" DataTextField="LName" DataValueField="ID" ></asp:DropDownList>                                                                                           
                </div>
            </asp:TableCell>            
        </asp:TableRow>
        
        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Main Reference:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtMainReference" runat="server"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Reference Info:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtReferenceInfo" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

          <asp:TableRow CssClass="form-group">
            
            <asp:TableCell>
                
                <div style="margin:20px;">
                Order Deadline:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                <asp:Calendar ID="calDeadline" runat="server"></asp:Calendar>
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
                    <asp:DropDownList ID="ddlAdditionalInfo" runat="server" DataSourceID="SqlDataSourceForAdditionalInformation" DataTextField="Shortname" DataValueField="ID" ></asp:DropDownList>                                                                                           
                </div>
            </asp:TableCell>            
        </asp:TableRow>
        
        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div class="form-group" style="margin:20px;">
                TPL Internal Info:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtTPLInternalInfo" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Special Order Requirement:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtSpecialOrderRequirement" runat="server" TextMode="MultiLine"></asp:TextBox>
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

    <asp:SqlDataSource ID="SqlDataSourceForEmployeeInfo" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_EmployeeInfo]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForShippingMethod" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_ShippingMethod]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForClient" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Client]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForAdditionalInformation" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_AdditionalInformation]"></asp:SqlDataSource>
    
    <asp:SqlDataSource ID="SqlDataSourceForOrderAddress" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_OrderAdress] WHERE ([OrderId] = @OrderId)" DeleteCommand="DELETE FROM [T_OrderAdress] WHERE [ID] = @ID" InsertCommand="INSERT INTO [T_OrderAdress] ([LoadAdress], [ContactPerson], [ContactPerson2], [Date], [Type], [Isload], [OrderId]) VALUES (@LoadAdress, @ContactPerson, @ContactPerson2, @Date, @Type, @Isload, @OrderId)" UpdateCommand="UPDATE [T_OrderAdress] SET [LoadAdress] = @LoadAdress, [ContactPerson] = @ContactPerson, [ContactPerson2] = @ContactPerson2, [Date] = @Date, [Type] = @Type, [Isload] = @Isload, [OrderId] = @OrderId WHERE [ID] = @ID">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="LoadAdress" Type="Int64" />
            <asp:Parameter Name="ContactPerson" Type="Int64" />
            <asp:Parameter Name="ContactPerson2" Type="Int64" />
            <asp:Parameter Name="Date" Type="DateTime" />
            <asp:Parameter Name="Type" Type="String" />
            <asp:Parameter Name="Isload" Type="Boolean" />
            <asp:Parameter Name="OrderId" Type="Int32" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlOrder" Name="OrderId" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="LoadAdress" Type="Int64" />
            <asp:Parameter Name="ContactPerson" Type="Int64" />
            <asp:Parameter Name="ContactPerson2" Type="Int64" />
            <asp:Parameter Name="Date" Type="DateTime" />
            <asp:Parameter Name="Type" Type="String" />
            <asp:Parameter Name="Isload" Type="Boolean" />
            <asp:Parameter Name="OrderId" Type="Int32" />
            <asp:Parameter Name="ID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForOrderDetails" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_OrderDetails] WHERE ([OrderID] = @OrderID)" DeleteCommand="DELETE FROM [T_OrderDetails] WHERE [ID] = @ID" InsertCommand="INSERT INTO [T_OrderDetails] ([OrderID], [VehicleType], [DesignatedFinasNo], [NumberPlate], [ChassisNo], [Receipt], [Length], [Width], [Height], [Weight], [Price], [TruckType], [TransportWay], [ModelYear], [Capacity], [TruckNumberPlate], [TruckDriver], [Shipping], [Carnet]) VALUES (@OrderID, @VehicleType, @DesignatedFinasNo, @NumberPlate, @ChassisNo, @Receipt, @Length, @Width, @Height, @Weight, @Price, @TruckType, @TransportWay, @ModelYear, @Capacity, @TruckNumberPlate, @TruckDriver, @Shipping, @Carnet)" UpdateCommand="UPDATE [T_OrderDetails] SET [OrderID] = @OrderID, [VehicleType] = @VehicleType, [DesignatedFinasNo] = @DesignatedFinasNo, [NumberPlate] = @NumberPlate, [ChassisNo] = @ChassisNo, [Receipt] = @Receipt, [Length] = @Length, [Width] = @Width, [Height] = @Height, [Weight] = @Weight, [Price] = @Price, [TruckType] = @TruckType, [TransportWay] = @TransportWay, [ModelYear] = @ModelYear, [Capacity] = @Capacity, [TruckNumberPlate] = @TruckNumberPlate, [TruckDriver] = @TruckDriver, [Shipping] = @Shipping, [Carnet] = @Carnet WHERE [ID] = @ID">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="OrderID" Type="Int64" />
            <asp:Parameter Name="VehicleType" Type="String" />
            <asp:Parameter Name="DesignatedFinasNo" Type="String" />
            <asp:Parameter Name="NumberPlate" Type="String" />
            <asp:Parameter Name="ChassisNo" Type="String" />
            <asp:Parameter Name="Receipt" Type="String" />
            <asp:Parameter Name="Length" Type="String" />
            <asp:Parameter Name="Width" Type="String" />
            <asp:Parameter Name="Height" Type="String" />
            <asp:Parameter Name="Weight" Type="String" />
            <asp:Parameter Name="Price" Type="String" />
            <asp:Parameter Name="TruckType" Type="String" />
            <asp:Parameter Name="TransportWay" Type="Int32" />
            <asp:Parameter Name="ModelYear" Type="String" />
            <asp:Parameter Name="Capacity" Type="String" />
            <asp:Parameter Name="TruckNumberPlate" Type="String" />
            <asp:Parameter Name="TruckDriver" Type="String" />
            <asp:Parameter Name="Shipping" Type="String" />
            <asp:Parameter Name="Carnet" Type="String" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlOrder" Name="OrderID" PropertyName="SelectedValue" Type="Int64" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="OrderID" Type="Int64" />
            <asp:Parameter Name="VehicleType" Type="String" />
            <asp:Parameter Name="DesignatedFinasNo" Type="String" />
            <asp:Parameter Name="NumberPlate" Type="String" />
            <asp:Parameter Name="ChassisNo" Type="String" />
            <asp:Parameter Name="Receipt" Type="String" />
            <asp:Parameter Name="Length" Type="String" />
            <asp:Parameter Name="Width" Type="String" />
            <asp:Parameter Name="Height" Type="String" />
            <asp:Parameter Name="Weight" Type="String" />
            <asp:Parameter Name="Price" Type="String" />
            <asp:Parameter Name="TruckType" Type="String" />
            <asp:Parameter Name="TransportWay" Type="Int32" />
            <asp:Parameter Name="ModelYear" Type="String" />
            <asp:Parameter Name="Capacity" Type="String" />
            <asp:Parameter Name="TruckNumberPlate" Type="String" />
            <asp:Parameter Name="TruckDriver" Type="String" />
            <asp:Parameter Name="Shipping" Type="String" />
            <asp:Parameter Name="Carnet" Type="String" />
            <asp:Parameter Name="ID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>

    <div style="color:red; background-color:lightgray;"><b>Order Address</b></div>
    <asp:Panel ID="pnlOrderAddress" ScrollBars="Horizontal" runat="server">
    <asp:GridView id="gvOrderAddress" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSourceForOrderAddress">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="LoadAdress" HeaderText="LoadAdress" SortExpression="LoadAdress" />
            <asp:BoundField DataField="ContactPerson" HeaderText="ContactPerson" SortExpression="ContactPerson" />
            <asp:BoundField DataField="ContactPerson2" HeaderText="ContactPerson2" SortExpression="ContactPerson2" />
            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
            <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
            <asp:CheckBoxField DataField="Isload" HeaderText="Isload" SortExpression="Isload" />
            <asp:BoundField DataField="OrderId" HeaderText="OrderId" SortExpression="OrderId" />
        </Columns>
    </asp:GridView>          
        </asp:Panel>
    <div style="color:red; background-color:lightgray;"><b>Order Details</b></div>
    <asp:Panel ID="pnlOrderDetails" ScrollBars="Horizontal" runat="server">
    <asp:GridView id="gvOrderDetails" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSourceForOrderDetails">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="OrderID" HeaderText="OrderID" SortExpression="OrderID" />
            <asp:BoundField DataField="VehicleType" HeaderText="VehicleType" SortExpression="VehicleType" />
            <asp:BoundField DataField="DesignatedFinasNo" HeaderText="DesignatedFinasNo" SortExpression="DesignatedFinasNo" />
            <asp:BoundField DataField="NumberPlate" HeaderText="NumberPlate" SortExpression="NumberPlate" />
            <asp:BoundField DataField="ChassisNo" HeaderText="ChassisNo" SortExpression="ChassisNo" />
            <asp:BoundField DataField="Receipt" HeaderText="Receipt" SortExpression="Receipt" />
            <asp:BoundField DataField="Length" HeaderText="Length" SortExpression="Length" />
            <asp:BoundField DataField="Width" HeaderText="Width" SortExpression="Width" />
            <asp:BoundField DataField="Height" HeaderText="Height" SortExpression="Height" />
            <asp:BoundField DataField="Weight" HeaderText="Weight" SortExpression="Weight" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="TruckType" HeaderText="TruckType" SortExpression="TruckType" />
            <asp:BoundField DataField="TransportWay" HeaderText="TransportWay" SortExpression="TransportWay" />
            <asp:BoundField DataField="ModelYear" HeaderText="ModelYear" SortExpression="ModelYear" />
            <asp:BoundField DataField="Capacity" HeaderText="Capacity" SortExpression="Capacity" />
            <asp:BoundField DataField="TruckNumberPlate" HeaderText="TruckNumberPlate" SortExpression="TruckNumberPlate" />
            <asp:BoundField DataField="TruckDriver" HeaderText="TruckDriver" SortExpression="TruckDriver" />
            <asp:BoundField DataField="Shipping" HeaderText="Shipping" SortExpression="Shipping" />
            <asp:BoundField DataField="Carnet" HeaderText="Carnet" SortExpression="Carnet" />
        </Columns>
    </asp:GridView>          
        </asp:Panel>
</asp:Content>   