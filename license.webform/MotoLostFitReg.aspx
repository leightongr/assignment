<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MotoLostFitReg.aspx.cs" Inherits="license.webform.MotoLostFitReg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-6 form-horizontal">

            <fieldset>

                <!-- Form Name -->
                <legend>Form Name</legend>

                <!-- Text input-->

                    <div class="form-group">
                        <label class="col-md-4 control-label" for="FirstName">FirstName</label>
                        <div class="col-md-4">
                            <asp:TextBox runat="server" id="FirstName" name="FirstName" type="text" placeholder="placeholder" class="form-control input-md"></asp:TextBox>
                        </div>
                    </div>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="LastName">Last Name</label>
                    <div class="col-md-4">
                        <asp:TextBox runat="server" id="LastName" name="LastName" type="text" placeholder="placeholder" class="form-control input-md"></asp:TextBox>
                    </div>
                </div>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="ExaminationDepot">Examination Depot</label>
                    <div class="col-md-4">
                        <asp:TextBox runat="server" id="ExaminationDepot" name="ExaminationDepot" type="text" placeholder="placeholder" class="form-control input-md"></asp:TextBox>
                    </div>
                </div>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="CC">CC</label>
                    <div class="col-md-4">
                        <asp:TextBox runat="server" id="CC" name="CC" type="text" placeholder="" class="form-control input-md"></asp:TextBox>
                        <span class="help-block">Enter CC Rating</span>
                    </div>
                </div>

                <!-- Appended Input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="Laden">Laden</label>
                    <div class="col-md-4">
                        <div class="input-group">
                            <asp:TextBox runat="server" id="Laden" name="Laden" class="form-control" placeholder="placeholder" type="text"></asp:TextBox>
                            <span class="input-group-addon">KG</span>
                        </div>

                    </div>
                </div>
                <!-- Appended Input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="Unladen">Unladen</label>
                    <div class="col-md-4">
                        <div class="input-group">
                            <asp:TextBox runat="server" id="Unladen" name="Unladen" class="form-control" placeholder="placeholder" type="text"></asp:TextBox>
                            <span class="input-group-addon">KG</span>
                        </div>

                    </div>
                </div>
                <!-- Textarea -->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="Address">Address</label>
                    <div class="col-md-4">
                        <textarea class="form-control" id="Address" name="Address">default text</textarea>
                    </div>
                </div>

            </fieldset>


        </div>
        <div class="col-md-6">
        </div>
    </div>


                </div>
    </div>


</asp:Content>
