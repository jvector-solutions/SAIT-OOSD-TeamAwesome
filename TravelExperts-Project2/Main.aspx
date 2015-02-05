<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<asp:Content id="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-image:url("Images/main_booking_background.jpg");
            background-size: cover;
            background-repeat: no-repeat;
        }
        .auto-style2 {
            width: 50%;
        }
    </style>
</asp:Content>
    
<asp:Content id="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">

    <form id="form1" runat="server" class="auto-style1" style="text-align:center; padding-top: 0;">
        <h1>
            Welcome to the Travel Experts!
        </h1>

        <table>
            <tr>
                <td class="auto-style2">
                    <div style="height: 570px; width: 100%; display: block; margin: 24px; background-color: rgba(255,255,255,0.4); border: 1px solid #fff;">

                    </div>
                </td>
                <td><img src="Images/sidebar.png"/></td>
            </tr>
        </table>
    </form>

</asp:Content>
