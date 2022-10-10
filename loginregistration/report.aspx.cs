using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection con = new SqlConnection("Data Source = DESKTOP - MATFCL9\\SQLEXPRESS; Initial Catalog = studentregistration; User ID = sa; Password=sa123");
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        try
        {
            //  Label1.Text = DropDownList1.SelectedIndex.ToString();
            con.Open();
            string str = "select * from tbl_subcat ";
            //SqlCommand cmd = new SqlCommand(str, con);
            // cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
           
            da.Fill(ds, "tbl_sucat");
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            con.Close();
        
        }
        catch (Exception ex) {
            Response.Write(ex.Message);
        }
    }
}