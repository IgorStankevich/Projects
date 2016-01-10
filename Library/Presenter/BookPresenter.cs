using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Views;

namespace Library.Presenter
{
    public class BookPresenter
    {
        private IBookView _viewBookFrm;
        public BookPresenter(IBookView viewBookFrm)
        {
            _viewBookFrm = _viewBookFrm;
        }

    }
}
