using Security.BasicAuth;
using Security.Models;
using System.Web.Http;

namespace Security.Controllers
{
    [BasicAuthentication]
    public class SecurityController : ApiController
    {
        [HttpGet]
        [Route("api/security/home")]
        [BasicAuthorization(Roles = "SDE")]
        public IHttpActionResult Home() //[FromBody]JObject data
        {
            return Ok("This is Home");
        }

        /// <summary>
        /// Only Admins can access All Users Data
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/security/user-data")]
        [BasicAuthorization(Roles = "ADMIN")]
        public IHttpActionResult GetUserData()
        {
            return Ok(Users.GetUsers());
        }
    }
}
