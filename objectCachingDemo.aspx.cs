using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;
namespace CachingDemo
{
    public partial class objectCachingDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //   Cache.Add();
            // Cache.Insert();
            if (!Page.IsPostBack)
            {
                Response.Write("First time ");
            }
            else
            {
                Response.Write("Page posted back");
            }
            if (Cache["mydata"]==null)
            {
                Response.Write("Crateing the Cache ...." + "<br/>" + DateTime.Now.ToLongTimeString() + " & Storing the item for 20 secs with no dependencies "  );
                Employee obj = new Employee();
                obj.Empid = 1;
                obj.Empname = "Selvi";
                Cache.Insert("mydata", obj, null, DateTime.MaxValue, TimeSpan.FromSeconds(10));
            }
            else
            {
                Response.Write("Retrieving the data ");
                Employee obj1 = (Employee)Cache["mydata"];
                Response.Write("<br/>" + " data is at " + obj1.Empid  + " & Empname = " + obj1.Empname  );
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Sliding Expiration is used to remove the item from the cache when it is not used for the Timespan
            
        }
    }
}