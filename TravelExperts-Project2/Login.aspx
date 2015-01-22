<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content id="Content1" ContentPlaceHolderID="headPlaceHolder" runat="server">

</asp:Content>

<asp:Content id="Content2" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <!-- Enter content below -->
    <form id="formLogin" runat="server">
    <div>
    
        <asp:Login ID="Login1" runat="server">
        </asp:Login>
    
    </div>
    </form>
</asp:Content>
