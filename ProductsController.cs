using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FristMVCApp.Models;
namespace FristMVCApp.Controllers
{
    public class ProductsController : Controller
    {

        static List<NWProd> list = new List<NWProd>();
         static ProductsController()
        {
            list.Add(new NWProd { Prodid=1,Prodname="A",Price=10});
            list.Add(new NWProd { Prodid =2, Prodname = "B", Price = 20 });
            list.Add(new NWProd { Prodid = 3, Prodname = "C", Price = 30 });

        }

        // GET: Products
        public ActionResult Index()
        {

            return View(list);
        }

        public ActionResult CreateProduct()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(NWProd prod)
        {
            list.Add(prod);
            return View();
        }

        public ActionResult EditProduct(int id)
        {
            NWProd datafound = list.Find(p1 => p1.Prodid == id);
            return View(datafound);
        }

        [HttpPost]
        public ActionResult EditProduct(int id,NWProd p)
        {
            NWProd datafound=list.Find(p1 => p1.Prodid == id);
            datafound.Prodname = p.Prodname;
            datafound.Price = p.Price;
            return RedirectToAction("Index");
        }


        public ActionResult ProductDetails(int id)
        {

            NWProd datafound = list.Find(p1 => p1.Prodid == id);
            return View(datafound);
        }

        
        public ActionResult DeleteProduct(int id)
        {
            NWProd datafound = list.Find(p1 => p1.Prodid == id);

            return View(datafound);
        }
        [HttpPost]
        public ActionResult DeleteProduct(int id,NWProd p)
        {
            NWProd datafound = list.Find(p1 => p1.Prodid == id);
            list.Remove(datafound);
            return View();
        }




    }
}