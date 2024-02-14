using LibraryManagementAPI.Helpers;
using LibraryManagementAPI.Helpers.BasicAuth;
using Newtonsoft.Json.Linq;
using System.Security.Claims;
using System.Web.Http;

namespace LibraryManagementAPI.Controllers
{
    /// <summary>
    /// Handles Borrow/Return Transactions
    /// </summary>
    [BasicAuthentication]
    public class CLTransactionController : ApiController
    {
        #region Private members
        /// <summary>
        /// Library Service Instance
        /// </summary>
        private readonly BLLibraryService lib;
        #endregion

        #region Constructor
        CLTransactionController()
        {
            //Set LibraryService instance
            lib = BLLibraryService.Instance;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Get Current Loggedin Username
        /// </summary>
        /// <returns>Username</returns>
        private string GetCurrentUser()
        {
            ClaimsPrincipal currentUser = User as ClaimsPrincipal;
            if (currentUser != null)
            {
                var userName = currentUser.FindFirst(ClaimTypes.Name)?.Value;

                return userName;
            }
            return null;
        }
        #endregion

        /// <summary>
        /// Borrow Book using CurrentUsername, Bookid
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [BasicAuthorization(Roles = "Member")]
        [HttpPost]
        [Route("api/transaction/borrow-book")]
        public IHttpActionResult BorrowBook(JObject data)
        {
            if (!lib.BorrowBook(GetCurrentUser(),data))
            {
                return BadRequest("Book unavailable");
            }
            return Ok("Book Borrowed");
        }

        /// <summary>
        /// Return Book Using CurrentUsername, BookID
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [BasicAuthorization(Roles = "Member")]
        [HttpPost]
        [Route("api/transaction/return-book")]
        public IHttpActionResult ReturnBook(JObject data)
        {
            if (!lib.ReturnBook(GetCurrentUser(),data))
            {
                return BadRequest("Book not found or not borrowed");
            }
            return Ok("Book Returned");
        }

        /// <summary>
        /// Get all Borrow/Return transactions
        /// </summary>
        /// <returns></returns>
        [BasicAuthorization(Roles = "Admin")]
        [HttpGet]
        [Route("api/transaction/get-transactions")]
        public IHttpActionResult GetTransactions()
        {
            return Ok(lib.GetTransactions());
        }
    }
}
