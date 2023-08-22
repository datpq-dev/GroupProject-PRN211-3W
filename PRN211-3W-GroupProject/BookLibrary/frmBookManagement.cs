using BookLibrary_Repository.Models;
using BookLibrary_Repository.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class frmBookManagement : Form
    {
        private readonly IBookDetailRepository bookDetailRepository;
        public frmBookManagement()
        {
            InitializeComponent();
            bookDetailRepository = new BookDetailRepository();

            var datasource = from book in bookDetailRepository.GetAll()
                             select new
                             {
                                 book.BookId,
                                 book.IsbnNavigation.Isbn,
                                 book.IsbnNavigation.Title,
                                 book.IsbnNavigation.Author,
                                 book.IsbnNavigation.Description,
                                 Categories = string.Join(";", book.IsbnNavigation.Categories.Select(c => c.CategoryName)),
                                 Status = book.Status==true?"Available":"Unavailable"
                             };
            dgvBookList.DataSource = new BindingSource() { DataSource = datasource };
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmBookDetails frm = new frmBookDetails();
            frm.ShowDialog();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            frmBookDetails frmBookDetails = new();
            frmBookDetails.ShowDialog();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {

        }

        private void btnExitBook_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {

        }

        private void dgvBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBookList.SelectedRows.Count <= 0)
            {
                return;
            }
            string? bookID = dgvBookList.SelectedRows[0].Cells[0].Value.ToString();
            if (bookID == null)
            {
                return;
            }
            TblBookDetail? detail = bookDetailRepository.GetBookDetail(bookID);
            if (detail == null)
            {
                return;
            }
            txtBookID.Text = detail.BookId.ToString();
            txtAuth.Text = detail.IsbnNavigation.Author.ToString();
            txtStatus.Text = detail.Status == true ? "Available" : "Unavailable";
            txtCategories.Text = string.Join(";", detail.IsbnNavigation.Categories.Select(c => c.CategoryName));
            txtTitle.Text = detail.IsbnNavigation.Title.ToString();
            rtbDescription.Text = detail.IsbnNavigation.Description;
        }
    }
}
