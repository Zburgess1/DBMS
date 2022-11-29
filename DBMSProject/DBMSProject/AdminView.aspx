<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminView.aspx.cs" Inherits="DBMSProject.AdminView" MasterPageFile="~/Site.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Admin View</h2>
    <div>
        <asp:Button id="customer" Text="Customers" runat="server" OnClick="customer_Click" />
        <asp:Button id="order" Text="Orders" runat="server" OnClick="order_Click" />
        <asp:Button id="book" Text="Books" runat="server" OnClick="book_Click" />
        <asp:Button id="supplier" Text="Suppliers" runat="server" OnClick="supplier_Click" />
        <asp:Button id="author" Text="Authors" runat="server" OnClick="author_Click" />
    </div>
    </br>
    <h4>SQL Query Box</h4>
    <div>
        <asp:Textbox id="queryBox" runat="server" Height="19px" Width="803px" OnTextChanged="queryBox_TextChanged"></asp:Textbox>
        <asp:Button id="btnExecute" Text="Execute Query" runat="server" OnClick="btnExecute_Click" />
    </div>
    </br>
    </br>
    <h4>Data View</h4>
    <div>
    
        <asp:GridView ID="gvOutput" CssClass="table table-striped bg-info" runat="server" AutoGenerateColumns="True">
            
        </asp:GridView>
        
    </div>
    </asp:Content>