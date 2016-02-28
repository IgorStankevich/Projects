using System;
using System.Collections.Generic;
using System.Data;
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
        bool AuthorLbl { get; set; }
        bool NameLbl { get; set; }
        bool PublisherLbl { get; set; }
        bool DatePublishingLbl { get; set; }

    }
}
