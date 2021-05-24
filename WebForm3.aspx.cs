using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Request URL= " + HttpContext.Current.Request.Url + "<br/>");
            Response.Write("Session Count= " + HttpContext.Current.Session.Count+ "<br/>");
            Response.Write("Current Time stamp= " + HttpContext.Current.Timestamp + "<br/>");
            Response.Write("Is debug enabled = " + HttpContext.Current.IsDebuggingEnabled + "<br/>");
            Response.Write("Username  = " + HttpContext.Current.User.Identity.Name + "<br/>");
            Response.Write("Mode  = " + HttpContext.Current.User.Identity.AuthenticationType + "<br/>");

        }
    }
}