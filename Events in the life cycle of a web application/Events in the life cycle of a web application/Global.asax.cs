using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Events_in_the_life_cycle_of_a_web_application
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            Application["TotalApplications"] = 0;
            Application["TotalUsers"] = 0;
            Application["TotalApplications"] = (int)Application["TotalApplications"] + 1;
        }

        void Session_Start(object sender , EventArgs e)
        {
            Application["TotalUsers"] = (int)Application["TotalUsers"] + 1;
        }
         void Session_End (object sender , EventArgs e)
        {
            Application["TotalUsers"] = (int)Application["TotalUsers"] - 1;

        }
    }

}