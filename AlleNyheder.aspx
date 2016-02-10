<%@ Page Title="NewsSite.Alle Nyheder" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AlleNyheder.aspx.cs" Inherits="AlleNyheder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="side-overskrifter">Alle Nyheder ...</h1>
    <br />
    <asp:Literal ID="litNyhed" runat="server" />
</asp:Content>

