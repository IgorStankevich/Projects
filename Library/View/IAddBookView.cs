using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Data;
=======
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Views
{
    public interface IAddBookView
    {
        string Author { get; set; }
        string Name { get; set; }
        string Publisher { get; set; }
        int DatePublishing { get; set; }
<<<<<<< HEAD
        bool AuthorLbl { get; set; }
        bool NameLbl { get; set; }
        bool PublisherLbl { get; set; }
        bool DatePublishingLbl { get; set; }

=======
        void SaveBtn();
        void CancelBtn();
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
    }
}
