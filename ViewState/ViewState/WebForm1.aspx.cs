using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public int click_count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Text = "0";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            click_count = click_count + 1;
            TextBox1.Text = click_count.ToString();

        }
    }
}