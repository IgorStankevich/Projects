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
    public partial class UpDateFrm : Form, IUpdateBookView
    {
        private UpdateBookPresenter _updateViewitem;
        private LibraryFrm libraryFrm;
        public GridViewItem ViewItem { get; set; }
        public UpDateFrm()
        {
            InitializeComponent();
            _updateViewitem = new UpdateBookPresenter(this);
            libraryFrm = new LibraryFrm();
        }
        public string Author { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int DatePublishing { get; set; }

        public bool AuthorLbl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool NameLbl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool PublisherLbl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool DatePublishingLbl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            Author = authorTxtBox.Text;
            Name = nameTxtBox.Text;
            Publisher = publisherTxtBox.Text;
            DatePublishing = int.Parse(datepublishingTxtBox.Text);
            _updateViewitem.UpdateViewItem();
            
        }

        private void UpDateFrm_Load(object sender, EventArgs e)
        { 
        }
    }
}
