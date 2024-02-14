using System.Net.Http;
using System.Net;
using System.Web.Http;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;

namespace HTTP_Caching.Controllers
{
    public class CacheController : ApiController
    {
        /// <summary>
        /// Sets a cache-control header
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/v1/cache/getdata")]
        public HttpResponseMessage Getdata()
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent("This is your cached response");
            response.Headers.CacheControl = new CacheControlHeaderValue();
            response.Headers.CacheControl.MaxAge = new TimeSpan(0, 10, 0);  // 10 min. or 600 sec.
            response.Headers.CacheControl.Public = true;
            return response;
        }

        readonly string usersCacheKey = "111A";
        /// <summary>
        /// Returns List of Users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/v2/cache/getdata")]
        public IHttpActionResult GetdataV2()
        {
            List<string> lstUsers = new List<string>
            {
                "Raj",
                "Aum"
            };

            Caches.Add(usersCacheKey, lstUsers);
            return Ok(lstUsers);
        }


        /// <summary>
        /// Returns List of Users from cache
        /// </summary>
        /// <returns></returns>
        [Route("api/v2/cache/get-user-from-cache")]
        public IHttpActionResult GetUserFromCache()
        {
            object usersFromCache = Caches.Get(usersCacheKey);
            return Ok(usersFromCache);
        }
    }
}

