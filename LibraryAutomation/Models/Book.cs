using System;
using System.Data.SqlClient;


namespace LibraryAutomation.Models
{
    internal class Book
    {
        public static string TABLE_NAME = "TBLBook";
        public static string BOOK_ID = "book_ID", TITLE = "bk_title", NAME = "bk_name", PUBLISHER = "publisher", AUTHER = "auther";
        public static string BOOK_NUMB= "bk_num", PUB_DATE = "pub_date";

        int id;
        public string title { get; set; }
        public string name { get; set; }
        public string publisher { get; set; }
        public string auther { get; set; }
        public int bookNumb { get; set; }
        public DateTime pubDate { get; set; }

        /// <summary>
        /// This model for creating new book
        /// </summary>
        public Book()
        {
            
        }


        /// <summary>
        /// Convert data form database to Book object
        /// by sending SqlDataReader parameter
        /// </summary>
        /// <param name="data">the data from database</param>
        public Book(SqlDataReader data)
        {
            id = int.Parse(string.Format("{0}", data[BOOK_ID]));
            title = string.Format("{0}", data[TITLE]);
            name = string.Format("{0}", data[NAME]);
            publisher = string.Format("{0}", data[PUBLISHER]);
            auther = string.Format("{0}", data[AUTHER]);
            bookNumb = int.Parse(string.Format("{0}", data[BOOK_NUMB]));
            pubDate = DateTime.Parse(string.Format("{0}", data[PUB_DATE]));
        }

        public static string[] GetColumnsName()
        {
            string[] keys = { TITLE, NAME, PUBLISHER, AUTHER, BOOK_NUMB, PUB_DATE };
            return keys;
        }
    }
}
