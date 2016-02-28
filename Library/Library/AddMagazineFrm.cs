using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Presenter;
using Library.Views;

namespace Library
{
    public partial class AddMagazineFrm : Form, IAddMagazineView
    {
        private AddMagazinePresenter _addMagazinePresenter;
        public AddMagazineFrm()
        {
            InitializeComponent();
            _addMagazinePresenter= new AddMagazinePresenter(this);
        }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int DatePublishing { get; set; }
        public int Periodicity { get; set; }

        private void okButton_Click(object sender, EventArgs e)
        {
            Author = authorTxtBox.Text;
            Name = nameTxtBox.Text;
            Publisher = publisherTxtBox.Text;
            DatePublishing = int.Parse(datepublishingTxtBox.Text);
            Periodicity = int.Parse(periodicityTxtBox.Text);
            _addMagazinePresenter.AddMagazine();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
