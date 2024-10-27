using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical8b
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(TextBox1.Text);
                if (age < 1 || age > 100)
                {
                    throw new Exception("Please Enter a Valid Age!");
                }
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alert", "alert('You have Entered a Valid Age:')", true);
            }
            catch (Exception ex) {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(),ex.Message, "alert('" + ex.Message+ "')", true);
                TextBox1.Text = "";
                TextBox1.Focus();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 1;
                int b = 0;
                int c;
                if (b == 0)
                {
                    throw new DivideByZeroException("Value of b is 0");
                }
                c = a / b;
                Label3.Text = c.ToString();
            }
            catch (DivideByZeroException ex) { 
                Label3.Text=ex.Message;
            }
                
        }
    }
}