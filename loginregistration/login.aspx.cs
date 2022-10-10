using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-MATFCL9\\SQLEXPRESS;Initial Catalog=studentregistration;User ID=sa;Password=sa123");

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        try {
            con.Open();
            string email = txtemail.Text;
            string pwd = txtpwd.Text;
            Session.Add("email", email);
            Response.Cookies["email1"].Value = email;
            string str = "select * from tbluser where email='" + email + "' and password='" + pwd + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
           
            txtemail.Text = "";
            txtpwd.Text = "";
            
            Response.Redirect("userpage.aspx");
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}