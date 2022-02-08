<%@ Page Language="VB" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="AddPhoneNumber.aspx.vb" Inherits="shangrila_spa.AddPhoneNumber" %>

<asp:content id="ClientArea" contentplaceholderid="Content" runat="server">
     
<div class="accountHeader">
    <h2>Add a phone number</h2>
</div>
<p><asp:Literal runat="server" ID="ErrorMessage" /></p>
<dx:BootstrapTextBox runat="server" ID="PhoneNumber" TextMode="Phone" Caption="Phone Number" >
    <CaptionSettings Position="Before" />
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="The PhoneNumber field is required."/>
    </ValidationSettings>
</dx:BootstrapTextBox><br />
<dx:BootstrapButton runat="server" ID="btnSubmit" OnClick="PhoneNumber_Click" Text="Submit" />
 
</asp:content>