<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Package.aspx.cs" Inherits="Package"%>

<asp:Content id="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
    <link href="Styles/Package.css" rel="stylesheet" />
</asp:Content>


<asp:Content id="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <form id="form1" runat="server">
        <!-- Insert Content Below -->



        <br />
        <asp:Label ID="lblPackageID" runat="server"></asp:Label>
        <br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="GetPackageByID" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="PackageID" HeaderText="PackageID" SortExpression="PackageID" />
                <asp:BoundField DataField="PkgName" HeaderText="PkgName" SortExpression="PkgName" />
                <asp:BoundField DataField="PkgStartDate" HeaderText="PkgStartDate" SortExpression="PkgStartDate" />
                <asp:BoundField DataField="PkgEndDate" HeaderText="PkgEndDate" SortExpression="PkgEndDate" />
                <asp:BoundField DataField="PkgDesc" HeaderText="PkgDesc" SortExpression="PkgDesc" />
                <asp:BoundField DataField="PkgBasePrice" HeaderText="PkgBasePrice" SortExpression="PkgBasePrice" />
                <asp:BoundField DataField="PkgAgencyCommission" HeaderText="PkgAgencyCommission" SortExpression="PkgAgencyCommission" />
            </Fields>
        </asp:DetailsView>
        <asp:ObjectDataSource ID="GetPackageByID" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetPackagesByID" TypeName="TravelExperts.PackageDB">
            <SelectParameters>
                <asp:SessionParameter Name="id" SessionField="PackageID" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </form>



</asp:Content>