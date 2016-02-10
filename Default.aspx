<%@ Page Title="NewsSite.Forside" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h1 class="side-overskrifter">3 Seneste Nyheder ...</h1>
    <br />
    <asp:Literal ID="litNyhed" runat="server" />
    <br />
    <div class="line"></div>
    <br />
    <br />
    <h1 class="side-overskrifter">4 Seneste Vidste Du ...</h1>

    <%--    <img src="http://lorempixel.com/400/200/" alt="Flot billede" />--%>

    <asp:Literal ID="litVidsteDu" runat="server" />
</asp:Content>
