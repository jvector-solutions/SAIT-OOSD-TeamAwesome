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
                    <asp:DropDownList ID="ddlProvince" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="AB">Alberta</asp:ListItem>
                        <asp:ListItem Value="BC">British Columbia</asp:ListItem>
                        <asp:ListItem Value="MB">Manitoba</asp:ListItem>
                        <asp:ListItem Value="NB">New Brunswick</asp:ListItem>
                        <asp:ListItem Value="NL">Newfoundland and Labrador</asp:ListItem>
                        <asp:ListItem Value="NT">Nortwest Territories</asp:ListItem>
                        <asp:ListItem Value="NS">Nova Scotia</asp:ListItem>
                        <asp:ListItem Value="NU">Nunavut</asp:ListItem>
                        <asp:ListItem Value="ON">Ontario</asp:ListItem>
                        <asp:ListItem Value="PE">Prince Edward Island</asp:ListItem>
                        <asp:ListItem Value="QC">Quebec</asp:ListItem>
                        <asp:ListItem Value="SK">Saskatchewan</asp:ListItem>
                        <asp:ListItem Value="YT">Yukon</asp:ListItem>
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
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPostalCode" ErrorMessage="Please enter your postal code." style="color: #FF0000" Display="Dynamic"></asp:RequiredFieldValidator>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPostalCode" Display="Dynamic" ErrorMessage="Ex. A1A 1A1" ValidationExpression="/^[A-Z]{1}[0-9]{1}[A-Z]{1}\s[0-9]{1}[A-Z]{1}[0-9]{1}$/i"></asp:RegularExpressionValidator>
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
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtHomePhone" ErrorMessage="Please enter your home phone number." style="color: #FF0000" Display="Dynamic"></asp:RequiredFieldValidator>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtHomePhone" Display="Dynamic" ErrorMessage="e.g. 1112223344" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
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
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        <br />
        <br />
        <asp:Button ID="btnClear" runat="server" CausesValidation="False" OnClick="btnClear_Click" Text="Clear" />
        <br />
        <br />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
        <br />
        <br />
    </form>
</asp:Content>
