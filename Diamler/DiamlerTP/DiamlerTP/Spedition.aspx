<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Spedition.aspx.cs" Inherits="DiamlerTP.Spedition" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3><%: Title %></h3>
    <div class="row">
        <div class="col-sm-2">
        </div>
        <div class="col-sm-8 form-horizontal">
            <div class="form-group">
                <label class="col-sm-3 control-label">Auswahl Spedition:</label>
                <div class="col-sm-5">
                    <asp:DropDownList ID="DDLSpedition" runat="server" CssClass="form-control" DataTextField="SearchName" AppendDataBoundItems="True">
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
                    <asp:TextBox ID="txtRegion" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Land:</label>
                <div class="col-sm-5">
                    <asp:DropDownList ID="DDLLand" runat="server" CssClass="form-control" DataValueField="Country" AppendDataBoundItems="True"></asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Haput Tel:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtHauptTel" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Haupt Fax:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtHauptFax" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Haupt Email:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtHauptEmail" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Lft-Nr:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtLftNr" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Funktion:</label>
                <div class="col-sm-5">
                    <asp:DropDownList ID="DDLFunktion" runat="server" CssClass="form-control" DataValueField="Function" AppendDataBoundItems="True"></asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Offene Transporte:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtOffeneTransporte" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>

                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Geshlossene Transporte:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtGeshlosseneTransporte" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>

                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Einstazgiebete:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtEinstazgiebete" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>

                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">Bemerkungen:</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtBemerkungen" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>

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
