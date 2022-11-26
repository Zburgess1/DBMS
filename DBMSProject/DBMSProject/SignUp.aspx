<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="DBMSProject.WebForm1" MasterPageFile="~/Site.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="left-justify">Sign-Up!</h2>
             <div class="row">
                <div class="col-md-2">
                    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter an email"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-2">
                    <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername" ErrorMessage="Enter a username"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-2">
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Enter a password"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-2">
                    <asp:Label ID="lblPasswordconfirm" runat="server" Text="Confirm Password"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtPasswordConfirm" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="cpvConfirmPassword" runat="server" ControlToCompare="txtPasswordConfirm" ControlToValidate="txtPassword" ErrorMessage="Passwords do not match." SetFocusOnError="True" ValidationGroup="ConfirmPassword"></asp:CompareValidator>
                </div>
                 <div class ="col-md-10">
                     <asp:FileUpload ID="fuProfileImage" runat="server" ClientIDMode="Static" CssClass="form-control-file" />
                 </div>
            </div><br />
            <div class="row">
                <div class="col-md-12">
                    <asp:Button ID="btnCreateProfile" runat="server" CssClass="btn btn-success" Text="Sign Up!" />
                    <asp:Button ID="btnDebugTable" runat="server" Text="Show/Hide" CssClass="btn btn-secondary" CommandName="btnDebugTable_Click" CausesValidation="False" Visible="False" />
                </div>
                 <div class ="col-md-12">
                     <br />
                   <asp:Label ID="lblOr" runat="server" Text="Login here!" Visible="true"></asp:Label>
                    </div>
                <div class ="col-md-12">
                    <br />
                    <asp:Button ID="btnLogin" runat="server" Text="Log In!" CausesValidation="False" CssClass="btn btn-primary"/>
                </div>
            </div>
                <asp:GridView ID="gvDebugTable" runat="server" Visible="false">
                </asp:GridView>
</asp:Content>
