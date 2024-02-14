using LibraryManagementAPI.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementAPI.Helpers
{
    public class BLLibraryService
    {
        #region Private Members
        private static BLLibraryService _instance;  //Used to make the class Singleton
        /// <summary>
        /// Char for Borrow Transaction
        /// </summary>
        private readonly char charBorrow = 'B';

        /// <summary>
        /// Char for Return Transaction
        /// </summary>
        private readonly char charReturn = 'R';
        #endregion

        #region Public Properties
        /// <summary>
        /// Books List
        /// </summary>
        public List<Book> lstBooks { get; set; }
        /// <summary>
        /// Users List
        /// </summary>
        public List<Users> lstUsers { get; set; }
        /// <summary>
        /// Transaction List
        /// </summary>
        public List<Transaction> lstTransactions { get; set; }

        //Making the class singleton
        public static BLLibraryService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLibraryService();
                }
                return _instance;
            }
        }
        #endregion Public Properties

        #region Constructor
        public BLLibraryService()
        {
            lstBooks = new List<Book>
            {
                new Book() {
                    b01f01 = 1,
                    b01f02 = "Harry Potter",
                    b01f03 = "JK Rowling"
                },
                new Book() {
                    b01f01 = 2,
                    b01f02 = "Rich Dad Poor Dad",
                    b01f03 = "Robert Kiyosaki"
                }
            };
            lstUsers = new List<Users>
            {
                new Users() {
                    u01f01 = 1,
                    u01f02 = "raj",
                    u01f03 = "raj123",
                    u01f04 = "Member"

                },
                new Users()
                {
                    u01f01 = 2,
                    u01f02 = "aum",
                    u01f03 = "aum123",
                    u01f04 = "Admin"
                }
            };
            lstTransactions = new List<Transaction>();
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Adds a book to books List
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Result as bool</returns>
        public bool AddBook(JObject data)
        {
            Book objBook = new Book
            {
                b01f01 = lstBooks.Count + 1,
                b01f02 = data["bookName"].ToString(),
                b01f03 = data["bookAuthor"].ToString(),
            };

            lstBooks.Add(objBook);
            return true;
        }


        /// <summary>
        /// Get book list if it exists
        /// </summary>
        /// <returns>List<Book></returns>
        public List<Book> GetBooks()
        {
            if (lstBooks.Count == 0)
            {
                return null;
            }
            return lstBooks;
        }

        /// <summary>
        /// Get Book if it Exists
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns>Book or null if exists</returns>
        public Book GetBook(int bookID)
        {
            Book objBook = lstBooks.FirstOrDefault(element => element.b01f01 == bookID);
            return objBook;
        }

        /// <summary>
        /// Update Book
        /// </summary>
        /// <param name="data"></param>
        /// <returns>bool if update or not found</returns>
        public bool UpdateBook(JObject data)
        {
            Book objBook = lstBooks.FirstOrDefault(element => element.b01f01 == Convert.ToInt32(data["bookID"]));
            if (objBook == null)
            {
                return false;
            }
            objBook.b01f03 = data["bookAuthor"].ToString();
            objBook.b01f02 = data["bookName"].ToString();
            return true;
        }

        /// <summary>
        /// Removes book based on ID
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns>Result in bool</returns>
        public bool RemoveBook(int bookID)
        {
            Book objBook = lstBooks.FirstOrDefault(bookElement => bookElement.b01f01 == bookID);
            if (objBook == null)
            {
                return false;
            }
            return lstBooks.Remove(objBook);
        }

        /// <summary>
        /// Add a user to lstUsers
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool AddUser(JObject data)
        {
            Users objUsers = new Users
            {
                u01f01 = lstUsers.Count + 1,
                u01f02 = data["username"].ToString(),
                u01f03 = data["password"].ToString(),
                u01f04 = "Member"
            };
            lstUsers.Add(objUsers);
            return true;
        }

        /// <summary>
        /// Gets a list of Users
        /// </summary>
        /// <returns>List<Users></returns>
        public List<Users> GetUsers()
        {
            if (lstUsers.Count == 0)
            {
                return null;
            }
            return lstUsers;
        }

        /// <summary>
        /// Gets a user based on userID
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public Users GetUser(int userID)
        {
            Users objUsers = lstUsers.FirstOrDefault(element => element.u01f01 == userID);
            return objUsers;
        }

        /// <summary>
        /// Updates UserData
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Bool if upddate or not found</returns>
        public bool UpdateUser(JObject data)
        {
            Users objUsers = lstUsers.FirstOrDefault(element => element.u01f01 == Convert.ToInt32(data["userID"]));
            if (objUsers == null)
            {
                return false;
            }
            objUsers.u01f02 = data["username"].ToString();
            return true;
        }

        /// <summary>
        /// Removes user based on ID
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>Result in bool</returns>
        public bool RemoveUser(int userID)
        {
            Users objUsers = lstUsers.FirstOrDefault(bookElement => bookElement.u01f01 == userID);
            if (objUsers == null)
            {
                return false;
            }
            return lstUsers.Remove(objUsers);
        }
        /// <summary>
        /// Adds a transaction containing type=B, userid, bookid
        /// Makes book unavailable for other users
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool BorrowBook(string username, JObject data)
        {
            int bookID = Convert.ToInt32(data["bookID"]);
            //Getting userid from authenticated user
            int userID = lstUsers.FirstOrDefault(element => element.u01f02 == username).u01f01;

            //Check if book is available
            Book objBook = lstBooks.FirstOrDefault(element => element.b01f01 == bookID);
            if (objBook == null || objBook.b01f05 == false)
            {
                return false;
            }

            objBook.b01f05 = false; //Book is now unavailable
            //Book's duedate set to 15days from date of Borrowing
            objBook.b01f04 = DateTime.Now.AddDays(15);

            //Add a new Borrow Transaction
            Transaction objTransaction = new Transaction
            {
                t01f01 = lstTransactions.Count + 1,
                t01f02 = charBorrow,
                t01f03 = userID,
                t01f04 = bookID,
            };

            lstTransactions.Add(objTransaction);
            return true;
        }

        /// <summary>
        /// Adds a transaction containing type=R, userid, bookid
        /// Makes book available for other users
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool ReturnBook(string username, JObject data)
        {
            int bookID = Convert.ToInt32(data["bookID"]);
            int userID = lstUsers.FirstOrDefault(element => element.u01f02 == username).u01f01;

            //Check if book is available
            Book objBook = lstBooks.FirstOrDefault(element => element.b01f01 == bookID);
            if (objBook == null || objBook.b01f05 == true)
            {
                return false;
            }

            objBook.b01f05 = true; //Book is now unavailable
            //Duedate set to null
            objBook.b01f04 = null;

            //Add a new Return Transaction
            Transaction objTransaction = new Transaction
            {
                t01f01 = lstTransactions.Count + 1,
                t01f02 = charReturn,
                t01f03 = userID,
                t01f04 = bookID
            };

            lstTransactions.Add(objTransaction);
            return true;
        }

        /// <summary>
        /// Gets list of all the transactions
        /// </summary>
        /// <returns></returns>
        public List<Transaction> GetTransactions()
        {
            return (lstTransactions);
        }
        #endregion
    }
}