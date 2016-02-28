using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Library.Entities;

namespace Library.Models
{
    public class BookModel
    {
        //to do list<Book> without static
        private static List<Book> _books = new List<Book>();
        private static Book _book;
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));

        public BookModel()
        { 
            _book = new Book();
        }

        public void AddBook(Book book)
        {
            _book = book;
            _books.Add(book);
            WriteToXml();
        }

        public List<Book> GetAllBooks()
        {
           ReadFromXml();
            return _books;
        }

        public Book GetBook()
        {
            return _books.Last();
        }

        public void WriteToXml()
        {
            using (StreamWriter stream = new StreamWriter("books.xml"))
            {
                xmlSerializer.Serialize(stream, _books);
                stream.Close();
            }
        }

        public void ReadFromXml()
        {
            TextReader textReader = new StreamReader("books.xml");
            _books = (List<Book>)xmlSerializer.Deserialize(textReader);
            textReader.Close();
        }

        public void UpdateBook(Book book)
        {
           //TO DO 
            var item = _books.Where(x => x.ID == book.ID).FirstOrDefault();
            if (item != null)
            {
                item.Author = book.Author;
                item.Name = book.Name;
                item.Publisher = book.Publisher;
                item.DatePublishing = book.DatePublishing;
                WriteToXml();
                ReadFromXml();
            }
        }

        public void DeleteBook(Book book)
        {
            var item = _books.SingleOrDefault(x => x.ID == book.ID);
            if (item != null)
            {
               _books.Remove(item);
               WriteToXml();
            }
        }
    }
}
