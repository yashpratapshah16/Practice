using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question12
{
    class Furniture
    {
        public string name;
        public string manu;
        public string cost;

        public Furniture(string name, string manu, string cost)
        {
            this.name = name;
            this.manu = manu;
            this.cost = cost;
        }
    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Session["s1"] = new Furniture("chair", "chair manu", "100");
                Session["s2"] = new Furniture("table", "table manu", "1000");
                Session["s3"] = new Furniture("sofa", "sofa manu", "10000");

                ListBox1.Items.Add(((Furniture)Session["s1"]).name);
                ListBox1.Items.Add(((Furniture)Session["s2"]).name);
                ListBox1.Items.Add(((Furniture)Session["s3"]).name);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex == 0)
            {
                Label1.Text = ((Furniture)Session["s1"]).manu;
                Label2.Text = ((Furniture)Session["s1"]).cost;

            }
            else if (ListBox1.SelectedIndex == 1)
            {
                Label1.Text = ((Furniture)Session["s2"]).manu;
                Label2.Text = ((Furniture)Session["s2"]).cost;
            }
            else if (ListBox1.SelectedIndex == 2)
            {
                Label1.Text = ((Furniture)Session["s3"]).manu;
                Label2.Text = ((Furniture)Session["s3"]).cost;
            }
        }
    }
}