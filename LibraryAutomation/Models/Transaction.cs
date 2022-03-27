using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    internal class Transaction
    {
        public static String TRANSICTON_NAME = "trans_name", BORROWING_ID = "borrowing_ID", STUDENT_ID = "stud_ID";
        public static String TRANSICTON_DATE = "trans_date", PERSONNEL_ID = "personnel_ID";

        int id;
        int transictonID;
        String transictonName;
        int borrowingID;
        int studentID;
        DateTime transaction_date;

        public Transaction(int transictonID, String transictonName, int borrowingID, int studentID, DateTime transaction_date)
        {
            this.transictonID = transictonID;
            this.transictonName = transictonName;
            this.borrowingID = borrowingID;
            this.studentID = studentID;
            this.transaction_date = transaction_date;
        }

        public int Id { get => id; }
        public int TransictonID { get => transictonID; }
        public String TransictonName { get => transictonName; }
        public int BorrowingID { get => borrowingID; }
        public int StudentID { get => studentID; }
        public DateTime Transaction_date { get => transaction_date; }
    }
}
