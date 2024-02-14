using Security.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Security.BasicAuth
{
    /// <summary>
    ///Checks if user is valid or not 
    /// </summary>
    public class ValidateUser
    {
        /// <summary>
        /// Checks user in Users List
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>True if validated or False if not</returns>
        public static bool Login(string username, string password)
        {
            return Users.GetUsers().Any(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.Password == password);
        }
        /// <summary>
        /// Checks user in Users List
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>User if validated or null if not</returns>
        public static Users GetUserDetails(string username, string password)
        {
            return Users.GetUsers().FirstOrDefault(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.Password == password);
        }
    }
}