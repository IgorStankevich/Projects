using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Library.Views
{
    public interface IMainView
    {
        List<GridViewItem> ViewItems { get; set; }
        GridViewItem ViewItem { get; set; }
        bool UpdateBook { get; set; }
        bool UpdateMagazine { get; set; }
        string Author { get; set; }
        string ID { get; set; }
        string Name { get; set; }
        string Publisher { get; set; }
        int DatePublishing { get; set; }
        int Periodicity { get; set; }
        void BindData();
    }
}
