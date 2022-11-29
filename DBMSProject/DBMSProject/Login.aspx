<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DBMSProject._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="left-justify">Sign In!</h2>
            <div class="row">
                <div class="col-md-2">
                    <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
                    </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtUsername" runat="server" OnTextChanged="txtUsername_TextChanged"></asp:TextBox>
                    <!--<asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtUsername" ErrorMessage="Invalid " ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtUsername" ErrorMessage="Enter an email"></asp:RequiredFieldValidator>-->
                </div>
                <div class="col-md-2">
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Enter the password"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-12">
                    <asp:Label ID="Label1" runat="server" Text=" " Visible="true"></asp:Label><br />
                </div>
                <div class="col-md-12">
                    <asp:Button ID="btnLogIn" CssClass="btn btn-primary" runat="server" Text="Log In" OnClick="btnLogIn_Click"/>
                    <asp:Label ID="lblLoginFail" runat="server" Text="Login failed" Visible="false"></asp:Label>
                </div>
            </div>
                <div class="row">
                 <div class ="col-md-12">
                     <br />
                   <asp:Label ID="lblOr" runat="server" Text="Sign up here!" Visible="true"></asp:Label>
                    </div>
                <div class ="col-md-12">
                    <br />
                    <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" CausesValidation="False" CssClass="btn btn-success" OnClick="btnSignUp_Click"/>
                </div>

            </div>
</asp:Content>
