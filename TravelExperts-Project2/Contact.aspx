<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content id="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server"></asp:Content>

<asp:Content id="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <form id="form1" runat="server">
        <table style="width: 390px; margin: 0 auto;">
            <tr>
                <td colspan="2">
                <h2><asp:Label ID="lblContact" runat="server" CssClass="h2" Text="Contact"></asp:Label></h2><br />
                </td>
            </tr>
            <tr>
                <td><label for="name">Your name:</label></td>
                <td><input class="textbox" name="name" type="text" /></td>
            </tr>
            <tr>
                <td><label for="email">Your email:</label></td>
                <td><input id="email" class="textbox" name="email" type="text" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <label for="message">Your message:</label><br />
		            <textarea id="message" class="textarea" name="message" rows="7" cols="50" ></textarea>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right;"><input id="submit_button" type="submit" value="Submit" class="button" /></td>
            </tr>
        </table>
        <div style="display: block; height: 380px;"></div>
    </form>
</asp:Content>
