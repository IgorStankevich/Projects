using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Views
{
    public interface IUpdateBookView
    {
        string ID { get; set; }
        string Author { get; set; }
        string Name { get; set; }
        string Publisher { get; set; }
        int DatePublishing { get; set; }
    }
}
