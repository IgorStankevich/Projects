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
    public class AddMagazinePresenter
    {
        private IAddMagazineView _iView;
        private MagazineModel _model;

        public AddMagazinePresenter(IAddMagazineView _view)
        {
            _iView = _view;
            _model = new MagazineModel();
        }

        public void AddMagazine()
        {
            string author = _iView.Author;
            string name = _iView.Name;
            string publisher = _iView.Publisher;
            int datepublishing = _iView.DatePublishing;
            int periodicity = _iView.Periodicity;
            var magazine = new Magazine(author, name, publisher, datepublishing,periodicity);
            _model.AddMagazine(magazine);
        }
    }
}
