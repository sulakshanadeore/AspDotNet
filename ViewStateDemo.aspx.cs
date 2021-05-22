using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ViewState["hits"] = 1;
                Label1.Text = ViewState["hits"].ToString();
            }
            else
            {
                
                Label1.Text=(Convert.ToInt32(ViewState["hits"]) +1).ToString();
                ViewState["hits"] = Convert.ToInt32(Label1.Text);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["name"] = TextBox3.Text;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox4.Text = ViewState["name"].ToString();
        }
    }
}