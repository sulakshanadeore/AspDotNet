using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFClientDemo.ServiceReference1;
namespace WCFClientDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ServiceReference1.Service1Client proxy = new Service1Client();
            //int ans=proxy.AddNos(10, 20);
            //TextBox1.Text = ans.ToString();
            ////string a=proxy.GetData(10);
            
            
            WebClient client = new WebClient();

            client.BaseAddress = "http://localhost:63002/Service1.svc/";
           

            Customer c2 = new Customer();
            c2.CustName = "Prithvi";
            string jsondata = JsonConvert.SerializeObject(c2);

            string data = client.DownloadString("http://localhost:63002/Service1.svc/CustomersJson");
            
            Customer d =JsonConvert.DeserializeObject<Customer>(data);
            TextBox2.Text = d.CustName;
            //Customer obj=proxy.GetDataUsingDataContract(c1);
            //TextBox2.Text = obj.CustName;
        }
    }
}