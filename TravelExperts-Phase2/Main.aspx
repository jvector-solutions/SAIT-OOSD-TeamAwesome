<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<asp:Content id="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">

</asp:Content>

<asp:Content id="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <!-- Insert Content Below -->
    <form id="form1" runat="server">
        <h2>Select Customer</h2><br />
        <asp:DropDownList ID="ddlCustomers" runat="server" DataSourceID="GetCustomers" DataTextField="CustFirstName" DataValueField="CustomerID" AutoPostBack="True" Height="36px" style="font-size: large" Width="238px">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="GetCustomers" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetCustomers" TypeName="TravelExperts.CustomerDB"></asp:ObjectDataSource>
        <br />
        <h2>Customer Details</h2><br />
        <asp:DetailsView ID="DetailsView1" 
            runat="server" 
            AutoGenerateRows="False" 
            DataSourceID="GetCustomerbyID" 
            Height="50px" Width="100%" BorderColor="#2F73C1" BorderStyle="Solid" BorderWidth="1px" CellPadding="2" CellSpacing="1" style="margin-top: 0px">
            <EditRowStyle BackColor="White" />
            <Fields>
                <asp:BoundField DataField="CustFirstName" HeaderText="First Name" SortExpression="CustFirstName" HeaderStyle-CssClass="custdetails" />
                <asp:BoundField DataField="CustLastName" HeaderText="Last Name" SortExpression="CustLastName" HeaderStyle-CssClass="custdetails" />
                <asp:BoundField DataField="CustAddress" HeaderText="Address" SortExpression="CustAddress" HeaderStyle-CssClass="custdetails" />
                <asp:BoundField DataField="CustCity" HeaderText="City" SortExpression="CustCity" HeaderStyle-CssClass="custdetails" />
                <asp:BoundField DataField="CustProv" HeaderText="Province" SortExpression="CustProv" HeaderStyle-CssClass="custdetails" />
                <asp:BoundField DataField="CustPostal" HeaderText="Postal Code" SortExpression="CustPostal" HeaderStyle-CssClass="custdetails" />
                <asp:BoundField DataField="CustCountry" HeaderText="Country" SortExpression="CustCountry" HeaderStyle-CssClass="custdetails" />
                <asp:BoundField DataField="CustHomePhone" HeaderText="Home Phone" SortExpression="CustHomePhone" HeaderStyle-CssClass="custdetails" />
                <asp:BoundField DataField="CustBusPhone" HeaderText="Business Phone" SortExpression="CustBusPhone" HeaderStyle-CssClass="custdetails" />
                <asp:BoundField DataField="CustEmail" HeaderText="Email" SortExpression="CustEmail" HeaderStyle-CssClass="custdetails" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />

            </Fields>
            <HeaderStyle HorizontalAlign="Right" BackColor="#2F73C1" ForeColor="White" Width="160px" Font-Bold="True" />
        </asp:DetailsView>
        <asp:ObjectDataSource ID="GetCustomerbyID" runat="server" 
            OldValuesParameterFormatString="original_{0}" 
            SelectMethod="GetCustomer" 
            TypeName="TravelExperts.CustomerDB" 
            ConflictDetection="CompareAllValues" 
            DataObjectTypeName="TravelExperts.Customer" 
            DeleteMethod="DeleteCustomer" 
            InsertMethod="AddCustomer" 
            UpdateMethod="UpdateCustomer">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlCustomers" Name="customerID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="original_customer" Type="Object" />
                <asp:ControlParameter ControlID="DetailsView1" Name="customer" PropertyName="SelectedValue" Type="Object" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        
        <br />
        <h2>Customer&#39;s Packages</h2><br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="GetPackagesByCustomerID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="100%" BorderColor="#2F73C1" BorderStyle="Solid" BorderWidth="1px" CellPadding="2" CellSpacing="1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" >
                <ItemStyle BackColor="#2F73C1" ForeColor="White" />
                </asp:CommandField>
                <asp:BoundField DataField="PackageID" HeaderText="Package ID" SortExpression="PackageID" />
                <asp:BoundField DataField="PkgName" HeaderText="Package Name" SortExpression="PkgName" />
            </Columns>
            <RowStyle HorizontalAlign="Center" />
        </asp:GridView>
        <asp:ObjectDataSource ID="GetPackagesByCustomerID" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetPackagesByCustomerID" TypeName="TravelExperts.PackageDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlCustomers" Name="id" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <br />
    </form>

</asp:Content>