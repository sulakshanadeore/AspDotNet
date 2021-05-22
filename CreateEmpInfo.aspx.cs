using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class CreateEmpInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("emp");
            cookie.Values.Add("empid", Convert.ToInt32(txtempid.Text).ToString());
            cookie.Values.Add("ename", txtename.Text);
            cookie.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Add(cookie);
            
            Response.Redirect("~/ShowEmpInfo.aspx");

        }
    }
}