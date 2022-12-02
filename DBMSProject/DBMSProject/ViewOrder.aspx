<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewOrder.aspx.cs" Inherits="DBMSProject.ViewOrder" MasterPageFile="~/Site.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Orders</h2>
    <h4>Navigate to:</h4>
    <div>
        <asp:Button ID ="btnAccount" Text= "Account" runat="server" OnClick="btnAccount_Click"/>
        <asp:Button ID ="btnSearch" Text= "Book Search" runat="server" OnClick="btnSearch_Click"/>
    </div>
    </br>
    <div>
        <asp:DropDownList ID="orders" runat="server" Height="16px" OnSelectedIndexChanged="orders_SelectedIndexChanged" Width="238px"></asp:DropDownList>
        <asp:Button id="deleteOrder" Text="Delete Order" runat="server" OnClick="deleteOrder_Click"/>
        <asp:Button id="placeOrder" Text="Place Order" runat="server" OnClick="placeOrder_Click"/>
    </div>
    </br>
    <div>
        <asp:Label ID ="lblRefresh" Text= "Click to show table:" runat="server"/>
    </div>
    <div>
        <asp:Button ID ="btnRefresh" Text= "Refresh" runat="server" OnClick="btnRefresh_Click"/>
    </div>
    </br>
    <div>
        <asp:GridView ID="gvOutput" CssClass="table table-striped bg-info" runat="server" AutoGenerateColumns="false" OnRowCommand="gvOutput_RowCommand" OnRowDataBound="gvOutput_RowDataBound">
            <Columns>
                <asp:BoundField DataField="OrderId" HeaderText="OrderId" />
                <asp:BoundField DataField="OrderValue" HeaderText="Price" />
                <asp:BoundField DataField="OrderDate" HeaderText="Date Ordered" />
                <asp:BoundField DataField="ItemPrice" HeaderText="Book Price" />
                <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                            <asp:Button ID="btnDeleteItem" runat="server" CssClass="btn btn-danger" Text="Delete Item" CommandName="DeleteItem" CausesValidation="False"/>
                        </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </asp:Content>
