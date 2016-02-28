using System.Windows.Forms;

namespace Library.Views
{
    public interface IAddMagazineView
    {
        string Author { get; set; }
        string Name { get; set; }
        string Publisher { get; set; }
        int DatePublishing { get; set; }
        int Periodicity { get; set; }
    }
}
