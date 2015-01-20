<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Request" %>

<asp:Content id="Content1" ContentPlaceHolderID="headPlaceHolder" runat="server">

</asp:Content>

<asp:Content id="Content2" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <!-- Insert Content Below -->
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="CustLastName" DataValueField="CustomerId">
        </asp:DropDownList>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TravelExpertsConnectionString %>" SelectCommand="SELECT [CustFirstName], [CustomerId], [CustLastName] FROM [Customers]"></asp:SqlDataSource>
    </form>

</asp:Content>