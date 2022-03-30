using DatabaseConfiguration;
using LibraryAutomation.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibraryAutomation.Services
{
    internal class BookService
    {
        private string Databasename = "AZIZ\\SQLEXPRESS";

        public int AddNewBook(Book book)
        {
            string[] values = {
                $"'{book.title}'", $"'{book.name}'", $"'{book.publisher}'", $"'{book.auther}'", $"{book.bookNumb}", $"'{book.pubDate}'"
            };


            Database db = new Database(Databasename, Book.GetColumnsName(), values);

            int result = db.InsertData(Book.TABLE_NAME);


            db.CloseConnection();
            return result;
        }

        public int DeleteBook(string id)
        {
            Database db = new Database(Databasename);
            int result = db.DeleteData(Book.TABLE_NAME, where: Book.BOOK_ID, isEqual: id);

            db.CloseConnection();
            return result;
        }

        public int UpdateBook(Book book, string id)
        {
            string[] values = {
                $"'{book.title}'", $"'{book.name}'", $"'{book.publisher}'", $"'{book.auther}'", $"{book.bookNumb}", $"'{book.pubDate}'"
            };
            Database db = new Database(Databasename, Book.GetColumnsName(), values);

            int result = db.UpdateData(Book.TABLE_NAME, where: Book.BOOK_ID, isEqual: id);
            db.CloseConnection();
            return result;
        }

        public Book GetBookData(string id)
        {
            Database db = new Database(Databasename);
            Book book = null;
            SqlDataReader _reader = db.GetData(Book.TABLE_NAME, Book.BOOK_ID, id);
            while (_reader.Read())
            {
                if (_reader.HasRows)
                {
                    book = new Book(_reader);
                }
            }

            db.CloseConnection();
            return book;
        }

        public List<Book> GetAllBooks()
        {
            Database db = new Database(Databasename);

            List<Book> books = new List<Book>();
            SqlDataReader _reader = db.GetAllData(Book.TABLE_NAME);
            while (_reader.Read())
            {
                if (_reader.HasRows)
                {
                    books.Add(new Book(_reader));
                }
            }

            db.CloseConnection();

            return books;
        }
    }
}
