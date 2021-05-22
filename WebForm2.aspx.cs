using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSideControlsDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = DropDownList1.SelectedValue;
            switch (s)
            {
                case "View1":
                    MultiView1.SetActiveView(View1);
                    break;
                case "View2":
                    MultiView1.SetActiveView(View2);
                    break;
                case "View3":
                    MultiView1.SetActiveView(View3);
                    break;

                default:
                    break;
            }
        }
    }
}