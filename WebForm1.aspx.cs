using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppToCommunicatewithWCF.ServiceReference1;
namespace AppToCommunicatewithWCF
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new Service1Client();
            int ans=client.AddNos(100, 234);
            Response.Write(ans);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            Product p = new Product();
            p.ProductName = "Anothr Product";
            p.ProductPrice = 344;
            p.ProductQty = "12";

            bool ans=client.InsertProduct(p);
            if (ans)
            {
                Response.Write("Successfully inserted");
            }
            else
            {
                Response.Write("Some error occured");
            }
        }
    }
}