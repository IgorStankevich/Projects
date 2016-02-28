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
        }
    }
}

