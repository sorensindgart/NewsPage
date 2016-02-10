<%@ Page Title="NewsSite.Login" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="div-login">
    <asp:Literal ID="litResult" runat="server" />
    <br />
    <asp:TextBox ID="txtUsername" runat="server" placeholder="Username" autofocus CssClass="txt-login"/>
    <br />
    <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" TextMode="Password" CssClass="txt-login" />
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="btn-login" />
    </div>
</asp:Content>

