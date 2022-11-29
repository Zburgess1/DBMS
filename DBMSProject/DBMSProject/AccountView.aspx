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
    <asp:Textbox id="txtNewUser" runat="server" Height="20px" Width="200px" OnTextChanged="txtNewUser_TextChanged"></asp:Textbox>
    </div>
    <h6>New Address</h6>
    <div>
    <asp:Textbox id="txtAddress" runat="server" Height="20px" Width="400px" OnTextChanged="txtAddress_TextChanged"></asp:Textbox>
    </div>
    <h6>New Phone</h6>
    <div>
    <asp:Textbox id="txtPhone" runat="server" Height="20px" Width="200px" OnTextChanged="txtPhone_TextChanged"></asp:Textbox>
    </div>
    <h6>New Email</h6>
    <div>
    <asp:Textbox id="txtEmail" runat="server" Height="20px" Width="200px" OnTextChanged="txtEmail_TextChanged"></asp:Textbox>
    </div>
    <h6>New Password</h6>
    <div>
    <asp:Textbox id="txtPassword" runat="server" Height="20px" Width="200px" OnTextChanged="txtPassword_TextChanged"></asp:Textbox>
    </div>
    </br>
    <h6>Click to update</h6>
    <div>
        <asp:Button ID ="btnUpdateUsername" Text= "Update Username" runat="server" OnClick="btnUpdateUsername_Click" />
        <asp:Button ID ="btnUpdateAddress" Text= "Update Address" runat="server" OnClick="btnUpdateAddress_Click" />
        <asp:Button ID ="btnUpdatePhone" Text= "Update Phone" runat="server" OnClick="btnUpdatePhone_Click" />
        <asp:Button ID ="btnUpdateEmail" Text= "Update Email" runat="server" OnClick="btnUpdateEmail_Click" />
        <asp:Button ID ="btnUpdatePassword" Text= "Update Password" runat="server" OnClick="btnUpdatePassword_Click" />
    </div>
    </br>
    <h6>Make sure Phone and Address are filled before clicking</h6>
    <div>
        <asp:Button ID ="btnAddData" Text= "Add Data" runat="server" OnClick="btnAddData_Click"/>
    </div>
    </br>
    <div>
        <asp:Label ID ="lblBook" runat="server" Text="Navigate to:"></asp:Label>
    </div>
    <div>
        <asp:Button ID ="bookSearch" Text= "Book Search" runat="server" OnClick="bookSearch_Click"/>
        <asp:Button ID ="btnOrder" Text= "Orders" runat="server" OnClick="btnOrder_Click"/>
    </div>
    </asp:Content>