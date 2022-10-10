using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class category : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
       
    }
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-MATFCL9\\SQLEXPRESS;Initial Catalog=studentregistration;User ID=sa;Password=sa123");
   // int cname;
    //string cid;
    protected void btninsert_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string str = "insert into tblcategory values('"+txtcnm.Text+"')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            txtcnm.Text = "";
            GridView1.DataBind();
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
        
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        // cid = ;
        
        txtcnm.Text = GridView1.SelectedRow.Cells[2].Text;
        HiddenField1.Value = GridView1.SelectedRow.Cells[1].Text;
    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            //Label1.Text = HiddenField1.Value;
            string str = "delete from tblcategory where cid='" + HiddenField1.Value + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            txtcnm.Text = "";
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {

        try
        {
            con.Open();
            //Label1.Text = HiddenField1.Value;
            string str = "update tblcategory set cname='"+txtcnm.Text+"' where cid='" + HiddenField1.Value + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            txtcnm.Text = "";
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}