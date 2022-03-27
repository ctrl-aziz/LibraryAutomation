using LibraryAutomation.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryAutomation.Services
{
    internal class BorrowingDatabase
    {
        private SqlConnection dbConnection;

        BorrowingDatabase()
        {
            dbConnection = new SqlConnection("Data Source=AZIZ\\SQLEXPRESS;Initial Catalog=DBLibrary;Integrated Security=True");
            dbConnection.Open();
        }

        public int DeleteData(int id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = dbConnection;
            int result = 0;

            sqlCommand.CommandText = @"Delete from TBLBorrowing
                        where borrowing_ID=@borrowing_ID";

            sqlCommand.Parameters.Add(new SqlParameter(Borrowing.BORROWING_ID, id));
            try
            {
                result = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DeleteData error: " + ex.Message, "BorrowingDatabase error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return result;
        }

        public List<Borrowing> GetAllData()
        {
            SqlCommand _sql = new SqlCommand();
            _sql.Connection = dbConnection;
            _sql.CommandText = @"Select * from TBLBorrowing";
            List<Borrowing> Borrowings = new List<Borrowing>();
            try
            {
                SqlDataReader _reader = _sql.ExecuteReader();
                while (_reader.Read())
                {
                    Borrowings.Add(new Borrowing(_reader));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetAllData error: " + ex.Message, "BorrowingDatabase error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Borrowings;
        }

        public Borrowing GetData(int id)
        {
            SqlCommand sql = new SqlCommand();
            sql.Connection = dbConnection;
            sql.CommandText = @"Select * from TBLBorrowing where borrowing_ID=@borrowing_ID";
            Borrowing result = null;
            sql.Parameters.Add(new SqlParameter(Borrowing.BORROWING_ID, id));

            try
            {
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    result = new Borrowing(reader);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("GetData error: " + ex.Message, "BorrowingDatabase error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public int InsertData(Borrowing borrowing)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = dbConnection;
            int result = 0;

            sqlCommand.CommandText = $"insert into TBLBorrowing ({Borrowing.BOOK_ID},{ Borrowing.STUDENT_ID },{ Borrowing.DATE_BORROWED },{ Borrowing.DATE_RETURN }) values ({ borrowing.BookID },{ borrowing.StudentID },{ borrowing.DateBorrowed },{ borrowing.DateReturn })";

            try
            {
                result = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("InsertData error: " + ex.Message, "BorrowingDatabase error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return result;
        }

        public int UpdateData(Borrowing t, int id)
        {
            throw new NotImplementedException();
        }
    }
}
