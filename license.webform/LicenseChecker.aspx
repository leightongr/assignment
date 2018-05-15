<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LicenseChecker.aspx.cs" Inherits="WebTitle.LicenseChecker" %>

<%@ Register Src="~/GetLicenseControl.ascx" TagPrefix="uc1" TagName="GetLicenseControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>License Checker
    </h1>
    
    <hr />

    <uc1:GetLicenseControl runat="server" ID="GetLicenseControl" />

</asp:Content>

