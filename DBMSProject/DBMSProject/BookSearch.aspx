<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookSearch.aspx.cs" Inherits="DBMSProject.BookSearch" MasterPageFile="~/Site.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Book Search</h2>
    <h4>Navigate to:</h4>
    <div>
        <asp:Button id="btnOrder" Text="Orders" runat="server" OnClick="btnOrder_Click"/>
        <asp:Button id="btnAccount" Text="Account" runat="server" OnClick="btnAccount_Click"/>
    </div>
    </br>
    <h4>Search</h4>
    <div>
        <asp:Textbox id="searchBox" runat="server" Height="19px" Width="496px" OnTextChanged="searchBox_TextChanged"></asp:Textbox>
    </div>
    </br>
    <h4>Select order to add to:</h4>
    <div>
        <asp:DropDownList ID="orders" runat="server" Height="16px" OnSelectedIndexChanged="orders_SelectedIndexChanged" Width="238px"></asp:DropDownList>
        <asp:Button id="newOrder" Text="Create new order" runat="server" OnClick="newOrder_Click"/>
    </div>
    </br>
    <h4>Click to Search By:</h4>
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
        <asp:GridView ID="gvOutput" CssClass="table table-striped bg-info" runat="server" AutoGenerateColumns="false" OnRowCommand="gvOutput_RowCommand" OnRowDataBound="gvOutput_RowDataBound">
            <Columns>
                <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
                <asp:BoundField DataField="Title" HeaderText="Title" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:BoundField DataField="PubDate" HeaderText="Publication Date" />
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                            <asp:Button ID="btnAddToOrder" runat="server" CssClass="btn btn-danger" Text="Add to Order" CommandName="AddToOrder" CausesValidation="False"/>
                        </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </asp:Content>
