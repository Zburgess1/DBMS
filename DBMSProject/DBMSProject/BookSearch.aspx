<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookSearch.aspx.cs" Inherits="DBMSProject.BookSearch" MasterPageFile="~/Site.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Book Search</h2>
    </br>
    <h4>Search</h4>
    <div>
        <asp:Textbox id="searchBox" runat="server" Height="19px" Width="496px" OnTextChanged="searchBox_TextChanged"></asp:Textbox>
    </div>
    </br>
    <h4>Search By:</h4>
    <div>
        <asp:Button id="title" Text="Title" runat="server" OnClick="title_Click" />
        <asp:Button id="pubDate" Text="Publication Date (m/d/y)" runat="server" OnClick="pubDate_Click" />
        <asp:Button id="category" Text="Category" runat="server" OnClick="category_Click" />
        <asp:Button id="reviews" Text="Reviews" runat="server" OnClick="reviews_Click" />
        <asp:Button id="btnAll" Text="All Books" runat="server" OnClick="btnAll_Click" />
    </div>
    </br>
    <h4>Results:</h4>
    <div>
        <asp:GridView ID="gvOutput" CssClass="table table-striped bg-info" runat="server" AutoGenerateColumns="True">
            
        </asp:GridView>
    </div>
    </asp:Content>
