using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Views;

namespace Library.Validators
{
    public class AddBookValidator
    {
        private IAddBookView _addBookView;

        public AddBookValidator(IAddBookView addBookView)
        {
            _addBookView = addBookView;
        }

        public void CheckOnNull()
        {
            _addBookView.AuthorLbl = _addBookView.Author.Length > 0 && _addBookView.Author.Trim().Length == 0;
            _addBookView.NameLbl = _addBookView.Name.Length > 0 && _addBookView.Name.Trim().Length == 0;
            _addBookView.PublisherLbl = _addBookView.Publisher.Length > 0 && _addBookView.Publisher.Trim().Length == 0;
            _addBookView.DatePublishingLbl = _addBookView.DatePublishing > 0 && _addBookView.DatePublishing.ToString().Trim().Length == 0;
        }
    }
}

