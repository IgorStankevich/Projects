using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Views;

namespace Library.Validators
{
    public class AddMagazineValidator
    {
        private IAddMagazineView _addMagazineView;

        public AddMagazineValidator(IAddMagazineView addMagazineView)
        {
            _addMagazineView = addMagazineView;
        }

        //public void CheckOnNull()
        //{
        //    if (b)
        //    {
                
        //    }
        //}
    }
}
