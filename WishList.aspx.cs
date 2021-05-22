using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(txtprodname.Text);
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtprodname.Text = ListBox1.Items[ListBox1.SelectedIndex].Text;
        }
        static List<string> items = new List<string>();
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            
            HttpCookie cookie = new HttpCookie("cart");
            NameValueCollection nv = new NameValueCollection();
            foreach (var item in items)
            {
                ListItem itemname=ListBox1.Items.FindByText(item);
                double price=Convert.ToInt32(itemname.Value);
                nv.Add(item, price.ToString());
            
            }
            
            cookie.Values.Add(nv);
            
            Response.Cookies.Add(cookie);

            cookie.Expires = DateTime.Now.AddMinutes(5);
            Button3.Enabled = true;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           
            items.Add(txtprodname.Text);
            Response.Write(items.Count);
            Button2.Enabled = true;
        }
    }
}