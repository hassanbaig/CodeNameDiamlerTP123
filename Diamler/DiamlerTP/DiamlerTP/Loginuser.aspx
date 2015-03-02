<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Loginuser.aspx.cs" Inherits="DiamlerTP.Loginuser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3><%: Title %></h3>
    <div class="navbar navbar-inverse navbar-fixed-top" runat="server" data-target=".navbar navbar-inverse navbar-fixed-top-collapse"></div>
    <div class="container">
        <div class="row">
            <div class="col-sm-6 col-md-4 col-md-offset-4">
                <h4 class="text-center-login-title">Transportplanung System</h4>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:TextBox runat="server" CssClass="form-control" placeholder="Benutzername" name="username" type="email" ID="txtusername"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtusername" ErrorMessage="Bitte Fuehlen Sie Benutzer Name" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;</div>
                    <div class="form-group">
                        <asp:TextBox runat="server" CssClass="form-control" placeholder="Kennwort" name="password" type="password" value="" ID="txtpassword" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" ErrorMessage="Bitte Fuehlen Sie Kennzeichen" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="checkbox">
                        <label>
                            <input name="remember" type="checkbox" value="Angemeldet bleiben" />Angemeldet bleiben
                        </label>
                    </div>
                    <div class="form-group">
                        <asp:Button href="#" ID="btnsubmit" runat="server" CssClass="btn btn-Default" Text="Anmelden" OnClick="btnsubmit_Click" />
                    </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
