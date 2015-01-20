<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<asp:Content id="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">

</asp:Content>

<asp:Content id="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <!-- Insert Content Below -->
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="CustLastName" DataValueField="CustomerId">
        </asp:DropDownList>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TravelExpertsConnectionString %>" SelectCommand="SELECT [CustFirstName], [CustomerId], [CustLastName] FROM [Customers]"></asp:SqlDataSource>
    </form>

</asp:Content>