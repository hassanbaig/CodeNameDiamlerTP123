<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TruckMethodAddOrder.aspx.cs" Inherits="DiamlerTP.TruckMethodAddOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">   
     <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>                
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                <h2 style="color:cadetblue;"><b>Add order by truck method</b></h2>                
                <br /><br />
            </asp:TableHeaderCell>
            
        </asp:TableHeaderRow>        
        
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
                   <asp:Label ID="lblResponseMessage" runat="server" Text=""></asp:Label>
                </div>                
            </asp:TableCell>                      
        </asp:TableRow>
                       
         <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                   <asp:Button ID="btnSaveOrder" runat="server" Text="Save Order" OnClick="btnSaveOrder_Click"/>
                </div>                
            </asp:TableCell>                      
        </asp:TableRow>


        
        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <hr/>                
                <div style="color:red; background-color:lightgray;"><b>Forward Transport</b></div>
                <hr/>                
            </asp:TableCell>            
        </asp:TableRow>
        
          <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Order Id:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlOrder" runat="server" DataSourceID="SqlDataSourceForOrder" DataTextField="ID" DataValueField="ID" ></asp:DropDownList>                                                                                                                                                                                                                                                          
                </div>                 
            </asp:TableCell>                       
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px; background-color:lightgrey">
                Loading:
                </div>                
            </asp:TableCell>                       
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Date:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:Calendar ID="calFTLoadDate" runat="server"></asp:Calendar>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Time:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtFTLoadTime" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Load Address:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlFTLoadLoadAddress" runat="server" DataSourceID="SqlDataSourceForLoadAddress" DataTextField="SearchName" DataValueField="ID" ></asp:DropDownList>                                                                                                               
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Contact person 1:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlFTLoadContactPerson1" runat="server" DataSourceID="SqlDataSourceForContactPerson" DataTextField="LastName" DataValueField="ID" ></asp:DropDownList>                                                                                                                                   
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Contact person 2:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlFTLoadContactPerson2" runat="server" DataSourceID="SqlDataSourceForContactPerson" DataTextField="LastName" DataValueField="ID" ></asp:DropDownList>                                                                                                                                                       
                </div>
            </asp:TableCell>            
        </asp:TableRow>

<asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px; background-color:lightgrey">
                Unloading:
                </div>                
            </asp:TableCell>                       
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Date:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:Calendar ID="calFTUnloadDate" runat="server"></asp:Calendar>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Time:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtFTUnloadTime" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Unload Address:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlFTUnloadUnloadAddress" runat="server" DataSourceID="SqlDataSourceForLoadAddress" DataTextField="SearchName" DataValueField="ID" ></asp:DropDownList>                                                                                                                                   
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Contact person 1:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlFTUnloadContactPerson1" runat="server" DataSourceID="SqlDataSourceForContactPerson" DataTextField="LastName" DataValueField="ID" ></asp:DropDownList>                                                                                                                                                       
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Contact person 2:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlFTUnloadContactPerson2" runat="server" DataSourceID="SqlDataSourceForContactPerson" DataTextField="LastName" DataValueField="ID" ></asp:DropDownList>                                                                                                                                                                           
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <hr/>                
                <div style="color:red; background-color:lightgray;"><b>Return Transport</b></div>
                <hr/>                
            </asp:TableCell>            
        </asp:TableRow>
        
        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px; background-color:lightgrey">
                Loading:
                </div>                
            </asp:TableCell>                       
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Date:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:Calendar ID="calRTLoadDate" runat="server"></asp:Calendar>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Time:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtRTLoadTime" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Load Address:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlRTLoadLoadAddress" runat="server" DataSourceID="SqlDataSourceForLoadAddress" DataTextField="SearchName" DataValueField="ID" ></asp:DropDownList>                                                                                                                                                       
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Contact person 1:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlRTLoadContactPerson1" runat="server" DataSourceID="SqlDataSourceForContactPerson" DataTextField="LastName" DataValueField="ID" ></asp:DropDownList>                                                                                                                                                                                               
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Contact person 2:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlRTLoadContactPerson2" runat="server" DataSourceID="SqlDataSourceForContactPerson" DataTextField="LastName" DataValueField="ID" ></asp:DropDownList>                                                                                                                                                                                                                  
                </div>
            </asp:TableCell>            
        </asp:TableRow>

<asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px; background-color:lightgrey">
                Unloading:
                </div>                
            </asp:TableCell>                       
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Date:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:Calendar ID="calRTUnloadDate" runat="server"></asp:Calendar>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Time:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtRTUnloadTime" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Unload Address:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlRTUnloadUnloadAddress" runat="server" DataSourceID="SqlDataSourceForLoadAddress" DataTextField="SearchName" DataValueField="ID" ></asp:DropDownList>                                                                                                                                                                           
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Contact person 1:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlRTUnloadContactPerson1" runat="server" DataSourceID="SqlDataSourceForContactPerson" DataTextField="LastName" DataValueField="ID" ></asp:DropDownList>                                                                                                                                                                                                                                      
                </div>
            </asp:TableCell>            
        </asp:TableRow>

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Contact person 2:
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlRTUnloadContactPerson2" runat="server" DataSourceID="SqlDataSourceForContactPerson" DataTextField="LastName" DataValueField="ID" ></asp:DropDownList>                                                                                                                                                                                                                                      
                </div>
            </asp:TableCell>            
        </asp:TableRow>
                 
        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <hr/>                
                <div style="color:red; background-color:lightgray;"><b>Order Details</b></div>
                <hr/>                
            </asp:TableCell>            
        </asp:TableRow>

               <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Designated Finas No:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtDesignatedFinasNo" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

                 <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Number Plate:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtNumberPlate" runat="server"></asp:TextBox>
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
                <div>
                    <asp:TextBox ID="txtChassisNo" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

           <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Length:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtLength" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

           <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Width:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtWidth" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

           <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Height:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtHeight" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

           <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Weight:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtWeight" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

           <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Price:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

           <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Receipt:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtReceipt" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>
                    
           <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Truck Type:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:TextBox ID="txtTruckType" runat="server"></asp:TextBox>
                </div>                 
            </asp:TableCell>
                       
        </asp:TableRow>

           <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                Transport Way:
                </div>                
            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:DropDownList ID="ddlTransportWay" runat="server" DataSourceID="SqlDataSourceForTransportWay" DataTextField="TransportWay" DataValueField="ID" ></asp:DropDownList>                                                                                                                                                                                                                                                          
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

        <asp:TableRow CssClass="form-group">
            <asp:TableCell>
                <div style="margin:20px;">
                    
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Button ID="btnForwardingRequestSame" runat="server" Text="Forwarding Request (Same)" OnClick="btnForwardingRequestSame_Click"/>
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Button ID="btnForwardingRequestDifferent" runat="server" Text="Forwarding Request (Different)" OnClick="btnForwardingRequestDifferent_Click"/>
                </div>
            </asp:TableCell>            
            <asp:TableCell>
                <div style="margin:20px;">
                    <asp:Button ID="btnForwardingRequestOneWay" runat="server" Text="Forwarding Request (One-way)" OnClick="btnForwardingRequestOneWay_Click"/>
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

    <asp:SqlDataSource ID="SqlDataSourceForOrder" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Order] Order By [ID] DESC"></asp:SqlDataSource>

    <asp:SqlDataSource ID="SqlDataSourceForEmployeeInfo" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_EmployeeInfo]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForShippingMethod" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_ShippingMethod]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForClient" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Client]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForAdditionalInformation" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_AdditionalInformation]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForLoadAddress" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_LoadAdress]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForContactPerson" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_ContactPerson]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceForTransportWay" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_TransportWay]"></asp:SqlDataSource>
</asp:Content>
