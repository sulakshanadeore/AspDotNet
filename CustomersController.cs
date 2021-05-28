using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StateMgtMVC.Models;

namespace StateMgtMVC.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            HttpCookie c=Request.Cookies["custdetails"];
            string custid = c["custid"].ToString();
            string custname = c["custname"].ToString();
            string city = c["city"].ToString();

            string custdetails = string.Concat(custid, custname, city);

            return Content(custdetails);
        }


        public ActionResult CreateCustomer()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateCustomer(Cust c)
        {
            HttpCookie cookie = new HttpCookie("custdetails");
            cookie.Values.Add("custid", c.Custid.ToString());
            cookie.Values.Add("custname", c.Custname);
            cookie.Values.Add("city", c.City);
            cookie.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Add(cookie);
            return Content("Cookie created");
        }

        public ActionResult ShowCustomer()
        {
            Cust c = new Cust();
            c.Custid = 101;
            c.Custname = "Samar";
            c.City = "Bangalore";
            ViewBag.mycustdata = "This is Gold Cusotmer";
            ViewBag.otherdata = 1;
            ViewData["impdata"] = "This is  important";
            return View(c);
        }



        public ActionResult ShowListCustomers()
        {
            List<Cust> custlist = new List<Cust>();
            custlist.Add(new Cust { Custid = 1, Custname = "Priya", City = "Vellore" });
            custlist.Add(new Cust { Custid = 2, Custname = "Riya", City = "Chennai" });
            custlist.Add(new Cust {Custid=3,Custname="Siya",City="Bangalore" });

            ViewBag.customerList = custlist;
            ViewData["clist"] = custlist;
            TempData.Keep();
            ViewBag.dt=TempData["todaysDate"];
            ViewData["peekdatetime"]=TempData.Peek("todaysDate");
            return View();
        }



        public ActionResult PassData()
        {
            TempData["todaysDate"] = DateTime.Now.ToLongDateString();
            return RedirectToAction("ReceiveData");
        }

        public ActionResult ReceiveData()
        {
            //ViewBag.dt=TempData["todaysDate"].ToString();
            TempData.Keep();
            return RedirectToAction("ShowListCustomers");
        }



    }
}