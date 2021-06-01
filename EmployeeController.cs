using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using webapiInMvcCall.Models;

namespace webapiInMvcCall.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
                        
            IEnumerable<EmployeeViewModel> empdata = null;
           using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "http://localhost:60679/api/";
                
     var json = webClient.DownloadString("Values");
     var list = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(json);
                empdata = list.ToList();
                return View(empdata);
            }
        }

        public ActionResult Details(int id)
        {

            EmployeeViewModel empdata;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "http://localhost:60679/api/";

                var json = webClient.DownloadString("Values/" + id);
                //  var list = emp 
                empdata = JsonConvert.DeserializeObject<EmployeeViewModel>(json);
            }
            return View(empdata);
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeViewModel model)
        {
            
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.BaseAddress = "http://localhost:60679/api/";
                    var url = "Values/POST";
                    //webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
   webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string data = JsonConvert.SerializeObject(model);
                    var response = webClient.UploadString(url, data);
                  JsonConvert.DeserializeObject<EmployeeViewModel>(response);
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            EmployeeViewModel empdata;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "http://localhost:60679/api/";

                var json = webClient.DownloadString("Values/" + id);
                //  var list = emp 
                empdata = JsonConvert.DeserializeObject<EmployeeViewModel>(json);
            }
            return View(empdata);
            
        }


        public ActionResult EditEmployee(int id)
        {
            EmployeeViewModel empdata;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "http://localhost:60679/api/";

                var json = webClient.DownloadString("Values/" + id);
                //  var list = emp 
               empdata= JsonConvert.DeserializeObject<EmployeeViewModel>(json);
            }
                return View(empdata);
        }
        [HttpPost]
        public ActionResult Delete(int id,EmployeeViewModel model)
        {

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.BaseAddress = "http://localhost:60679/api/Values/"+ id;
                    var url = "Values/Delete";
                    //webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    //webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    //string data = JsonConvert.SerializeObject(model);

                    //var response = webClient.UploadString(webClient.BaseAddress, data);

                    //EmployeeViewModel modeldata = JsonConvert.DeserializeObject<EmployeeViewModel>(response);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult EditEmployee(int id,EmployeeViewModel model )
        {

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.BaseAddress = "http://localhost:60679/api/Values/1";
                    //var url = "Values/Put/" + id;
                    //webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string data = JsonConvert.SerializeObject(model);
                    
                    var response = webClient.UploadString(webClient.BaseAddress, data);
                    
                  EmployeeViewModel modeldata=JsonConvert.DeserializeObject<EmployeeViewModel>(response);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

    }

}
