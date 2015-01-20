<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<asp:Content id="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">

</asp:Content>

<asp:Content id="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <!-- Insert Content Below -->
    <form id="form1" runat="server">
        <asp:DropDownList ID="ddlCustomers" runat="server" DataSourceID="GetCustomers" DataTextField="Name" DataValueField="CustomerID">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="GetCustomers" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetCustomers" TypeName="TravelExperts.CustomerDB"></asp:ObjectDataSource>
        <br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="GetCustomerbyID" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                <asp:BoundField DataField="ZipCode" HeaderText="ZipCode" SortExpression="ZipCode" />
            </Fields>
        </asp:DetailsView>
        <asp:ObjectDataSource ID="GetCustomerbyID" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetCustomer" TypeName="TravelExperts.CustomerDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlCustomers" Name="customerID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:ListView ID="ListView1" runat="server" DataSourceID="GetPackageOfCustomer">
        </asp:ListView>
        <asp:ObjectDataSource ID="GetPackageOfCustomer" runat="server"></asp:ObjectDataSource>
        <br />
        <br />
    </form>

</asp:Content>