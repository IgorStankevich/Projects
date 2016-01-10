using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Library.Entities;
using Library.Models;
using Library.Views;

namespace Library.Presenter
{
    public class MainPresenter
    {
        private IMainView _view;
        private BookModel _bookModel;
        private MagazineModel _magazineModel;
        private LibraryMapper _libraryMapper;


        public MainPresenter(IMainView viewBook)
        {
            _view = viewBook;
            _bookModel = new BookModel();
            _magazineModel = new MagazineModel();
            _libraryMapper = new LibraryMapper();

        }

        public void ShowPublicationTable()
        {

            _view.ViewItems = new List<GridViewItem>();
            //TO DO FOR OTHERS
            var magazines = _magazineModel.GetAllMagazines();
            foreach (var magazine in magazines)
            {
                var item = new GridViewItem();
                _libraryMapper.MapMagazine(item, magazine);
                _view.ViewItems.Add(item);
            }

            var books = _bookModel.GetAllBooks();
            foreach (var book in books)
            {
                var item = new GridViewItem();
                _libraryMapper.MapBook(item, book);
                _view.ViewItems.Add(item);
            }
            _view.BindData();

        }
        public void GetLibraryItem()
        {
            foreach (var book in _bookModel.GetAllBooks())
            {
                if (_view.ViewItem.ID.Contains(book.ID))
                {
                    _view.UpdateBook = true;
                }
            }

            foreach (var magazine in _magazineModel.GetAllMagazines())
            {
                if (_view.ViewItem.ID.Contains(magazine.ID))
                {
                    _view.UpdateMagazine = true;
                }
            }
        }
    }
}
