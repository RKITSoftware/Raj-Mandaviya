using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Security.Models
{   
    /// <summary>
    /// Defines a user
    /// </summary>
    public class Users
    {
        #region Public Properties
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        #endregion

        #region public methods
        /// <summary>
        /// returns user list
        /// </summary>
        /// <returns></returns>
        public static List<Users> GetUsers()
        {
            List<Users> users = new List<Users>()
            {
                new Users { Username = "raj", Password = "raj123", Role = "SDE" },
                new Users{ Username = "dev", Password = "dev123", Role = "SDE" },
                new Users { Username = "aum", Password = "aum123", Role = "ADMIN" }

            };
            return users;
        }
        #endregion
    }
}