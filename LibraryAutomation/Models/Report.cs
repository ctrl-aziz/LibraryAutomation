using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    internal class Report
    {
        public static String TRANSICTON_ID = "trans_ID", BORROWING_ID = "borrowing_ID", REPORT_DATE = "report_date";

        int id;
        int transictonID;
        int borrowingID;
        DateTime report_date;

        public Report(int transictonID, int borrowingID, DateTime report_date)
        {
            this.transictonID = transictonID;
            this.borrowingID = borrowingID;
            this.report_date = report_date;
        }

        public int Id { get => id; }
        public int TransictonID { get => transictonID; }
        public int BorrowingID { get => borrowingID; }
        public DateTime Report_date { get => report_date; }
    }
}
