<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<asp:Content id="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">

</asp:Content>

<asp:Content id="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <!-- Insert Content Below -->
    <form id="form1" runat="server">
        Select Customer<br />
        <asp:DropDownList ID="ddlCustomers" runat="server" DataSourceID="GetCustomers" DataTextField="CustFirstName" DataValueField="CustomerID" AutoPostBack="True">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="GetCustomers" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetCustomers" TypeName="TravelExperts.CustomerDB"></asp:ObjectDataSource>
        <asp:Label ID="lblIndex" runat="server"></asp:Label>
        <br />
        <br />
        Customer Details<br />
        <asp:DetailsView ID="DetailsView1" 
            runat="server" 
            AutoGenerateRows="False" 
            DataSourceID="GetCustomerbyID" 
            Height="50px" Width="125px" 
            BackColor="White" 
            BorderColor="#E7E7FF" 
            BorderStyle="None" 
            BorderWidth="1px" 
            CellPadding="3" 
            GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <Fields>
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
                <asp:BoundField DataField="CustFirstName" HeaderText="CustFirstName" SortExpression="CustFirstName" />
                <asp:BoundField DataField="CustLastName" HeaderText="CustLastName" SortExpression="CustLastName" />
                <asp:BoundField DataField="CustAddress" HeaderText="CustAddress" SortExpression="CustAddress" />
                <asp:BoundField DataField="CustCity" HeaderText="CustCity" SortExpression="CustCity" />
                <asp:BoundField DataField="CustProv" HeaderText="CustProv" SortExpression="CustProv" />
                <asp:BoundField DataField="CustPostal" HeaderText="CustPostal" SortExpression="CustPostal" />
                <asp:BoundField DataField="CustCountry" HeaderText="CustCountry" SortExpression="CustCountry" />
                <asp:BoundField DataField="CustHomePhone" HeaderText="CustHomePhone" SortExpression="CustHomePhone" />
                <asp:BoundField DataField="CustBusPhone" HeaderText="CustBusPhone" SortExpression="CustBusPhone" />
                <asp:BoundField DataField="CustEmail" HeaderText="CustEmail" SortExpression="CustEmail" />
                <asp:BoundField DataField="AgentID" HeaderText="AgentID" SortExpression="AgentID" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
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
        Customer&#39;s Packages<br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="GetPackagesByCustomerID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="PackageID" HeaderText="PackageID" SortExpression="PackageID" />
                <asp:BoundField DataField="PkgName" HeaderText="PkgName" SortExpression="PkgName" />
            </Columns>
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