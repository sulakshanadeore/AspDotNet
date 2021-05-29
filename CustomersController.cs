using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NorthwindDAL;
using NorthwindLibBAL;
using WebAPIDemo1.Models;
namespace WebAPIDemo1.Controllers
{
    public class CustomersController : ApiController
    {

        CustomerDAL dal = new CustomerDAL();
        // GET: api/Customers

        public List<CustomerModel> Get()
        {
            List<CustomerBAL> bal=dal.GetCustomers();
            List<CustomerModel> modellist = new List<CustomerModel>();
            foreach (var item in bal)
            {
                CustomerModel cm = new CustomerModel();
                cm.CustID = item.CustID;
                cm.CustName = item.CustName;
                cm.CustCity = item.CustCity;
                modellist.Add(cm);

            }

            return modellist;
        }

        // GET: api/Customers/5
        public CustomerModel Get(string id)
        {
            CustomerModel cm = new CustomerModel();
            CustomerBAL bdata = new CustomerBAL();
            bdata=dal.GetCustomers(id);
            cm.CustID=bdata.CustID;
            cm.CustName = bdata.CustName;
            cm.CustCity = bdata.CustCity;
            return cm;
        }

        // POST: api/Customers
        public void Post([FromBody]CustomerModel value)
        {
            CustomerBAL bal = new CustomerBAL();
            bal.CustID = value.CustID;
            bal.CustName = value.CustName;
            bal.CustCity = value.CustCity;
            dal.AddCustomer(bal);
        }

        // PUT: api/Customers/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Customers/5
        public void Delete(int id)
        {

        }
    }
}
