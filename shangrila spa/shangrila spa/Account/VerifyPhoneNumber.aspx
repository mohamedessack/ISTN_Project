<%@ Page Language="VB" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="VerifyPhoneNumber.aspx.vb" Inherits="shangrila_spa.VerifyPhoneNumber" %>

<asp:content id="ClientArea" contentplaceholderid="Content" runat="server">
     
<div class="accountHeader">
    <h2>Enter verification code</h2>
</div>
<p><asp:Literal runat="server" ID="ErrorMessage" /></p>
<dx:ASPxHiddenField runat="server" ID="HiddenField" />
<dx:BootstrapTextBox runat="server" ID="Code" TextMode="Phone" Caption="Code">
    <CaptionSettings Position="Before" />
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="The Verification Code is required."/>
    </ValidationSettings>
</dx:BootstrapTextBox><br />
<dx:BootstrapButton runat="server" ID="btnSubmit" OnClick="Code_Click" Text="Submit" />
 
</asp:content>