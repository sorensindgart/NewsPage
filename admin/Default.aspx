<%@ Page Title="ADMIN.Default" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3 class="side-overskrifter">Velkommen til NewsSite CMS</h3>
    <h1 class="side-overskrifter">2 Seneste Nyheder ...</h1>
    <br />
    <asp:Literal ID="litNyhed" runat="server" />
    <br />
    <div class="line"></div>
    <br />
    <br />
    <h1 class="side-overskrifter">2 Seneste Vidste Du ...</h1>
    <asp:Literal ID="litVidsteDu" runat="server" />

</asp:Content>

