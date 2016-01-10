using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Entities;
using Library.Presenter;
using Library.Views;

namespace Library.Models
{
    public class LibraryMapper
    {
       

        public LibraryMapper()
        {
        }
        public void MapBook(GridViewItem item, Book book)
        {
            item.ID = book.ID;
            item.Author = book.Author;
            item.Name = book.Name;
            item.Publisher = book.Publisher;
            item.DatePublishing = book.DatePublishing;
        }

        public void MapMagazine(GridViewItem item, Magazine magazine)
        {
            item.ID = magazine.ID;
            item.Author = magazine.Author;
            item.Name = magazine.Name;
            item.Name = magazine.Name;
            item.Name = magazine.Name;
            item.Publisher = magazine.Publisher;
            item.DatePublishing = magazine.DatePublishing;
            item.Periodicity = magazine.Periodicity;
        }

    }
}
