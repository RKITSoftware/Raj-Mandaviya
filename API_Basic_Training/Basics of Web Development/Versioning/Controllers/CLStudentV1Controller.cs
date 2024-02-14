using System.Web.Http;

namespace Versioning_W_QS.Controllers
{
    public class CLStudentV1Controller : ApiController
    {
        /// <summary>
        /// Get old data to old customers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("api/v1/student/getdata")]
        public IHttpActionResult GetData()
        {
            return Ok("Hello this is full data for version 1");
        }

        /// <summary>
        /// Get data by ID
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("api/v2/student/getdata")]
        public IHttpActionResult GetById(int id)
        {
            return Ok($"Hello, {id}'s data for version 1");
        }

        
        
    }
}
