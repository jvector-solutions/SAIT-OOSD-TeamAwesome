using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Package : System.Web.UI.Page
{
    string pkgID="default";
    protected void Page_Load(object sender, EventArgs e)
    {
        pkgID = (string)Session["PackageID"];
    }
}