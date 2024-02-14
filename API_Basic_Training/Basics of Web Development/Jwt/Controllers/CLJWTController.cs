using Jwt.Buisness_Logic;
using Jwt.Models;
using System.Web.Http;

namespace Jwt.Controllers
{
    /// <summary>
    /// Manages JWT related Operations
    /// </summary>
    public class CLJWTController : ApiController
    {
        private BLJwt objBLJwt;
        public CLJWTController()
        {
            objBLJwt = new BLJwt();
        }
        /// <summary>
        /// Endpoint to generate Jwt token 
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Jwt token</returns>
        [HttpPost]
        [Route("api/jwt/login")]
        public IHttpActionResult GetToken(Users objUsers)
        {
            //Checks Username and password
            bool isValidated = BLJwt.ValidateUser(objUsers.Username, objUsers.Password);

            if (!isValidated)
            {
                return Unauthorized();
            }
            string jwtToken = objBLJwt.GenerateJwt(objUsers.Username);
            return Ok(jwtToken);
        }

        /// <summary>
        /// Endpoint to verify JWT Token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/jwt/verify")]
        public IHttpActionResult VerifyJWT(string token)
        {
            //string token = Request.Headers.Authorization.Parameter;
            string username = objBLJwt.VerifyJWT(token);
            if (username != null)
            {
                return Ok(username);
            }
            return Unauthorized();
        }

    }
}
