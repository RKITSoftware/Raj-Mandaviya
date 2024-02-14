using System;

namespace LibraryManagementAPI.Models
{
    public class Book
    {
        #region Public Properties
        /// <summary>
        /// bookID
        /// </summary>
        public int b01f01 { get; set; }
        /// <summary>
        /// BookName
        /// </summary>
        public string b01f02 { get; set; }
        /// <summary>
        /// BookAuthor
        /// </summary>
        public string b01f03 { get; set; }
        /// <summary>
        /// BookDueDate
        /// </summary>
        public DateTime? b01f04 { get; set; } = null; //default value is null
        /// <summary>
        /// IsAvailable
        /// </summary>
        public bool b01f05 { get; set; } = true; //default value is true
        #endregion

    }
}