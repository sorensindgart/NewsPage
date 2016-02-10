<%@ Page Title="ADMIN.KontaktRet" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="KontaktRetRet.aspx.cs" Inherits="admin_KontaktRetRet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="div-login">
    <asp:TextBox ID="txtFirmanavn" runat="server" CssClass="txt-login" />
    <br />
    <asp:TextBox ID="txtAdresse" runat="server" CssClass="txt-login" />
    <br />
    <asp:TextBox ID="txtPostnummer" runat="server" CssClass="txt-login" />
    <br />
    <asp:TextBox ID="txtBy" runat="server" CssClass="txt-login" />
    <br />
    <asp:TextBox ID="txtTelefon" runat="server" CssClass="txt-login" />
    <br />
    <asp:TextBox ID="txtEmail" runat="server" CssClass="txt-login" />
    <br />
    <asp:Button ID="btnSend" runat="server" Text="Ret" OnClick="btnSend_Click" CssClass="btn-login" />
    <br />
    <asp:Literal ID="litResult" runat="server" />
    </div>
</asp:Content>

