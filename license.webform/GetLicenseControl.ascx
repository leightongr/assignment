<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GetLicenseControl.ascx.cs" Inherits="WebTitle.GetLicenseControl" %>

<div class="row">
        <div class="col-md-6 form-horizontal">

            <fieldset>

                <!-- Form Name -->
                <legend>Enter Information</legend>
                <div runat="server" id="alertInvalidInfo" class="alert alert-danger hidden">
                    Could not find license with information provider. Please check and try again
                </div>
                <!-- Text input-->

                    <div class="form-group">
                        <div class="row">
                            <label class="col-md-4 control-label" for="FirstName">FirstName</label>
                            <div class="col-md-5">
                                <asp:TextBox runat="server" id="txtFirstName" name="txtFirstName" type="text" placeholder="" class="form-control input-md"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">

                            <div class=" col-md-offset-4 col-md-5">
                            <asp:RequiredFieldValidator Display="Dynamic"  CssClass="error" ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Please supply a first name"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        
                    </div>

                <!-- Text input-->
                <div class="form-group">
                    <div class="row">
                    <label class="col-md-4 control-label" for="LastName">Last Name</label>
                    <div class="col-md-5">
                        <asp:TextBox runat="server" id="txtLastName" name="txtLastName" type="text" placeholder="" class="form-control input-md"></asp:TextBox>
                    </div>

                    </div>
                    <div class="row">

                            <div class=" col-md-offset-4 col-md-5">
                            <asp:RequiredFieldValidator Display="Dynamic"  CssClass="error" ID="rfvLastName" runat="server" ControlToValidate="txtLastName" ErrorMessage="Please supply a last name"></asp:RequiredFieldValidator>

                            </div>
                        </div>
                </div>

                <!-- Text input-->
                <div class="form-group">
                    <div class="row">
                    <label class="col-md-4 control-label" for="txtTrn">TRN</label>
                    <div class="col-md-5">
                        <asp:TextBox runat="server" id="txtTRN" name="txtTrn" type="text" placeholder="please enter trn with hyphens" class="form-control input-md"></asp:TextBox>
                    </div>
                    <div class="col-md-1 col-md-offset-1">
                        <asp:Button ID="btnCheck" OnClick ="btnCheck_Click" runat="server" CssClass="btn btn-primary" Text="Check!" />
                    </div>

                    </div>
                    <div class="row">
                            <div class=" col-md-offset-4 col-md-5">
                            <asp:RequiredFieldValidator Display="Dynamic" CssClass="error" ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTrn" ErrorMessage="Please supply a trn name"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator Display="Dynamic" ValidationExpression="^(\d{9}|\d{6})$" CssClass="error" ID="rxvTrn" runat="server" ControlToValidate="txtTrn" ErrorMessage="Trn must be between 9 or 6 (for business) digits"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                </div>



            </fieldset>


        </div>
    </div>