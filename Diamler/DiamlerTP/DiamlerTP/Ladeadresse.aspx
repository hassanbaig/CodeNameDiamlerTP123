<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ladeadresse.aspx.cs" Inherits="DiamlerTP.Ladeadresse" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3><%: Title %></h3>
    <div class="row">
        <div class="col-sm-2"></div>
             <div class="col-sm-8 form-horizontal">
            <div class="form-group">
                <label class="col-sm-3 control-label">Auswahl Suchname:</label>
                <div class="col-sm-5">
                    <asp:DropDownList ID="DDLSuchname" runat="server" CssClass="form-control" DataTextField="SearchName" AppendDataBoundItems="True">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Suchname:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtSuchname" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Name1:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtName1" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Name2:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtName2" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Strasse1:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtStrasse1" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Strasse2:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtStrasse2" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Plz:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtPlz" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Stadt:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtStadt" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Region/Staat:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtRegion" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Land:</label>
                <div class="col-sm-5">
                    <asp:DropDownList ID="DDLLand" runat="server" CssClass="form-control" DataValueField="ID" DataTextField="Country" AppendDataBoundItems="True"></asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label"></label>
                <div class="col-sm-5">
                    <asp:Button ID="btn" runat="server" CssClass="btn btn-lg btn-primary" Text="Speichern" OnClick="btn_Click" />
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-4 control-label"></label>
                <div class="col-sm-5">
                    <asp:Label ID="lblsuccess" runat="server" Text="Erfolgreich " Visible="false" ForeColor="Green"></asp:Label>
                </div>
            </div>
        </div>
    </div>
    <div class="col-sm-3">
    </div>
</asp:Content>
