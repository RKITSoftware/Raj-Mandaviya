using LibraryManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace LibraryManagementAPI.Helpers.BasicAuth
{
    /// <summary>
    /// Validates User using username and password
    /// </summary>
    public class ValidateUser
    {
        #region Private Members
        /// <summary>
        /// Library Service Instance
        /// </summary>
        private readonly BLLibraryService lib;
        #endregion

        #region Constructor
        public ValidateUser() 
        {
            //Set LibraryService instace
            lib = BLLibraryService.Instance;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Checks user in Users List
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>True if validated or False if not</returns>
        public bool Login(string username, string password)
        {
            return lib.lstUsers.Any(element => (element.u01f02.Equals(username,StringComparison.OrdinalIgnoreCase) 
            && element.u01f03 == password));
        }

        /// <summary>
        /// Checks user in Users List
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>User if validated or null if not</returns>
        public Users GetUserDetails(string username, string password)
        {
            return lib.lstUsers.FirstOrDefault(user => user.u01f02.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.u01f03 == password);
        }
        #endregion
    }
}