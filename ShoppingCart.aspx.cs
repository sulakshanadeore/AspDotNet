using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookieRead = Request.Cookies["cart"];
            int cnt=cookieRead.Values.Count;
            //for (int i = 0; i < cnt; i++)
            //{
            //    string s = cookieRead.Values[i].ToString();
            //    ListBox1.Items.Add(s);
            //}
            //for (int i = 0; i < cnt; i++)
            //{
            //    [i]
            //}

            NameValueCollection v = cookieRead.Values;
            foreach (var item in v)
            {
                ListBox1.Items.Add(item.ToString());
               
            }

            //NameObjectCollectionBase.KeysCollection n = cookieRead.Values.Keys;
            //foreach (var item in n)
            //{
            //    ListBox2.Items.Add(item.ToString());
            //}

        }
    }
}