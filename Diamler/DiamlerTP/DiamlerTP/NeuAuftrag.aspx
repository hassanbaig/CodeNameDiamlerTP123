<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="NeuAuftrag.aspx.cs" Inherits="DiamlerTP.AuftragDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3><%: Title %></h3>
    <div class="row">
        <div class="col-sm-2">
        </div>
        <div class="col-sm-8 form-horizontal">
            <div class="form-group">
                <label class="col-sm-3 control-label">Auswahl Auftrag:</label>
                <div class="col-sm-5">
                    <asp:DropDownList ID="DDLOrder" runat="server" CssClass="form-control" DataTextField="ID" AppendDataBoundItems="True">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Anrede:</label>
                <div class="col-sm-5">
                    <asp:DropDownList ID="DDLAnrede" runat="server" CssClass="form-control" DataTextField="ID" AppendDataBoundItems="True">
                    </asp:DropDownList>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Name:</label>
                <div class="col-sm-5">
                    <asp:TextBox runat="server" ID="txtName" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Vorname:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtVorname" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Tel:</label>
                <div class="col-sm-5">
                    <asp:TextBox runat="server" ID="txtTel" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Handy:</label>
                <div class="col-sm-5">
                    <asp:TextBox runat="server" ID="txtMobile" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Typ:</label>
                <div class="col-sm-5">
                    <asp:DropDownList ID="DDLTyp" runat="server" CssClass="form-control" DataValueField="Id" DataTextField="Typ" AppendDataBoundItems="True"></asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Firma:</label>
                <div class="col-sm-5">
                    <div class="input-group">
                        <asp:DropDownList ID="DDLFirma" runat="server" CssClass="form-control" DataValueField="ID" DataTextField="Company"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Abteilung:</label>
                <div class="col-sm-5">
                    <asp:DropDownList ID="DDLAbteilung" runat="server" CssClass="form-control" DataValueField="Id" DataTextField="Department"></asp:DropDownList>

                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Werksverrechnung:</label>
                <div class="col-sm-5">
                    <asp:DropDownList ID="DDLWerksverrechnung" runat="server" CssClass="form-control" DataValueField="Id" DataTextField="Industrialplant" AppendDataBoundItems="True"></asp:DropDownList>
                </div>
            </div>

        </div>
        <div class="form-group">
            <label class="col-sm-3 control-label"></label>
            <div class="col-sm-5">
                <asp:Button ID="btnauftrag" runat="server" CssClass="btn btn-lg btn-primary" Text="Speichern" OnClick="btnSave_Click2" />
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-3 control-label"></label>
            <div class="col-sm-5">
                <asp:Label ID="lblsuccess" runat="server" Text="erfolgreich " Visible="false" ForeColor="Green"></asp:Label>
            </div>
        </div>

    </div>
</asp:Content>
