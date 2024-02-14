using System.Collections.Generic;

namespace Jwt.Models
{
    public class Users
    {
        public string Username { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// returns user list
        /// </summary>
        /// <returns></returns>
        public static List<Users> GetUsers()
        {
            List<Users> users = new List<Users>()
            {
                new Users { Username = "raj", Password = "raj123",  },
                new Users{ Username = "dev", Password = "dev123" },
                new Users { Username = "aum", Password = "aum123" }

            };
            return users;
        }
    }
}