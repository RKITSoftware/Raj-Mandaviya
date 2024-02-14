using System.Web.Http;

namespace Cors.Controllers
{
    public class CorsController : ApiController
    {
        [HttpGet]
        [Route("api/cors/home")]
        public IHttpActionResult Home()
        {
            return Ok("This is home");
        }
    }
}
