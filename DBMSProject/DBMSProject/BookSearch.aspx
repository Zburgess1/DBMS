<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookSearch.aspx.cs" Inherits="DBMSProject.BookSearch" MasterPageFile="~/Site.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Book Search</h2>
    </br>
    <h4>Search</h4>
    <div>
        <asp:Textbox id="searchBox" runat="server" Height="19px" Width="496px"></asp:Textbox>
    </div>
    </br>
    <h4>Filter By:</h4>
    <div>
        <asp:Button id="title" Text="Title" runat="server" />
        <asp:Button id="pubDate" Text="Publication Date" runat="server" />
        <asp:Button id="category" Text="Category" runat="server" />
        <asp:Button id="reviews" Text="Reviews" runat="server" />
    </div>
    </br>
    <h4>Results:</h4>
    <div>
        <asp:GridView ID="gvOutput" CssClass="table table-striped bg-info" runat="server" AutoGenerateColumns="True">
            
        </asp:GridView>
    </div>
    </asp:Content>
