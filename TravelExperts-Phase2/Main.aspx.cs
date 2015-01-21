using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    int custID = -1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustomerID"] != null)
        {
            custID = (int)Session["CustomerID"];
            ddlCustomers.SelectedValue = custID.ToString();
        }
    }
    protected void ddlCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CustomerID"] = Convert.ToInt32(ddlCustomers.SelectedValue);
    }
}