<%@ Page Title="ADMIN.NyhedRet" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="NyhedRetRet.aspx.cs" Inherits="admin_NyhedRetRet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="div-login">
    <asp:TextBox ID="txtOverskrift" runat="server" placeholder="Overskrift" autofocus CssClass="txt-login" />
    <br />
    <asp:TextBox ID="txtTeaser" runat="server" placeholder="Teaser" TextMode="MultiLine" CssClass="txt-multiline" />
    <br />
    <asp:TextBox ID="txtTekst" runat="server" placeholder="Tekst" TextMode="MultiLine" CssClass="txt-multiline" />
    <br />
    <asp:DropDownList ID="ddlKat" runat="server" AutoPostBack="true" CssClass="txt-login" />
    <br />
    <asp:Image ID="imgImage" runat="server" />
    <br />
    <asp:CheckBox ID="chbImg" runat="server" Text="Slet billede" />
    <br />
    <asp:FileUpload ID="fuImage" runat="server" />
    <br />
    <asp:Button ID="btnSend" runat="server" Text="Ret" OnClick="btnSend_Click" CssClass="btn-login" />
    <br />
    <asp:Literal ID="litResult" runat="server" />
    </div>
</asp:Content>

