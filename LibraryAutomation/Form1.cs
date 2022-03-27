using LibraryAutomation.Models;
using LibraryAutomation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DatabaseConnect_Click(object sender, EventArgs e)
        {
            

        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            BookDatabase bookDatabase = new BookDatabase();
            Book book = new Book(tboxBkTitle.Text, tboxBkName.Text, tboxPublisher.Text, tboxAuther.Text, Convert.ToInt32(tboxBkNumber.Text), datePubDate.Value);
            int result = bookDatabase.InsertData(book: book);

            if (result != 0)
            {
                queryResult.Text = "Data saved";
            }
            else
            {
                queryResult.Text = "Fild saving data";
            }

        }

        private void GetBookData_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tboxBookID.Text);

            //BookDatabase bookDatabase = new BookDatabase();

            Database db = new Database();
            Book book = null;
            SqlDataReader _reader = db.GetData("TBLBook", Book.BOOK_ID, id);
            while (_reader.Read())
            {
                book = new Book(_reader);
            }

            //Book book = bookDatabase.GetData(id);


            tboxBkTitle.Text = book.Title;
            tboxBkName.Text = book.Name;
            tboxPublisher.Text = book.Publisher;
            tboxAuther.Text = book.Auther;
            tboxBkNumber.Text = book.BookNumb.ToString();
            datePubDate.Value = book.PubDate;



        }

        private void BtnGetAllData_Click(object sender, EventArgs e)
        {
            Book book = new Book("ll", "lkj", "şl", "kllk", 23, DateTime.Now);
            List<string> kyes = new List<string> { Book.TITLE, Book.NAME, Book.PUBLISHER, Book.AUTHER, Book.BOOK_NUMB, Book.PUB_DATE };
            List<string> values = new List<string> { $"'{book.Title}'", $"'{book.Name}'", $"'{book.Publisher}'", $"'{book.Auther}'", $"{book.BookNumb}", $"'{book.PubDate}'" };
            Database db = new Database(kyes, values);

            List<Book> books = new List<Book>();
            
            foreach (SqlDataReader item in db.GetAllData("TBLBook"))
            {
                books.Add(new Book(item));
            }
            for (int i = 0; i < books.Count; i++)
            {
                lviewData.Items.Add(books[i].Name);
            }

            //BookDatabase bookDatabase = new BookDatabase();
            //List<Book> books = bookDatabase.GetAllData();
            //for (int i = 0; i < books.Count; i++)
            //{
            //    lviewData.Items.Add(books[i].Name);
            //}
        }

        private void UpdateBook_Click(object sender, EventArgs e)
        {
            BookDatabase bookDB = new BookDatabase();
            Book book = new Book(tboxUpdateBkTitle.Text, tboxUpdateBkName.Text, tboxUpdateBkPublisher.Text, tboxUpdateBkAuther.Text, int.Parse(tboxUpdateBkNum.Text), pubDatePicker.Value);
            int result = bookDB.UpdateData(book, int.Parse(tboxUpdateBkID.Text));

        }

        private void GetData_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tboxGetID.Text);

            BookDatabase bookDatabase = new BookDatabase();

            Book book = bookDatabase.GetData(id);

            tboxUpdateBkID.Text = book.Id.ToString();
            tboxUpdateBkTitle.Text = book.Title;
            tboxUpdateBkName.Text = book.Name;
            tboxUpdateBkPublisher.Text = book.Publisher;
            tboxUpdateBkAuther.Text = book.Auther;
            tboxUpdateBkNum.Text = book.BookNumb.ToString();
            pubDatePicker.Value = book.PubDate;
        }
    }
}
