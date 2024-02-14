using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace ExceptionFilter.Controllers
{
    //[GlobalExceptionHandler]
    public class ExceptionController : ApiController
    {
        [Route("api/ex/getdata")]
        public IHttpActionResult GetData()
        {
            throw new Exception("Stack Overflow");
            //return Ok(Directory.GetCurrentDirectory());
        }
    }
}
