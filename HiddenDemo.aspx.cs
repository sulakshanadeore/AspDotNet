using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class HiddenDemo : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["marks"] = 0;
            string ans=RadioButtonList1.SelectedValue;
            if (ans==HiddenField1.Value)
            {
                ViewState["marks"] = 5;
            }
            ans = RadioButtonList2.SelectedValue;
            if (ans == HiddenField2.Value)
            {
                ViewState["marks"] = Convert.ToInt32(ViewState["marks"])+ 5;
            }

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Visible = true;
            TextBox1.Text = ViewState["marks"].ToString();
        }

      
    }
}