<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sachbearbeiter1.aspx.cs" Inherits="DiamlerTP.Sachbearbeiter1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3><%: Title %></h3>
    <div class="alert alert-danger" id="divAlert" runat="server">
    </div>
    <div class="row">
        <div class="col-sm-2">
        </div>
        <div class="col-sm-8 form-horizontal">
            <div class="form-group">
                <label class="col-sm-3 control-label">Anrede:</label>
                <div class="col-sm-5">
                    <asp:DropDownList ID="DDLAnrede" runat="server" CssClass="form-control" DataValueField="ID" DataTextField="Name" AppendDataBoundItems="True">
                        <asp:ListItem Text="Select" Value="" />
                    </asp:DropDownList>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Vorname:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtVorname" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Nachname:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtNachname" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Telefon:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtTel" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Mobile:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Email:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Kurzzeichen:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtKurzzeichen" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Aktiv:</label>
                <div class="col-sm-5">
                    <asp:DropDownList ID="DDLAktiv" runat="server" CssClass="form-control" DataValueField="ID" DataTextField="Name"></asp:DropDownList>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label"></label>
                <div class="col-sm-5">
                    <asp:Button ID="btn" runat="server" CssClass="btn btn-lg btn-primary" Text="Speichern" OnClick="btnSave_Click1" />
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-4 control-label"></label>
                <div class="col-sm-5">
                    <asp:Label ID="lblsuccess" runat="server" Text="erfolgreich " Visible="false" ForeColor="Red"></asp:Label>
                </div>
            </div>

        </div>
    </div>
    <div class="col-sm-3">
    </div>
</asp:Content>
