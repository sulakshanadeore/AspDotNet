using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo1.Controllers
{
  
    public class ValuesController : ApiController
    {
        // GET api/values
        static List<string> list = new List<string>() { "Hello", "World", "Welcome" };
  
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };
            return list;
        }

        // GET api/values/5
        public string Get(int id)
        {
            string v = null;
            if (id == 1)
            {
                v = "One";

            }
            else if (id == 2)
            { v = "Two"; }
            else
            {
                v = "Not accepted";
            }
            return v;
        }

        // POST api/values
        //[EnableCors(origins: "*", headers: "*", methods: "*")]
        public void Post([FromBody] string value)
        {
            //formcollection
            list.Add(value);
        }

        // PUT api/values/5
        //[EnableCors(origins: "*", headers: "*", methods: "*")]
        public void Put(int id, [FromBody] string value)
        {


            list.RemoveAt(id);
            list.Insert(id, value);
        }

        // DELETE api/values/5
       // [EnableCors(origins: "*", headers: "*", methods: "*")]
        public void Delete(int id)
        {
            list.RemoveAt(id);
        }
    }
}
