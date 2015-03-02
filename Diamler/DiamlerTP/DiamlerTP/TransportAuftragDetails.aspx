<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TransportAuftragDetails.aspx.cs" Inherits="DiamlerTP.TransportAuftragDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3><%: Title %></h3>
    <div class="alert alert-danger" id="divAlerts" runat="server">
    </div>
    <div class="row">
        <div class="col-sm-10 form-horizontal">
            <asp:FormView runat="server"
                ID="OrderFormView"
                DataKeyNames="Id"
                DefaultMode="Insert"
                OnPreRender="OrderDetailsView_PreRender"
                RenderOuterTable="true"
                OnItemCommand="OrderFormView_ItemCommand"
                OnModeChanging="OrderFormView_ModeChanging"
                OnItemInserting="OrderFormView_ItemInserting">
                <ItemTemplate>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Auswahl Auftrag:</label>
                        <div class="col-sm-7">
                            <asp:DropDownList ID="ddlOrder" runat="server" CssClass="form-control" AutoPostBack="True" DataTextField="Id" DataValueField="Id" AppendDataBoundItems="True" OnSelectedIndexChanged="ddlOrder_SelectedIndexChanged">
                                <asp:ListItem Text="(NEW)" Value="0" />
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Sachbearbeiter:</label>
                        <div class="col-sm-7">
                            <asp:Label ID="lblEmplyee" runat="server" Text='<%# Eval("EmployeeInfoName") %>'></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Versandart:</label>
                        <div class="col-sm-7">
                            <asp:Label ID="lblTransport" runat="server" Text='<%# Eval("ShippingMethodName") %>'></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Anzahl Fzg:</label>
                        <div class="col-sm-7">
                            <asp:Label ID="lblNoOfVehicles" runat="server" Text='<%# Eval("VechicleNo") %>'></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Auftraggeber:</label>
                        <div class="col-sm-7">
                            <asp:Label ID="lblClient" runat="server" Text='<%# Eval("ClientName") %>'></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Haupkontierung:</label>
                        <div class="col-sm-7">
                            <asp:Label ID="lblMainReceipt" runat="server" Text='<%# Eval("MainReceipt") %>'></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">KontierungInfo:</label>
                        <div class="col-sm-7">
                            <asp:Label ID="lblReceiptInfo" runat="server" Text='<%# Eval("ReceiptInfo") %>'></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Termin für Angebot:</label>
                        <div class="col-sm-7">
                            <asp:Label ID="lblTender" runat="server" Text='<%# Eval("Tender") %>'></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Zuzsatzinformationen</label>
                        <div class="col-sm-7">
                            <asp:Label ID="lblAdditionalInformatio" runat="server" Text='<%# Eval("AdditionalInformationName") %>'></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Besonderheiten fü r diesen Auftrag:</label>
                        <div class="col-sm-7">
                            <asp:Label ID="lblOrderSpeciality" runat="server" Text='<%# Eval("SpecialInstruction") %>'></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">TPL Interne Info:</label>
                        <div class="col-sm-7">
                            <asp:Label ID="lblInternalInfo" runat="server" Text='<%# Eval("InternalInfo") %>'></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label"></label>
                        <div class="col-sm-7">
                            <asp:LinkButton ID="lnkEdit" runat="server" CommandName="Edit" CssClass="btn btn-default">Edit</asp:LinkButton>
                        </div>
                    </div>
                </ItemTemplate>
                <EditItemTemplate>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Auswahl Auftrag:</label>
                        <div class="col-sm-7">
                            <asp:Label ID="EditID" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Sachbearbeiter:</label>
                        <div class="col-sm-7">
                            <asp:DropDownList ID="DDLEmployeeInfo" runat="server" CssClass="form-control" DataValueField="ID" DataTextField="LastName" AppendDataBoundItems="True"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="EmployeeRequireField" runat="server" ErrorMessage="Employee Information is Required" ControlToValidate="DDLEmployeeInfo" Display="Dynamic" ValidationGroup="OrderGroup"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Versandart:</label>
                        <div class="col-sm-7">
                            <asp:DropDownList ID="ddlTransportType" runat="server" CssClass="form-control" DataValueField="Id" DataTextField="Name" AppendDataBoundItems="True"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="TransportTypeRequiredField" runat="server" ErrorMessage="Versandart is required" ControlToValidate="ddlTransportType" Display="Dynamic" ValidationGroup="OrderGroup"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Anzahl Fzg:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="txtNoOfVehicle" runat="server" CssClass="form-control" Text='<%# Eval("VechicleNo") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ID="NoOfVehicleRequiredField" runat="server" ErrorMessage="Anzahl Fzg is required" ControlToValidate="txtNoOfVehicle" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidatorNoOFVehicle" runat="server" ErrorMessage="Should be in Between 1 to 30" ControlToValidate="txtNoOfVehicle" MaximumValue="30" MinimumValue="0" Display="Dynamic" Type="Integer" ValidationGroup="OrderGroup"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Auftraggeber:</label>
                        <div class="col-sm-7">
                            <div class="input-group">
                                <asp:DropDownList ID="ddlClient" runat="server" CssClass="form-control" DataValueField="Id" DataTextField="FName" AppendDataBoundItems="True"></asp:DropDownList>
                                <span class="input-group-btn">
                                    <button class="btn btn-default" type="button">
                                        <span class="glyphicon glyphicon-plus"></span>
                                    </button>
                                </span>
                            </div>
                            <asp:RequiredFieldValidator ID="ddlClientRequiredField" runat="server" ErrorMessage="Auftraggeber is required" ControlToValidate="ddlClient" Display="Dynamic" ValidationGroup="OrderGroup"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Haupkontierung:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="txtAssignment" runat="server" CssClass="form-control" Text='<%# Eval("MainReceipt") %>'></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">KontierungInfo:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="txtAssignmentInfo" runat="server" CssClass="form-control" Text='<%# Eval("ReceiptInfo") %>'></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Termin für Angebot:</label>
                        <div class="col-sm-7">
                            <div class="input-group">
                                <asp:TextBox ID="txtAppointOffer" runat="server" CssClass="form-control" TextMode="DateTime" Text='<%# Eval("Tender") %>'></asp:TextBox>
                                <span class="input-group-btn">
                                    <button class="btn btn-default" type="button">
                                        <span class="glyphicon glyphicon-calendar"></span>
                                    </button>
                                </span>
                            </div>
                            <asp:RequiredFieldValidator ID="AppointOfferRequiredField" runat="server" ErrorMessage="Termin für Angebot is required" ControlToValidate="txtAppointOffer" Display="Dynamic" ValidationGroup="OrderGroup"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Zuzsatzinformationen:</label>
                        <div class="col-sm-7">
                            <div class="input-group">
                                <asp:DropDownList ID="ddlAddionalInformation" runat="server" CssClass="form-control" DataValueField="Id" DataTextField="Shortname" AppendDataBoundItems="True" Display="Dynamic" ValidationGroup="OrderGroup"></asp:DropDownList>
                                <span class="input-group-btn">
                                    <button class="btn btn-default" type="button">
                                        <span class="glyphicon glyphicon-plus"></span>
                                    </button>
                                </span>
                            </div>
                            <asp:RequiredFieldValidator ID="AdditionalInformationRequiredField" runat="server" ErrorMessage="Zuzsatzinformationen is required" ControlToValidate="txtAppointOffer" Display="Dynamic" ValidationGroup="OrderGroup"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Besonderheiten fü r diesen Auftrag:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="txtOrderSpeciality" runat="server" CssClass="form-control" TextMode="MultiLine" Text='<%# Eval("SpecialInstruction") %>'></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">TPL Interne Info:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="txtInternalInfo" runat="server" CssClass="form-control" TextMode="MultiLine" Text='<%# Eval("InternalInfo") %>'></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label"></label>
                        <div class="col-sm-7">
                            <asp:LinkButton ID="lnkEditSave" runat="server" CssClass="btn btn-default" CommandName="Update" ValidationGroup="OrderGroup">Update</asp:LinkButton>
                            <asp:LinkButton ID="lnkCancel" runat="server" CssClass="btn btn-default" CommandName="Cancel">Cancel</asp:LinkButton>
                        </div>
                    </div>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Auswahl Auftrag:</label>
                        <div class="col-sm-7">
                            <asp:DropDownList ID="ddlOrder" runat="server" CssClass="form-control" AutoPostBack="True" DataTextField="Id" DataValueField="Id" AppendDataBoundItems="True" OnSelectedIndexChanged="ddlOrder_SelectedIndexChanged">
                                <asp:ListItem Text="(NEW)" Selected="True" />
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Sachbearbeiter:</label>
                        <div class="col-sm-7">
                            <asp:DropDownList ID="DDLEmployeeInfo" runat="server" CssClass="form-control" DataValueField="ID" DataTextField="LastName" AppendDataBoundItems="True"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="EmployeeRequireField" runat="server" ErrorMessage="Employee Information is Required" ControlToValidate="DDLEmployeeInfo" Display="Dynamic" ValidationGroup="OrderGroup"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Versandart:</label>
                        <div class="col-sm-7">
                            <asp:DropDownList ID="ddlTransportType" runat="server" CssClass="form-control" DataValueField="Id" DataTextField="Name" AppendDataBoundItems="True"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="TransportTypeRequiredField" runat="server" ErrorMessage="Versandart is required" ControlToValidate="ddlTransportType" Display="Dynamic" ValidationGroup="OrderGroup"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Anzahl Fzg:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="txtNoOfVehicle" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RangeValidator ID="RangeValidatorNoOFVehicle" runat="server" ErrorMessage="Should be in Between 1 to 30" ControlToValidate="txtNoOfVehicle" MaximumValue="30" MinimumValue="0" Display="Dynamic" Type="Integer" ValidationGroup="OrderGroup"></asp:RangeValidator>
                            <asp:RequiredFieldValidator ID="NoOfVehicleRequiredField" runat="server" ErrorMessage="Anzahl Fzg is required" ControlToValidate="txtNoOfVehicle" Display="Dynamic" ValidationGroup="OrderGroup"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Auftraggeber:</label>
                        <div class="col-sm-7">
                            <div class="input-group">
                                <asp:DropDownList ID="ddlClient" runat="server" CssClass="form-control" DataValueField="Id" DataTextField="FName" AppendDataBoundItems="True"></asp:DropDownList>
                                <span class="input-group-btn">
                                    <button class="btn btn-default" type="button">
                                        <span class="glyphicon glyphicon-plus"></span>
                                    </button>
                                </span>
                            </div>
                            <asp:RequiredFieldValidator ID="ddlClientRequiredField" runat="server" ErrorMessage="Auftraggeber is required" ControlToValidate="ddlClient" Display="Dynamic" ValidationGroup="OrderGroup"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Haupkontierung:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="txtAssignment" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">KontierungInfo:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="txtAssignmentInfo" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Termin für Angebot:</label>
                        <div class="col-sm-7">
                            <div class="input-group">
                                <asp:TextBox ID="txtAppointOffer" runat="server" CssClass="form-control" TextMode="DateTime"></asp:TextBox>
                                <span class="input-group-btn">
                                    <button class="btn btn-default" type="button">
                                        <span class="glyphicon glyphicon-calendar"></span>
                                    </button>
                                </span>
                            </div>
                            <asp:RequiredFieldValidator ID="AppointOfferRequiredField" runat="server" ErrorMessage="Termin für Angebot is required" ControlToValidate="txtAppointOffer" Display="Dynamic" ValidationGroup="OrderGroup"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Zuzsatzinformationen:</label>
                        <div class="col-sm-7">
                            <div class="input-group">
                                <asp:DropDownList ID="ddlAddionalInformation" runat="server" CssClass="form-control" DataValueField="Id" DataTextField="Shortname" AppendDataBoundItems="True"></asp:DropDownList>
                                <span class="input-group-btn">
                                    <button class="btn btn-default" type="button">
                                        <span class="glyphicon glyphicon-plus"></span>
                                    </button>
                                </span>
                            </div>
                            <asp:RequiredFieldValidator ID="AdditionalInformationRequiredField" runat="server" ErrorMessage="Zuzsatzinformationen is required" ControlToValidate="txtAppointOffer" Display="Dynamic" ValidationGroup="OrderGroup"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">Besonderheiten fü r diesen Auftrag:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="txtOrderSpeciality" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label">TPL Interne Info:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="txtInternalInfo" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-5 control-label"></label>
                        <div class="col-sm-7">
                            <asp:LinkButton ID="lnkInsertSave" runat="server" CommandName="New" CssClass="btn btn-default" ValidationGroup="OrderGroup">Save</asp:LinkButton>
                        </div>
                    </div>
                </InsertItemTemplate>
            </asp:FormView>
        </div>
        <div class="col-sm-2">
        </div>
    </div>
    <div class="row">
        <asp:GridView ID="gridViewTransport" runat="server" AutoGenerateColumns="False" CssClass="table table-striped">
            <Columns>
                <asp:TemplateField HeaderText="Datum und Uhrzeit">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddlTransportType" runat="server">
                            <asp:ListItem Text="HinsTransport" Value="HT"></asp:ListItem>
                            <asp:ListItem Text="RuckTransport" Value="RT"></asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <%# (Eval("Type").ToString() == "RT") ? "RuckTransport" :  "HinsTransport" %>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList ID="ddlTransportType" runat="server">
                            <asp:ListItem Text="HinsTransport" Value="HT"></asp:ListItem>
                            <asp:ListItem Text="RuckTransport" Value="RT"></asp:ListItem>
                        </asp:DropDownList>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Beladung/Entldung">
                    <EditItemTemplate>
                        <asp:CheckBox ID="chkLoad" runat="server" CssClass="control-label" Text="Beladung" Checked='<%# Bind("isload") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <%# (bool) Eval("isload") ? "Beladung" : "Entldung" %>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:CheckBox ID="chkLoad" runat="server" CssClass="control-label" Text="Beladung" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Datum und Uhrzeit">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtDateTime" CssClass="form-control" runat="server" Text='<%# Bind("DateTime") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <%# Eval("DateTime") %>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtDateTime" CssClass="form-control" runat="server"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Adresse">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddlAddress" CssClass="form-control" runat="server">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <%# Eval("Address") %>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList ID="ddlAddress" CssClass="form-control" runat="server">
                        </asp:DropDownList>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ansprechpartner 1">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddlContactPerson1" CssClass="form-control" runat="server"></asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <%# Eval("ContactPerson1Name") %>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList ID="ddlContactPerson1" CssClass="form-control" runat="server"></asp:DropDownList>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ansprechpartner 2">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddlContactPerson2" CssClass="form-control" runat="server"></asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <%# Eval("ContactPerson2Name") %>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList ID="ddlContactPerson2" CssClass="form-control" runat="server"></asp:DropDownList>
                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
