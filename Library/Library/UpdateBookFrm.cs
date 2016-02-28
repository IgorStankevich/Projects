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
        public GridViewItem ViewItem { get; set; }
        public UpDateFrm()
        {
            InitializeComponent();
            _updateViewitem = new UpdateBookPresenter(this);
        }
        public string Author { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int DatePublishing { get; set; }

        private void okButton_Click(object sender, EventArgs e)
        {
            Author = authorTxtBox.Text;
            Name = nameTxtBox.Text;
            Publisher = publisherTxtBox.Text;
            DatePublishing = int.Parse(datepublishingTxtBox.Text);
            _updateViewitem.UpdateViewItem();
            Close();

        }

        private void UpDateFrm_Load(object sender, EventArgs e)
        {
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
