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
        string SearchingValue { get; set; }
        void BindData();
    }
}
