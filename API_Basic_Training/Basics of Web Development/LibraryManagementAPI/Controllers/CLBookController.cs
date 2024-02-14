using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Web.Http;
using LibraryManagementAPI.Helpers;
using LibraryManagementAPI.Models;
using LibraryManagementAPI.Helpers.BasicAuth;

namespace LibraryManagementAPI.Controllers
{
    /// <summary>
    /// Handle book related operations
    /// </summary>
    [BasicAuthentication]
    public class CLBookController : ApiController
    {
        private readonly BLLibraryService objLibraryService;
        CLBookController()
        {
            //Set LibraryService instace
            objLibraryService = BLLibraryService.Instance;
        }

        /// <summary>
        /// Add new lstBooks
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [BasicAuthorization(Roles = "Admin")]
        [HttpPost]
        [Route("api/book/addbook")]
        public IHttpActionResult AddBook([FromBody] JObject data)
        {
            //Validate data
            if (data == null || data["bookAuthor"] == null || data["bookName"] == null)
            {
                return BadRequest("Invalid Request Body");
            }
            objLibraryService.AddBook(data);
            return Ok(data);
        }

        /// <summary>
        /// Get all lstBooks and add lstBooks to cache
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/book/getbooks")]        
        [BasicAuthorization(Roles = "Admin,Member")]
        public IHttpActionResult GetBooks()
        {
            List<Book> lstBooks = objLibraryService.GetBooks();
            if (lstBooks == null)
            {
                return NotFound();
            }
            Caches.Add("cachedBooks",lstBooks);
            return Ok(lstBooks);
        }
        /// <summary>
        /// Get all lstBooks from Cache
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/book/getbooksfromcache")]
        public IHttpActionResult GetBooksFromCache()
        {
            object lstBooks = Caches.Get("cachedBooks");
            if (lstBooks == null)
            {
                return NotFound();
            }
            return Ok(lstBooks);
        }

        /// <summary>
        /// Get Single book using bookID
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/book/getbook")]
        [BasicAuthorization(Roles = "Admin,Member")]
        public IHttpActionResult GetBook(int bookID)
        {
            Book objBook = objLibraryService.GetBook(bookID);
            if (objBook == null)
            {
                return NotFound();
            }
            return Ok(objBook);
        }

        /// <summary>
        /// Update single book 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [BasicAuthorization(Roles = "Admin")]
        [HttpPut]
        [Route("api/book/updatebook")]
        public IHttpActionResult UpdateBook([FromBody] JObject data)
        {

            if (data == null || data["bookID"] == null || data["bookAuthor"] == null || data["bookName"] == null)
            {
                return BadRequest("Invalid Request Body");
            }

            if (objLibraryService.UpdateBook(data))
            {
                return Ok("Book Updated");
            }
            else
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Delete book using bookID
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns></returns>
        [BasicAuthorization(Roles = "Admin")]
        [HttpDelete]
        [Route("api/book/deletebook")]
        public IHttpActionResult DeleteBook(int bookID)
        {
            if (objLibraryService.RemoveBook(bookID))
            {
                return Ok();
            }
            return BadRequest("Book not found");
        }
    }
}
