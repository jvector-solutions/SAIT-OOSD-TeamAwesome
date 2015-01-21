using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    int custID;
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        custID = ddlCustomers.SelectedIndex;
    }
    protected void GoToPackages(object sender, EventArgs e)
    {
        //Session["PackageID"] = lsvCustomerPackages.SelectedDataKey;
        //Session["PackageID"] = lsvCustomerPackages.Items[lsvCustomerPackages];
            //.FindControl("Label2") as Label).Text;
        //Session["PackageID"] = GridView1.SelectedIndex;
        //Response.Redirect("Package.aspx");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        Session["PackageID"] = row.Cells[1].Text;
        Response.Redirect("Package.aspx");
    }
}