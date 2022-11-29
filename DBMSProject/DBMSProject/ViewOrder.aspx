<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewOrder.aspx.cs" Inherits="DBMSProject.ViewOrder" MasterPageFile="~/Site.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Orders</h2>
    <h4>Navigate to:</h4>
    <div>
        <asp:Button ID ="btnAccount" Text= "Account" runat="server" OnClick="btnAccount_Click"/>
        <asp:Button ID ="btnSearch" Text= "Book Search" runat="server" OnClick="btnSearch_Click"/>
    </div>
    </br>
    </br>
    <div>
        <asp:Button ID ="btnRefresh" Text= "Refresh" runat="server" OnClick="btnRefresh_Click"/>
    </div>
    </br>
    <div>
        <asp:GridView ID="gvOutput" CssClass="table table-striped bg-info" runat="server" AutoGenerateColumns="True">
            
        </asp:GridView>
    </div>
    </asp:Content>
