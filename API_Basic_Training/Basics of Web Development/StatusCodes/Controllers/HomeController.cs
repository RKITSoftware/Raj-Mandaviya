using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StatusCodes.Controllers
{
    public class HomeController : ApiController
    {
        #region private variables
        static List<string> products = new List<string>
        {
            "Head Massager",
            "Hair Straightner",
            "Shampoo"
        };
        static List<string> adminEmails = new List<string>
        {
            "raj@gmail.com",
            "dev@gmail.com"
        };
        static List<string> users = new List<string>
        {
            "raj",
            "dev",
            "aum"
        };
        #endregion

        /// <summary>
        /// Returns Products if found or 404 if not 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult GetProducts()
        {
            if (products.Any())
            {
                return Ok(products);
            }
            else
            {
                return NotFound();
            }

        }

        /// <summary>
        /// Finds the product by taking id as input
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/statuscodes/find-product/{id:int}")]
        public IHttpActionResult FindProduct(int id)
        {
            if (products[id] != null)
            {
                return Ok(products[id]);
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Get Secure User data which can be accessed by admins
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/home/get-user-data")]
        public IHttpActionResult GetUserData()
        {
            // Add admins's email in Authorization header
            // Authorization: basic raj@gmail.com
            string userEmail;
            try
            {
                userEmail = Request.Headers.Authorization.Parameter;
            }
            catch (NullReferenceException)
            {
                return BadRequest("Header not set");
            }

            foreach (string adminEmail in adminEmails)
            {
                if (adminEmail == userEmail)
                {
                    return Ok(users);
                }
            }
            return Unauthorized();

        }

        /// <summary>
        /// takes username and inserts into users list
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/home/add-user")]
        public IHttpActionResult AddUser([FromBody] JObject data)
        {
            users.Add(data["username"].ToString()); //Adding user to users List
            return Created("", users);
        }

        /// <summary>
        /// takes username and id and updates into users list
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/home/update-user")]
        public IHttpActionResult UpdateUser([FromBody] JObject data)
        {
            users[Convert.ToInt32(data["id"])] = data["username"].ToString();
            return Ok(data["username"] + " updated successfully");
        }

        /// <summary>
        /// Deletes product with same index as id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("api/home/remove-product/{id:int}")]
        public IHttpActionResult RemoveProduct(int id)
        {
            products.RemoveAt(id);
            return Ok("product removed successfully");
        }
    }
}
