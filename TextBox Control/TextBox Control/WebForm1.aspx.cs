using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextBox_Control
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox2.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Hello nice to meet you" + TextBox1.Text);
        }
    }
}