using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class ShowEmpInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie mydata = Request.Cookies["emp"];
            txtempid.Text = mydata["empid"].ToString();
            txtename.Text = mydata["ename"].ToString();

        }
    }
}