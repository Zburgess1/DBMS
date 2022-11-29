<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountView.aspx.cs" Inherits="DBMSProject.AccountView" MasterPageFile="~/Site.Master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Account View</h2>
    <div>
       
    </div>
    </br>
    <h4> Account Information</h4>
    <div>
        <asp:Label ID ="lblEmail" runat="server" Text="Email: "></asp:Label>
        </div>
    <div>
        <asp:Label ID ="lblUsername" runat="server" Text="Username: "></asp:Label>
    </div>
    <h4>Change Username</h4>
    <h6>New Username</h6>
    <div>
    <asp:Textbox id="txtNewUser" runat="server" Height="20px" Width="200px"></asp:Textbox>
    <asp:Button ID ="btnChangeUser" Text="Change Username" runat="server" />
    </div>
    </asp:Content>

