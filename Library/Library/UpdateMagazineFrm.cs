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

namespace Library.WinForms
{
    public partial class UpdateMagazineFrm : Form, IUpdateMagazineView
    {
        private UpdateMagazinePresenter _updateViewitem;
        public string Author { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int DatePublishing { get; set; }
        public int Periodicity { get; set; }

        public UpdateMagazineFrm()
        {
            InitializeComponent();
            _updateViewitem = new UpdateMagazinePresenter(this);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Author = authorTxtBox.Text;
            Name = nameTxtBox.Text;
            Publisher = publisherTxtBox.Text;
            DatePublishing = int.Parse(datepublishingTxtBox.Text);
            Periodicity = int.Parse(periodicityTxtBox.Text);
            _updateViewitem.UpdateViewItem();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
