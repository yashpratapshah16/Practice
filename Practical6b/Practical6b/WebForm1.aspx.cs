using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical6b
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Practice\Practical6b\Practical6b\App_Data\Database1.mdf;Integrated Security=True");
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("select * from emp", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            con.Close();
        }
    }
}