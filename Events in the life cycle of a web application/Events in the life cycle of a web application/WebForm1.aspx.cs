using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Events_in_the_life_cycle_of_a_web_application
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Number of applications :" + Application["TotalApplications"]);
            Response.Write("<br/>");
            Response.Write("Number of Users: " + Application["TotalUsers"]);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}