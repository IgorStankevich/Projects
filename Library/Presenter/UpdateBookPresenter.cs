using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Entities;
using Library.Models;
using Library.Views;

namespace Library.Presenter
{
    public class UpdateBookPresenter
    {
        private IUpdateBookView _updateBookView;
        private BookModel _bookModel;
        private MagazineModel _magazineModel;
        public UpdateBookPresenter(IUpdateBookView updateview)
        {
            _updateBookView = updateview;
            _bookModel = new BookModel();
        }

        public void UpdateViewItem()
        {
            string id = _updateBookView.ID;
            string author = _updateBookView.Author;
            string name = _updateBookView.Name;
            string publisher = _updateBookView.Publisher;
            int datePublishing = _updateBookView.DatePublishing;
            var book = new Book(id, author, name,publisher, datePublishing );
            _bookModel.UpdateBook(book);
        }


    }
}
