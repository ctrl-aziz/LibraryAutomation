using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    internal class Borrowing
    {
        public static String BORROWING_ID = "borrowing_ID", BOOK_ID = "book_ID", STUDENT_ID = "stud_ID", DATE_BORROWED = "date_borroed", DATE_RETURN = "date_return";

        int id;
        int bookID;
        int studentID;
        DateTime dateBorrowed;
        DateTime dateReturn;

        public Borrowing(int bookID, int studentID, DateTime dateBorrowed, DateTime dateReturn)
        {
            this.bookID = bookID;
            this.studentID = studentID;
            this.dateBorrowed = dateBorrowed;
            this.dateReturn = dateReturn;
        }

        public int Id { get => id; }
        public int BookID { get => bookID; }
        public int StudentID { get => studentID; }
        public DateTime DateBorrowed { get => dateBorrowed; }
        public DateTime DateReturn { get => dateReturn; }

        public Borrowing(SqlDataReader data)
        {
            id = int.Parse(String.Format("{0}", data[BOOK_ID]));
            bookID = int.Parse(String.Format("{0}", data[BOOK_ID]));
            studentID = int.Parse(String.Format("{0}", data[STUDENT_ID]));
            dateBorrowed = DateTime.Parse(String.Format("{0}", data[DATE_BORROWED]));
            dateReturn = DateTime.Parse(String.Format("{0}", data[DATE_RETURN]));
        }
    }
}
