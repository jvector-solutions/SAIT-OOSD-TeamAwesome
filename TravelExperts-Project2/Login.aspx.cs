using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExperts;

public partial class Login : System.Web.UI.Page
{
    bool customerExists;
    Customer customer = new Customer();

    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        string custEmail = Login1.UserName;
        string custPassword = Login1.Password;

        //get user's password and email to check with database
        customerExists = CustomerDB.CheckPassword(custEmail, custPassword);

        if (customerExists)
        {
            Session["user"] = CustomerDB.GetCustomerByEmail(custEmail);

            if (Session["user"] != null)
            {
                customer = (Customer)Session["user"];
            }
            Response.Redirect("Main.aspx");//Redirecting user to main page after loggin
        }
        else
        {
            //FailureText.Text = "Invalid username or password.";
            //ErrorMessage.Visible = true;
        }
    }
}