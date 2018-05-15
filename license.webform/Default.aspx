<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="license.webform._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>License Management Online!</h1>
        <p class="lead"> </p>
        <p><a href="LicenseChecker.aspx" class="btn btn-primary btn-lg">Start Here!</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                <ul>
                    <li>License Validation - Check if your license is still valid!</li>
                    <li>Renewal Request - Request a license renewal.</li>
                </ul>
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
     
    </div>

</asp:Content>
