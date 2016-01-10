using System.Windows.Forms;

namespace Library.Views
{
    public interface IAddMagazineView
    {
        string Author { get; set; }
<<<<<<< HEAD
        string Name { get; set; }
        string Publisher { get; set; }
        int DatePublishing { get; set; }
        int Periodicity { get; set; }
=======
        //TextBox NameTxtBx { get; set; }
        //TextBox PublisherTxtBx { get; set; }
        //TextBox DatePublishingTxtBx { get; set; }
        //TextBox Periodicity { get; set; }
        void SaveBtn();
        void CancelBtn();
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
    }
}
