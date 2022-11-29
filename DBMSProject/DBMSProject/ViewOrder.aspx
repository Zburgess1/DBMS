<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewOrder.aspx.cs" Inherits="DBMSProject.ViewOrder" MasterPageFile="~/Site.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Orders</h2>
    <div>
        <asp:GridView ID="gvOutput" CssClass="table table-striped bg-info" runat="server" AutoGenerateColumns="True">
            
        </asp:GridView>
    </div>
    </asp:Content>
