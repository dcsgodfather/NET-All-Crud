using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class subcategory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-MATFCL9\\SQLEXPRESS;Initial Catalog=studentregistration;User ID=sa;Password=sa123");

    protected void btninsert_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string str = "insert into tbl_subcat values('"+DropDownList1.SelectedValue+"','" + txtsubcat.Text + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            txtsubcat.Text = "";
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtsubcat.Text = GridView1.SelectedRow.Cells[3].Text;
        DropDownList1.SelectedItem.Text = GridView1.SelectedRow.Cells[2].Text;
        HiddenField1.Value= GridView1.SelectedRow.Cells[1].Text;
    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string str = "delete from  tbl_subcat where sid='" + HiddenField1.Value + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            txtsubcat.Text = "";
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string str = "update  tbl_subcat set cid='"+ DropDownList1.SelectedIndex + "',sname='"+ txtsubcat.Text + "' where sid='" + HiddenField1.Value + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            txtsubcat.Text = "";
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}