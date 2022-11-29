<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminView.aspx.cs" Inherits="DBMSProject.AdminView" MasterPageFile="~/Site.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Admin View</h2>
    <div>
        <asp:Button id="customer" Text="Customers" runat="server" />
        <asp:Button id="order" Text="Orders" runat="server" />
        <asp:Button id="book" Text="Books" runat="server" />
        <asp:Button id="supplier" Text="Suppliers" runat="server" />
        <asp:Button id="author" Text="Authors" runat="server" />
    </div>
    </br>
    <h4>SQL Query Box</h4>
    <div>
        <asp:Textbox id="queryBox" runat="server" Height="19px" Width="496px"></asp:Textbox>
    </div>
    </br>
    </br>
    <h4>Data View</h4>
    <div>
    
        <asp:GridView ID="gvOutput" CssClass="table table-striped bg-info" runat="server" AutoGenerateColumns="True">
            
        </asp:GridView>
        
    </div>
    </asp:Content>