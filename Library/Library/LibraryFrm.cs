using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    public partial class LibraryFrm : Form,IMainView
    {
        public DataTable dataTable { get; set; }
        private MainPresenter _mainPresenter;
        private AddMagazinePresenter _magazinePresenter;
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int DatePublishing { get; set; }
        public int Periodicity { get; set; }
        public string ID { get; set; }

        public LibraryFrm()
        {
            InitializeComponent();
            _mainPresenter = new MainPresenter(this);
        }
        public List<GridViewItem> ViewItems { get; set; }
        public GridViewItem ViewItem { get; set; }
        public bool UpdateBook { get; set; }
        public bool UpdateMagazine { get; set; }

        private void LibraryFrm_Load(object sender, EventArgs e)
        {
            _mainPresenter.ShowPublicationTable();
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
                dataTable.Columns.Add("DatePublishing", typeof(string));
                dataTable.Columns.Add("Periodicity", typeof(string));
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
                    _mainPresenter.ShowPublicationTable();
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
                    updateMagazine.ID = ViewItem.ID;
                    updateMagazine.ShowDialog();
                    _mainPresenter.ShowPublicationTable();
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
            var txtBox = searchTxtBox.Text.Replace("'", "''");
            var authorcolumn = booksGridView.Columns[0].DataPropertyName;
            var namecolumn = booksGridView.Columns[1].DataPropertyName;
            var publishercolumn = booksGridView.Columns[2].DataPropertyName;
            var datePublishingcolumn = booksGridView.Columns[3].DataPropertyName;
            var periodicitycolumn = booksGridView.Columns[4].DataPropertyName;
            bs.Filter =
                string.Format(authorcolumn + " like '%" + txtBox + "%'" + " or " + namecolumn + " like '%" + txtBox +
                              "%'" + " or " + publishercolumn + " like '%" + txtBox + "%'" + " or " +
                               periodicitycolumn + " like '%" + txtBox + "%'" + " or " +
                               datePublishingcolumn + " like '%" + txtBox + "%'");
            booksGridView.DataSource = bs;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewItem = GetItem();
            Author = Convert.ToString(booksGridView.CurrentRow.Cells[0].Value);
            Name = Convert.ToString(booksGridView.CurrentRow.Cells[1].Value);
            Publisher = Convert.ToString(booksGridView.CurrentRow.Cells[2].Value);
            DatePublishing = Convert.ToInt32(booksGridView.CurrentRow.Cells[3].Value);
            Periodicity = Convert.ToInt32(booksGridView.CurrentRow.Cells[4].Value);
            ID = ViewItem.ID;
            DialogResult dialogResult = MessageBox.Show("Do you want delete this item?", "Deleting", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                _mainPresenter.DeleteItem();
                _mainPresenter.ShowPublicationTable();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }
    }
}
