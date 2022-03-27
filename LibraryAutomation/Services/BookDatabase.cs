using LibraryAutomation.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryAutomation.Services
{
    internal class BookDatabase
    {
        private SqlConnection dbConnection;
        public BookDatabase()
        {
            dbConnection = new SqlConnection("Data Source=AZIZ\\SQLEXPRESS;Initial Catalog=DBLibrary;Integrated Security=True");
            dbConnection.Open();
        }
        public int DeleteData(int id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = dbConnection;
            int result = 0;

            sqlCommand.CommandText = @"Delete from TBLBook where book_ID=@book_ID";

            sqlCommand.Parameters.Add(new SqlParameter(Book.BOOK_ID, id));
            try
            {
                result = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DeleteData error: " + ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return result;
        }

        public List<Book> GetAllData()
        {
            SqlCommand _sql = new SqlCommand();
            _sql.Connection = dbConnection;
            _sql.CommandText = @"Select * from TBLBook";
            List<Book> books = new List<Book>();
            try
            {
                SqlDataReader _reader = _sql.ExecuteReader();
                while (_reader.Read())
                {
                    books.Add(new Book(_reader));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetAllData error: " + ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return books;
        }

        public Book GetData(int id)
        {
            SqlCommand sql = new SqlCommand();
            sql.Connection = dbConnection;
            sql.CommandText = @"Select * from TBLBook where book_ID=@book_ID";
            Book result = null;
            sql.Parameters.Add(new SqlParameter(Book.BOOK_ID, id));

            try
            {
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    result = new Book(reader);
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("GetData error: " + ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public int InsertData(Book book)
        {
            string query = $"insert into TBLBook ({Book.TITLE},{Book.NAME},{Book.PUBLISHER},{Book.AUTHER},{Book.BOOK_NUMB},{Book.PUB_DATE}) values('{book.Title}','{book.Name}','{book.Publisher}','{book.Auther}',{book.BookNumb},'{book.PubDate}');";
            SqlCommand sqlCommand = new SqlCommand(query, dbConnection);
            //sqlCommand.Connection = dbConnection;
            int result = 0;


            

            //sqlCommand.Parameters.Add(new SqlParameter(Book.TITLE, book.Title));
            //sqlCommand.Parameters.Add(new SqlParameter(Book.NAME, book.Name));
            //sqlCommand.Parameters.Add(new SqlParameter(Book.PUBLISHER, book.Publisher));
            //sqlCommand.Parameters.Add(new SqlParameter(Book.AUTHER, book.Auther));
            //sqlCommand.Parameters.Add(new SqlParameter(Book.BOOK_NUMB, book.BookNumb));
            //sqlCommand.Parameters.Add(new SqlParameter(Book.PUB_DATE, book.PubDate));


            try
            {
                
                MessageBox.Show(sqlCommand.CommandText);
                Console.Write(sqlCommand.CommandText);
                result = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("InsertData error: " + ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return result;
        }

        public int UpdateData(Book book, int id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = dbConnection;
            int result = 0;

            sqlCommand.CommandText = @"Update TBLBook set bk_title=@bk_title,bk_name=@bk_name,publisher=@publisher,auther=@auther,bk_num=@bk_num,pub_date=@pub_date where "+Book.BOOK_ID+"="+id.ToString();

            sqlCommand.Parameters.Add(new SqlParameter(Book.TITLE, book.Title));
            sqlCommand.Parameters.Add(new SqlParameter(Book.NAME, book.Name));
            sqlCommand.Parameters.Add(new SqlParameter(Book.PUBLISHER, book.Publisher));
            sqlCommand.Parameters.Add(new SqlParameter(Book.AUTHER, book.Auther));
            sqlCommand.Parameters.Add(new SqlParameter(Book.BOOK_NUMB, book.BookNumb));
            sqlCommand.Parameters.Add(new SqlParameter(Book.PUB_DATE, book.PubDate));

            try
            {
                result = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UpdateData error: " + ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                    sqlCommand.Dispose();
                }
            }
            return result;
        }
    }
}
