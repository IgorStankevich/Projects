<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
=======
﻿using System.Collections.Generic;
using System.Data;
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
using Library.Entities;

namespace Library.Models
{
    public class BookModel
    {
<<<<<<< HEAD
        private static List<Book> _books = new List<Book>();
        private static Book _book = new Book();
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
        private string bookspath = @"c:\Users\stankevich\Desktop\books.xml";

        public void AddBook(Book book)
        {
            _book = book;
            _books.Add(book);
            using (StreamWriter stream = new StreamWriter(bookspath))
            {
                xmlSerializer.Serialize(stream, _books);
                stream.Close();
            }
        }

        public List<Book> GetAllBooks()
        {
            TextReader textReader = new StreamReader(bookspath);
            _books = (List<Book>)xmlSerializer.Deserialize(textReader);
            textReader.Close();
            return _books;
        }

        public Book GetBook()
        {
            return _books.Last();
        }
        public void UpdateBook(Book book)
        {
            var item = _books.Where(x => x.ID == book.ID).First();
            if (item != null)
            {
                item.Author = book.Author;
                item.Name = book.Name;
                item.Publisher = book.Publisher;
                item.DatePublishing = book.DatePublishing;
            }
=======
        public static List<Book> _books = new List<Book>();
        public static Book _book = new Book();

        public void AddBook(Book book)
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
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
        }
    }
}
