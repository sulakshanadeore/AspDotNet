using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class ProductSender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = TextBox1.Text;
            string name = TextBox2.Text;

            Response.Redirect("~/ProductReceiver.aspx?prodid=" + id + "&prodname=" + name  + "&price="+  TextBox3.Text);
        }
    }
}