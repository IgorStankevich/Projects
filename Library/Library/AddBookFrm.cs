using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Views;
using Library.Presenter;
using Library.Validators;

namespace Library
{
    public partial class AddBookFrm : Form, IAddBookView
    {
        private AddBookPresenter _addBookFrmPresenter;
        private AddBookValidator _addBookValidator;
        
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int DatePublishing { get; set; }
        public bool AuthorLbl { get; set; }
        public bool NameLbl { get; set; }
        public bool PublisherLbl { get; set; }
        public bool DatePublishingLbl { get; set; }
       
        public AddBookFrm()
        {
            InitializeComponent();
            _addBookFrmPresenter=new AddBookPresenter(this);
            _addBookValidator=new AddBookValidator(this);
        }

        public void CheckOnNull()
        {
         
            _addBookValidator.CheckOnNull();
        }
        
        private void okButton_Click(object sender, EventArgs e)
        {
            Author = authorTxtBox.Text;
            Name = nameTxtBox.Text;
            Publisher = publisherTxtBox.Text;
            DatePublishing = int.Parse(datepublishingTxtBox.Text);
            _addBookFrmPresenter.AddBook();
            Close();
        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox textbox = sender as TextBox;
                if (string.IsNullOrEmpty(textbox.Text))
                {
                    MessageBox.Show("Please enter correct value value..");
                    textbox.Focus();

                }

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

