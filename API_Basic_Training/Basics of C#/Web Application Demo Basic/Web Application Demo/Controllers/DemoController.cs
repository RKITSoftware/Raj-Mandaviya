using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_Application_Demo.Controllers
{
    public class DemoController : ApiController
    {
        public string Get()
        {
            return "This is a Demo Controller";
        }

        public string Get(int id)
        {
            Dictionary<int,string> data = new Dictionary<int, string>();
            data.Add(1, "Raj");
            data.Add(2, "Aum");
            return data[id];
        }

        public object Post([FromBody]JObject data)
        {
            return new
            {
                message = "User Created",
                Name = data["name"],
                Age = data["age"],
                Pets = data["pets"]
            };
        }
        public IHttpActionResult Put()
        {
            return Ok();
        }

        public object Delete(int id)
        {
            return NotFound();
        }
    }
}
