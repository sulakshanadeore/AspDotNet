using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //Do a thing only once in the life time of the page, even if the page post backs any number of time

                DropDownList1.Items.Add("1");
                DropDownList1.Items.Add("2");
                DropDownList1.Items.Add("3"); 
                DropDownList1.Items.Add("4"); 
                DropDownList1.Items.Add("5"); 
                DropDownList1.Items.Add("6");
                DropDownList1.Items.Add("7");


                ListBox1.Items.Add("1");
                ListBox1.Items.Add("2");
                ListBox1.Items.Add("3");
                ListBox1.Items.Add("4");
                ListBox1.Items.Add("5");
                ListBox1.Items.Add("6");
                ListBox1.Items.Add("7");


                ListItem item1 = new ListItem("Tea","10");
                DropDownList3.Items.Add(item1);
                ListItem item2= new ListItem("Coffee", "15");
                DropDownList3.Items.Add(item2);
                ListItem item3 = new ListItem("Horlicks", "20");
                DropDownList3.Items.Add(item3);
                DropDownList3.Items.Add(new ListItem { Text="Bru coffee",Value="25"});


            }


            // Response.Write("Hello");

            //if (IsPostBack)
            //{
            //    Response.Write("Welcome back");
            //}
            //else
            //{
            //    Response.Write("Hello");
            //}
            //if (!IsPostBack)
            //{
            //    Response.Write("Hello");
            //}
            //else
            //{
            //    Response.Write("Welcome back");
            //}

            //if (!Page.IsPostBack)
            //{

            //    Response.Write("Hello");
            //}
            //else
            //{
            //    Response.Write("Welcome back");
            //}


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(DropDownList1.SelectedValue);
            
            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write(DropDownList2.SelectedValue);
            Response.Write(DropDownList2.SelectedItem.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("Price=" + DropDownList3.SelectedValue);
            Response.Write("<br/>");
            Response.Write("Item name=" + DropDownList3.SelectedItem.Text);
        }
    }
}  