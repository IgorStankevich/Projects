using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLogic
{
    public class BookService
    {
        public static List<Book> _books = new List<Book>();
        public static Book _book = new Book();

        public static void AddBook(Book book)
        {
            _books.Add(book);
        }

        public static DataTable GetBooksTable(List<Book> books)
        {
            DataTable dataTable = new DataTable("Books");
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Author", typeof(string));
            dataTable.Columns.Add("Publisher", typeof(string));
            dataTable.Columns.Add("Date of Publishing", typeof(int));
            foreach (var book in books)
            {
                dataTable.Rows.Add(book.Name, book.Author, book.Publisher, book.YearPublishing);
            }
            return dataTable;
        }
    }
}
