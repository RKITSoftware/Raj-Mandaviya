using System.Web.Http;

namespace Versioning_W_URI.Controllers
{
    public class CLStudentController : ApiController
    {
        /// <summary>
        /// Get old data to old customers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/v1/student/getdata")]
        public IHttpActionResult GetOldData()
        {
            return Ok("Hello, This is old data from the archives");
        }

        /// <summary>
        /// Get data by ID
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/v2/student/getdata")]
        public IHttpActionResult GetNewData()
        {
            return Ok($"Hello, This brand new fresh data straight from the showroom");
        }

    }
}
