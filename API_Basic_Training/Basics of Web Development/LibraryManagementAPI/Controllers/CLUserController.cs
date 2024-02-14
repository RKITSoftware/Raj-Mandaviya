using LibraryManagementAPI.Helpers;
using LibraryManagementAPI.Helpers.BasicAuth;
using LibraryManagementAPI.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace LibraryManagementAPI.Controllers
{
    /// <summary>
    /// Handles User related operations
    /// </summary>
    [BasicAuthentication]
    [BasicAuthorization(Roles = "Admin")]
    public class CLUserController : ApiController
    {
        #region Private Members
        /// <summary>
        /// Library Service Instance
        /// </summary>
        private readonly BLLibraryService objLibraryService;
        #endregion

        #region Constructor
        public CLUserController()
        {
            //Set LibraryService instance
            objLibraryService = BLLibraryService.Instance;
        }
        #endregion

        /// <summary>
        /// Add user using username, password
        /// </summary>
        /// <param name="data"></param>
        /// <returns>OK or BadRequest</returns>
        [HttpPost]
        [Route("api/user/adduser")]
        public IHttpActionResult AddUser(JObject data)
        {
            if (data == null || data["username"] == null || data["password"] == null)
            {
                return BadRequest("Invalid Request Body");
            }
            objLibraryService.AddUser(data);
            return Ok(data);
        }

        /// <summary>
        /// Get all users for Admins
        /// </summary>
        /// <returns>Ok(lstUsers) or NotFound</returns>
        [HttpGet]
        [Route("api/v1/user/getusers")]
        public IHttpActionResult GetUsersV1()
        {
            List<Users> lstUsers = objLibraryService.GetUsers();
            if (lstUsers == null)
            {
                return NotFound();
            }
            return Ok(lstUsers);
        }

        /// <summary>
        /// Get user based on userID
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/user/getuser")]
        public IHttpActionResult GetUser(int userID)
        {
            Users objUser = objLibraryService.GetUser(userID);
            if (objUser == null)
            {
                return NotFound();
            }
            return Ok(objUser);
        }

        /// <summary>
        /// Update User
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/user/updateuser")]
        public IHttpActionResult UpdateUser(JObject data)
        {
            if (data == null || data["userID"] == null || data["username"] == null || data["password"] == null)
            {
                return BadRequest("Invalid Request Body");
            }
            if (objLibraryService.UpdateUser(data))
            {
                return Ok("User Updated");
            }
            else
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Delete User based on UserID
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("api/user/deleteuser")]
        public IHttpActionResult DeleteUser(int userID)
        {
            if (objLibraryService.RemoveUser(userID))
            {
                return Ok();
            }
            return NotFound();
        }

        /// <summary>
        /// Endpoint to generate Jwt token 
        /// </summary>
        /// <param name="objUsers"></param>
        /// <returns>Jwt token</returns>
        [AllowAnonymous]
        [HttpPost]
        [Route("api/jwt/login")]
        public IHttpActionResult GetToken(Users objUsers)
        {
            //Checks Username and password
            bool isValidated = BLJwt.ValidateUser(objUsers.u01f02, objUsers.u01f03);

            if (!isValidated)
            {
                return Unauthorized();
            }
            BLJwt objBLJwt = new BLJwt();
            string jwtToken = objBLJwt.GenerateJwt(objUsers.u01f02);
            return Ok(jwtToken);
        }

        /// <summary>
        /// Endpoint to verify JWT Token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet]
        [Route("api/jwt/verify")]
        public IHttpActionResult VerifyJWT(string token)
        {
            //string token = Request.Headers.Authorization.Parameter;
            BLJwt objBLJwt = new BLJwt();
            string username = objBLJwt.VerifyJWT(token);
            if (username != null)
            {
                return Ok(username);
            }
            return Unauthorized();
        }
    }
}
