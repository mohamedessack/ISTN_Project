<%@ Page Language="VB" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="ResetPasswordConfirmation.aspx.vb" Inherits="shangrila_spa.ResetPasswordConfirmation" %>

<asp:content id="ClientArea" contentplaceholderid="Content" runat="server">
     
<div class="accountHeader">
    <h2>Password Changed</h2>
</div>
<p>Your password has been changed. Click <dx:BootstrapHyperLink ID="login" runat="server" NavigateUrl="~/Account/Login.aspx" Text="here" /> to login </p>
</asp:content>