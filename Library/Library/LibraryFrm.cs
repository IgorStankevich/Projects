using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
<<<<<<< HEAD
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastMember;
using Library.Presenter;
using Library.Views;
using Library.WinForms;

namespace Library
{
    public partial class LibraryFrm : Form, IBookView, IMainView
    {
        public DataTable dataTable { get; set; }
        private MainPresenter _mainPresenter;
        private AddMagazinePresenter _magazinePresenter;
        public string SearchingValue { get; set; }
        public LibraryFrm()
        {
            InitializeComponent();
            _mainPresenter = new MainPresenter(this);
            //dataTable = new DataTable();
        }
        public List<GridViewItem> ViewItems { get; set; }
        public GridViewItem ViewItem { get; set; }
        public bool UpdateBook { get; set; }
        public bool UpdateMagazine { get; set; }

        private void LibraryFrm_Load(object sender, EventArgs e)
        {
            _mainPresenter.ShowPublicationTable();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchingValue = searchTxtBox.Text;
        }

        public void BindData()
        {
            //TO DO GridViewItems List to DataTable          
            if (dataTable == null)
            {
                dataTable = new DataTable();
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("Author", typeof(string));
                dataTable.Columns.Add("Publisher", typeof(string));
                dataTable.Columns.Add("Date of Publishing", typeof(int));
                dataTable.Columns.Add("Periodicity", typeof(int));
            }
            dataTable.Clear();
            foreach (var item in ViewItems)
            {
                dataTable.Rows.Add(item.Name, item.Author, item.Publisher, item.DatePublishing, item.Periodicity);
            }
            booksGridView.DataSource = dataTable;
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookFrm addbook = new AddBookFrm();
            addbook.ShowDialog();
            _mainPresenter.ShowPublicationTable();
        }

        private void magazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMagazineFrm addmagazine = new AddMagazineFrm();
            addmagazine.ShowDialog();
            _mainPresenter.ShowPublicationTable();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewItem = GetItem();
            _mainPresenter.GetLibraryItem();
            if (UpdateBook)
            {
                UpDateFrm updatefrm = new UpDateFrm();
                if (booksGridView.CurrentRow != null)
                {
                    updatefrm.authorTxtBox.Text = Convert.ToString(booksGridView.CurrentRow.Cells[0].Value);
                    updatefrm.nameTxtBox.Text = Convert.ToString(booksGridView.CurrentRow.Cells[1].Value);
                    updatefrm.publisherTxtBox.Text = Convert.ToString(booksGridView.CurrentRow.Cells[2].Value);
                    updatefrm.datepublishingTxtBox.Text = Convert.ToString(booksGridView.CurrentRow.Cells[3].Value);
                    updatefrm.ID = ViewItem.ID;
                    updatefrm.ShowDialog();
                    UpdateBook = false;
                }
            }
            else
            {
                UpdateMagazineFrm updateMagazine = new UpdateMagazineFrm();
                if (booksGridView.CurrentRow != null)
                {
                    updateMagazine.authorTxtBox.Text = Convert.ToString(booksGridView.CurrentRow.Cells[0].Value);
                    updateMagazine.nameTxtBox.Text = Convert.ToString(booksGridView.CurrentRow.Cells[1].Value);
                    updateMagazine.publisherTxtBox.Text = Convert.ToString(booksGridView.CurrentRow.Cells[2].Value);
                    updateMagazine.datepublishingTxtBox.Text = Convert.ToString(booksGridView.CurrentRow.Cells[3].Value);
                    updateMagazine.periodicityTxtBox.Text = Convert.ToString(booksGridView.CurrentRow.Cells[4].Value);
                    updateMagazine.ShowDialog();
                }
            }
        }

        public GridViewItem GetItem()
        {
            int index = booksGridView.CurrentCell.RowIndex;
            return ViewItems[index];
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = booksGridView.DataSource;
            bs.Filter = string.Format(booksGridView.Columns[1].DataPropertyName + " like '%" + searchTxtBox.Text.Replace("'", "''") + "%'" + " or " + booksGridView.Columns[0].DataPropertyName + " like '%" + searchTxtBox.Text.Replace("'", "''") + "%'");
            //bs.Filter = string.Format(booksGridView.Columns[0].DataPropertyName  + " like '%{0}%'", searchTxtBox.Text.Trim().Replace("'", "''"));
            booksGridView.DataSource = bs;
=======
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Views;

namespace Library
{
    public partial class LibraryFrm : Form,IBookView
    {
        public LibraryFrm()
        {
            InitializeComponent();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            AddBookFrm addbook=new AddBookFrm();
            addbook.ShowDialog();
        }

        private void AddMagazineBtn_Click(object sender, EventArgs e)
        {
            AddMagazineFrm addmagazine=new AddMagazineFrm();
            addmagazine.ShowDialog();
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
        }
    }
}
