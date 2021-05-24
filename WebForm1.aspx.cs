using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSideStateMgtDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Employee emp = new Employee();
            emp.Empid= Convert.ToInt32(TextBox1.Text);
            //Session store object types
            //by default sessions use cookies to store the data, but on the server side
            Session["mydata"] = emp.Empid;

        }
    }
}