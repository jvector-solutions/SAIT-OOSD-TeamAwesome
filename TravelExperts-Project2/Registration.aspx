<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<asp:Content id="Content1" ContentPlaceHolderID="headPlaceHolder" runat="server"></asp:Content>

<asp:Content id="Content2" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <!-- Enter content below -->
    <form id="formRegistration" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>First Name</td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Please enter your first name." style="color: #FF0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Please enter your last name." style="color: #FF0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Address</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAddress" ErrorMessage="Please enter your address." style="color: #FF0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>City</td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCity" ErrorMessage="Please enter your city." style="color: #FF0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Province</td>
                <td>
                    <asp:DropDownList ID="ddlProvince" runat="server">
                        <asp:ListItem>AB</asp:ListItem>
                        <asp:ListItem>BC</asp:ListItem>
                        <asp:ListItem>MB</asp:ListItem>
                        <asp:ListItem>NB</asp:ListItem>
                        <asp:ListItem>NL</asp:ListItem>
                        <asp:ListItem>NS</asp:ListItem>
                        <asp:ListItem>ON</asp:ListItem>
                        <asp:ListItem>PE</asp:ListItem>
                        <asp:ListItem>QC</asp:ListItem>
                        <asp:ListItem>SK</asp:ListItem>
                        <asp:ListItem>NT</asp:ListItem>
                        <asp:ListItem>NU</asp:ListItem>
                        <asp:ListItem>YT</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Postal Code</td>
                <td>
                    <asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPostalCode" ErrorMessage="Please enter your postal code." style="color: #FF0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Country</td>
                <td>
                    <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCountry" ErrorMessage="Please enter your country." style="color: #FF0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Home Phone</td>
                <td>
                    <asp:TextBox ID="txtHomePhone" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtHomePhone" ErrorMessage="Please enter your home phone number." style="color: #FF0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Business Phone</td>
                <td>
                    <asp:TextBox ID="txtBusinessPhone" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>Email Address</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
                <td rowspan="2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="Your passwords do not match." style="color: #FF0000"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>Confirm Password</td>
                <td>
                    <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
        <br />
    </form>
</asp:Content>
