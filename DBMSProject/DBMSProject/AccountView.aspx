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
    <div><asp:Button ID ="btnUpdate" Text= "Update" runat="server" /></div>
    </asp:Content>