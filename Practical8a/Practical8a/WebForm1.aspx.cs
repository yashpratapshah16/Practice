using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Practical8a
{
    public partial class WebForm1 : System.Web.UI.Page
    {   
        SqlConnection conn=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\Practice\\Practical8a\\Practical8a\\App_Data\\Database1.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
                SqlCommand cmd = new SqlCommand("insert into Sutdents values(@std_rollno, @std_name, @std_class, @std_phone, @std_email)", conn);
                cmd.Parameters.AddWithValue("@std_rollno", int.Parse(TextBox1.Text));
                cmd.Parameters.AddWithValue("@std_name", TextBox2.Text);
                cmd.Parameters.AddWithValue("@std_class", TextBox3.Text);
                cmd.Parameters.AddWithValue("@std_phone", Convert.ToInt64(TextBox4.Text));
                cmd.Parameters.AddWithValue("@std_email", TextBox5.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                Response.Write("Inserted successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Sutdents", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                string optop = "<Table>";
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        optop += "<tr><td>" + dr[0] + "</td><td>" + dr[1] + "</td><td>" + dr[2] + "</td><td>" + dr[3] + "</td><td>" + dr[4] + "</td><tr>";
                    }
                }
                optop += "</table>";
                conn.Close();
                Response.Write(optop);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}