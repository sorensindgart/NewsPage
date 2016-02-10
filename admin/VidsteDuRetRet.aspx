<%@ Page Title="ADMIN.VidsteDuRet" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="VidsteDuRetRet.aspx.cs" Inherits="admin_VidsteDuRetRet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="div-login">
    <asp:TextBox ID="txtOverskrift" runat="server" placeholder="Overskrift" CssClass="txt-login" />
    <br />
    <asp:TextBox ID="txtTekst" runat="server" placeholder="Tekst" CssClass="txt-multiline" />
    <br />
    <asp:Button ID="btnSend" runat="server" Text="Ret" OnClick="btnSend_Click" CssClass="btn-login" />
    <br />
    <asp:Literal ID="litResult" runat="server" />
    </div>

</asp:Content>

