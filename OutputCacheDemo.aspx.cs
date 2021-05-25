using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachingDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(10000);
            Label1.Text ="Page generated at  "  +  DateTime.Now.ToLongTimeString();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "Hello   " + txtname.Text;
        }
    }
}