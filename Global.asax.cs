using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication3
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["hits"] = 0;
        }


        void Session_Start(object sender, EventArgs e)
        {
            int i=Convert.ToInt32(Application["hits"]);
            i = i + 1;
            Application["hits"] = i;

        }
        void Session_End(object sender, EventArgs e)
        {
            
          //  Session.Contents.Clear();
            //Session.Remove();--- removing the key, so value will be deleted
           // Session.RemoveAll();
            Session.Clear();//Removes key-value pairs from the session collection
            Session.Abandon();//Cancels the session
        }

        void Application_End(object sender, EventArgs e)
        {
            Application["hits"] = 0;
        }
    }
}