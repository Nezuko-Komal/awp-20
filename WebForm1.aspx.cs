using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication13
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = "data source=PC-22;initial catalog=college;uid=sa;pwd=Admin123";
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from student";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

         protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow r = GridView1.SelectedRow;
            GridView1.SelectedRow.BackColor = System.Drawing.Color.Red;
            TextBox1.Text = r.Cells[1].Text;
            TextBox2.Text = r.Cells[2].Text;
            TextBox3.Text = r.Cells[3].Text;
            TextBox4.Text = r.Cells[4].Text;
        }
    }
}
}



