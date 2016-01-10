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
<<<<<<< HEAD
using Library.Validators;
=======
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f

namespace Library
{
    public partial class AddBookFrm : Form, IAddBookView
    {
<<<<<<< HEAD
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
    }
}

=======
        public AddBookFrm()
        {
            InitializeComponent();
        }

        public void SaveBtn()
        {
            string name = nameTxtBox.Text;

        }

        public void CancelBtn()
        {
            throw new NotImplementedException();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string Author = authorTxtBox.Text;
            string Name = nameTxtBox.Text;
            string Publisher = publisherTxtBox.Text;


        }

        public string Author
        {
            get
            {
                return authorTxtBox.Text;
            }
            set { authorTxtBox.Text=value; }
        }

        public string Publisher
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int DatePublishing
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
