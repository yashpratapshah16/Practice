using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace question6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void FontfaceChange(object sender, EventArgs e)
        {
            Label1.Font.Name = ((RadioButton)sender).Text;
        }

        protected void FontsizeChange(object sender, EventArgs e)
        {
            Label1.Font.Size = int.Parse(((RadioButton)sender).Text);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedValue.ToString();
        }
    }
}