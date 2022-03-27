using System;
using System.Data.SqlClient;


namespace LibraryAutomation.Models
{
    internal class Book
    {
        public static string BOOK_ID = "book_ID", TITLE = "bk_title", NAME = "bk_name", PUBLISHER = "publisher", AUTHER = "auther";
        public static string BOOK_NUMB= "bk_num", PUB_DATE = "pub_date";

        int id;
        string title;
        string name;
        string publisher;
        string auther;
        int bookNumb;
        DateTime pubDate;

        /// <summary>
        /// This model for creating new book
        /// </summary>
        /// <param name="title">Enter the title of book</param>
        /// <param name="name">name of book</param>
        /// <param name="publisher">publisher of book</param>
        /// <param name="auther">auther of book</param>
        /// <param name="bookNumb">book page number</param>
        /// <param name="pubDate">book publish date</param>
        public Book(string title, string name, string publisher, string auther, int bookNumb, DateTime pubDate)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException($"'{nameof(title)}' cannot be null or empty.", nameof(title));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
            }

            if (string.IsNullOrEmpty(publisher))
            {
                throw new ArgumentException($"'{nameof(publisher)}' cannot be null or empty.", nameof(publisher));
            }

            if (string.IsNullOrEmpty(auther))
            {
                throw new ArgumentException($"'{nameof(auther)}' cannot be null or empty.", nameof(auther));
            }

            this.title = title;
            this.name = name;
            this.publisher = publisher;
            this.auther = auther;
            this.bookNumb = bookNumb;
            this.pubDate = pubDate;
        }

        public int Id { get => id; }
        public string Title { get => title; }
        public string Name { get => name; }
        public string Publisher { get => publisher; }
        public string Auther { get => auther; }
        public int BookNumb { get => bookNumb; }
        public DateTime PubDate { get => pubDate; }


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
    }
}
