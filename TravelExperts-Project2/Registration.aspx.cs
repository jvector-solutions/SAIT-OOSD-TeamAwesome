using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExperts;

public partial class Registration : System.Web.UI.Page
{
    Customer newCustomer;
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //validate
        //make sure email is unique
        //pasword matches
        //create customer
        //login then redirect to next page
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        clearTextBoxes();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //cancel
    }
    private void clearTextBoxes()
    {
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtAddress.Text = "";
        txtCity.Text = "";
        ddlProvince.SelectedIndex = 0;
        txtPostalCode.Text = "";
        txtCountry.Text = "";
        txtHomePhone.Text = "";
        txtBusinessPhone.Text = "";
        txtEmail.Text = "";
        txtPassword.Text = "";
        txtConfirmPassword.Text = "";
    }
}