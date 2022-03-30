using LibraryAutomation.Models;
using LibraryAutomation.Services;
using System;
using System.Collections.Generic;
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
            Book book = new Book();
            book.title = tboxBkTitle.Text;
            book.name = tboxBkName.Text;
            book.publisher = tboxPublisher.Text;
            book.auther = tboxAuther.Text;
            book.bookNumb = Convert.ToInt32(tboxBkNumber.Text);
            book.pubDate = datePubDate.Value;

            BookService bookService = new BookService();

            int result = bookService.AddNewBook(book);

            if (result != 0)
            {
                queryResult.Text = "Data saved";
            }
            else
            {
                queryResult.Text = "Fild saving data";
            }

        }

        private void UpdateBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.title = tboxUpdateBkTitle.Text;
            book.name = tboxUpdateBkName.Text;
            book.publisher = tboxUpdateBkPublisher.Text;
            book.auther = tboxUpdateBkAuther.Text;
            book.bookNumb = Convert.ToInt32(tboxUpdateBkNum.Text);
            book.pubDate = pubDatePicker.Value;

            string id = tboxUpdateBkID.Text;

            BookService bookService = new BookService();

            int result = bookService.UpdateBook(book, id);
            if (result != 0)
            {
                queryResult.Text = "Data Updated";
            }
            else
            {
                queryResult.Text = "Fild updating data";
            }
        }


        private void GetBookData_Click(object sender, EventArgs e)
        {
            string id = tboxBookID.Text;

            BookService bookServiece = new BookService();

            Book book = bookServiece.GetBookData(id);
            
            tboxBkTitle.Text = book.title;
            tboxBkName.Text = book.name;
            tboxPublisher.Text = book.publisher;
            tboxAuther.Text = book.auther;
            tboxBkNumber.Text = book.bookNumb.ToString();
            datePubDate.Value = book.pubDate;
        }

        private void BtnGetAllData_Click(object sender, EventArgs e)
        {
            BookService bookService = new BookService();
            List<Book> books = bookService.GetAllBooks();
            
            
            for (int i = 0; i < books.Count; i++)
            {
                lviewData.Items.Add(books[i].name);
            }

        }

      
    }
}
