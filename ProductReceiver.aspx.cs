using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class ProductReceiver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text=Request.QueryString["prodid"];
            TextBox2.Text = Request.QueryString["prodname"];
            TextBox3.Text = Request.QueryString["price"];
        }
    }
}