<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<asp:Content id="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">

</asp:Content>

<asp:Content id="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <!-- Insert Content Below -->
    <form id="form1" runat="server">
        Select Customer<br />
        <asp:DropDownList ID="ddlCustomers" runat="server" DataSourceID="GetCustomers" DataTextField="CustFirstName" DataValueField="CustomerID" AutoPostBack="True" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="GetCustomers" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetCustomers" TypeName="TravelExperts.CustomerDB"></asp:ObjectDataSource>
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
        Customer&#39;s Packages<asp:ListView ID="lsvCustomerPackages" runat="server" DataSourceID="GetPackagesByCustomer">
            <AlternatingItemTemplate>
                <tr style="background-color: #FFFFFF;color: #284775;">
                    <td>
                        <asp:Label ID="PackageIDLabel" runat="server" Text='<%# Eval("PackageID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PkgNameLabel" runat="server" Text='<%# Eval("PkgName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PkgStartDateLabel" runat="server" Text='<%# Eval("PkgStartDate") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PkgEndDateLabel" runat="server" Text='<%# Eval("PkgEndDate") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PkgDescLabel" runat="server" Text='<%# Eval("PkgDesc") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PkgBasePriceLabel" runat="server" Text='<%# Eval("PkgBasePrice") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PkgAgencyCommissionLabel" runat="server" Text='<%# Eval("PkgAgencyCommission") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="background-color: #999999;">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:TextBox ID="PackageIDTextBox" runat="server" Text='<%# Bind("PackageID") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PkgNameTextBox" runat="server" Text='<%# Bind("PkgName") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PkgStartDateTextBox" runat="server" Text='<%# Bind("PkgStartDate") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PkgEndDateTextBox" runat="server" Text='<%# Bind("PkgEndDate") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PkgDescTextBox" runat="server" Text='<%# Bind("PkgDesc") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PkgBasePriceTextBox" runat="server" Text='<%# Bind("PkgBasePrice") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PkgAgencyCommissionTextBox" runat="server" Text='<%# Bind("PkgAgencyCommission") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                    <td>
                        <asp:TextBox ID="PackageIDTextBox" runat="server" Text='<%# Bind("PackageID") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PkgNameTextBox" runat="server" Text='<%# Bind("PkgName") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PkgStartDateTextBox" runat="server" Text='<%# Bind("PkgStartDate") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PkgEndDateTextBox" runat="server" Text='<%# Bind("PkgEndDate") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PkgDescTextBox" runat="server" Text='<%# Bind("PkgDesc") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PkgBasePriceTextBox" runat="server" Text='<%# Bind("PkgBasePrice") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PkgAgencyCommissionTextBox" runat="server" Text='<%# Bind("PkgAgencyCommission") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color: #E0FFFF;color: #333333;">
                    <td>
                        <asp:Label ID="PackageIDLabel" runat="server" Text='<%# Eval("PackageID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PkgNameLabel" runat="server" Text='<%# Eval("PkgName") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr runat="server" style="background-color: #E0FFFF;color: #333333;">
                                    <th runat="server">PackageID</th>
                                    <th runat="server">PkgName</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF"></td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color: #E2DED6;font-weight: bold;color: #333333;">
                    <td>
                        <asp:Label ID="PackageIDLabel" runat="server" Text='<%# Eval("PackageID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PkgNameLabel" runat="server" Text='<%# Eval("PkgName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PkgStartDateLabel" runat="server" Text='<%# Eval("PkgStartDate") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PkgEndDateLabel" runat="server" Text='<%# Eval("PkgEndDate") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PkgDescLabel" runat="server" Text='<%# Eval("PkgDesc") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PkgBasePriceLabel" runat="server" Text='<%# Eval("PkgBasePrice") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PkgAgencyCommissionLabel" runat="server" Text='<%# Eval("PkgAgencyCommission") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
        <asp:ObjectDataSource ID="GetPackagesByCustomer" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetPackagesByCustomerID" TypeName="TravelExperts.PackageDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlCustomers" Name="id" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <br />
    </form>

</asp:Content>