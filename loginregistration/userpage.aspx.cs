using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class userpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["email"].ToString();
        Label2.Text = Request.Cookies["email1"].Value.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("category.aspx");
    }
}