using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Entities;
using Library.Models;
using Library.Views;


namespace Library.Presenter
{
    public class AddBookPresenter
    {
        private IAddBookView _viewAddBook;
        private BookModel _bookModel;
        public AddBookPresenter(IAddBookView viewAddBook)
        {
            _viewAddBook = viewAddBook;
            _bookModel = new BookModel();
        }

        public void AddBook()
        {
            string author = _viewAddBook.Author;
            string name = _viewAddBook.Name;
            string publisher = _viewAddBook.Publisher;
            int datepublishing = _viewAddBook.DatePublishing;
            var book = new Book(author, name, publisher, datepublishing);
            _bookModel.AddBook(book);
        }

    }
}
