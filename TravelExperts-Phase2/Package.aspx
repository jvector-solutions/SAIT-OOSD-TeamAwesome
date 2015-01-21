<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Package.aspx.cs" Inherits="Package"%>

<asp:Content id="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
    <link href="Styles/Package.css" rel="stylesheet" />
</asp:Content>


<asp:Content id="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <form id="form1" runat="server">
        <!-- Insert Content Below -->
        <h2>Customer&#39;s Packages</h2><br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="GetPackageByID" Height="50px" Width="100%">
            <Fields>
                <asp:BoundField DataField="PkgName" HeaderText="Package Name" SortExpression="PkgName" />
                <asp:BoundField DataField="PkgStartDate" HeaderText="Start Date" SortExpression="PkgStartDate" />
                <asp:BoundField DataField="PkgEndDate" HeaderText="End Date" SortExpression="PkgEndDate" />
                <asp:BoundField DataField="PkgDesc" HeaderText="Description" SortExpression="PkgDesc" />
                <asp:BoundField DataField="PkgBasePrice" HeaderText="Base Price" SortExpression="PkgBasePrice" />
            </Fields>
        </asp:DetailsView>
        <asp:ObjectDataSource ID="GetPackageByID" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetPackagesByID" TypeName="TravelExperts.PackageDB">
            <SelectParameters>
                <asp:SessionParameter Name="id" SessionField="PackageID" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </form>



</asp:Content>