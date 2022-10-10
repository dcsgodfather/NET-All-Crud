using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
//using System.Configuration;

public partial class registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
    // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-MATFCL9\\SQLEXPRESS;Initial Catalog=studentregistration;User ID=sa;Password=sa123");
    protected void btnregistrion_Click(object sender, EventArgs e)
    {
        try {
            con.Open();
            string unm = txtunm.Text;
            string email = txtemail.Text;
            string pwd = txtpwd.Text;
            DateTime date = Convert.ToDateTime(txtdate.Text);
            string course = DropDownList1.SelectedItem.ToString();
            string gender="";
            if (RadioButton1.Checked)
            {
                gender = "Male";
            }
            else if (RadioButton2.Checked) {
                gender = "Female";
            }
            
            string str = "insert into tbluser values('"+unm+"','"+pwd+"','"+ gender + "','"+email+"','"+date+"','"+course+"')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            txtdate.Text = "";
            txtemail.Text = "";
            txtpwd.Text = "";
            txtunm.Text = "";
            Response.Redirect("login.aspx");
        }
        catch (Exception ex) {
            Response.Write(ex.Message);
        }
    }
}