<%@ Page Title="NewsSite.Nyhedskategori #1" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Nyhedskategorier1.aspx.cs" Inherits="Nyhedskategorier1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1 class="side-overskrifter">Nyheder - ud fra kategori #1</h1>
    <br />
    <div class="div-login">
    <asp:DropDownList ID="ddlKat" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlKat_SelectedIndexChanged" CssClass="txt-login" >
        <asp:ListItem Text="Vælg en nyhedskategori" disabled="disabled" Selected="True"></asp:ListItem>
        <asp:ListItem Text="Vis alle nyheder" disabled="disabled" Selected="false"></asp:ListItem>
    </asp:DropDownList>
    <asp:Literal ID="litResult" runat="server" />
        </div>
</asp:Content>

