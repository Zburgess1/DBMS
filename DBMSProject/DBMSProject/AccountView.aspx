<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountView.aspx.cs" Inherits="DBMSProject.AccountView" MasterPageFile="~/Site.Master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Account View</h2>
 
    <h4> Account Information</h4>
    <div>
        <asp:Label ID ="lblEmail" runat="server" Text="Email: "></asp:Label>
    </div>
    <div>
        <asp:Label ID ="lblAddress" runat="server" Text="Address: "></asp:Label>
    </div>
    <div>
        <asp:Label ID ="lblPhone" runat="server" Text="Phone: "></asp:Label>
    </div>
    <div>
        <asp:Label ID ="lblUsername" runat="server" Text="Username: "></asp:Label>
    </div>
    <div>
        <asp:Label ID ="lblPassword" runat="server" Text="Password: "></asp:Label>
    </div>
    <h4>Change Username</h4>
    <h6>New Username</h6>
    <div>
    <asp:Textbox id="txtNewUser" runat="server" Height="20px" Width="200px"></asp:Textbox>
    </div>
    <h6>New Address</h6>
    <div>
    <asp:Textbox id="txtAddress" runat="server" Height="20px" Width="400px"></asp:Textbox>
    </div>
    <h6>New Phone</h6>
    <div>
    <asp:Textbox id="txtPhone" runat="server" Height="20px" Width="200px"></asp:Textbox>
    </div>
    <h6>New Email</h6>
    <div>
    <asp:Textbox id="txtEmail" runat="server" Height="20px" Width="200px"></asp:Textbox>
    </div>
    <h6>New Password</h6>
    <div>
    <asp:Textbox id="txtPassword" runat="server" Height="20px" Width="200px"></asp:Textbox>
    </div>
    </br>
    <h6>Click to update</h6>
    <div>
        <asp:Button ID ="btnUpdateUsername" Text= "Update Username" runat="server" />
        <asp:Button ID ="btnUpdateAddress" Text= "Update Address" runat="server" />
        <asp:Button ID ="btnUpdatePhone" Text= "Update Phone" runat="server" />
        <asp:Button ID ="btnUpdateEmail" Text= "Update Email" runat="server" />
        <asp:Button ID ="btnUpdatePassword" Text= "Update Password" runat="server" />
    </div>
    </br>
    <div>
        <asp:Label ID ="lblBook" runat="server" Text="Click Here to Search"></asp:Label>
    </div>
    <div>
        <asp:Button ID ="bookSearch" Text= "BookSearch" runat="server" OnClick="bookSearch_Click" />
    </div>
    </asp:Content>