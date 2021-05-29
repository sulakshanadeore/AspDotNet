using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwindDAL;
using NorthwindLibBAL;
using CachinginMvcDemo.Models;
namespace CachinginMvcDemo.Controllers
{
    public class CustomersController : Controller
    {
        CustomerDAL customerDAL = new CustomerDAL();
        // GET: Customers
        public ActionResult Index()
        {
            List<CustomerBAL> customerBALs=customerDAL.GetCustomers();

            List<CustomerModel> modelList = new List<CustomerModel>();
            foreach (var item in customerBALs)
            {
                CustomerModel cm = new CustomerModel();
                cm.CustID = item.CustID;
                cm.CustName = item.CustName;
                cm.CustCity = item.CustCity;
                modelList.Add(cm);
            }
            return View(modelList);
        }

        // GET: Customers/Details/5
        //[OutputCache(Duration =10,VaryByParam ="id")]
        [OutputCache(CacheProfile ="footercache")]
        public ActionResult Details(string id)
        {
            CustomerBAL customerBAL=customerDAL.GetCustomers(id);
            CustomerModel model = new CustomerModel();
            model.CustID = customerBAL.CustID;
            model.CustName = customerBAL.CustName;
            model.CustCity = customerBAL.CustCity;


            return View(model);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                CustomerBAL customer = new CustomerBAL();
                customer.CustID = collection.Get("CustID").ToString();
                customer.CustName = collection.Get("CustName").ToString();
                customer.CustCity = collection.Get("CustCity").ToString();

                customerDAL.AddCustomer(customer);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
