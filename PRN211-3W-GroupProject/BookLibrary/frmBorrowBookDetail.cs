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
    public partial class frmBorrowBookDetail : Form
    {
        private readonly IBookDetailRepository _bookRepository;
        private readonly IBorrowCartRepository _borrowCartRepository;
        public frmBorrowBookDetail()
        {
            InitializeComponent();
            _bookRepository = new BookDetailRepository();
            _borrowCartRepository = new BorrowCartRepository();
            btnAdd.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblBookDetail? tblBookDetail = _bookRepository.GetBookDetail(txtBookID.Text.Trim());
            if (tblBookDetail == null)
            {
                MessageBox.Show("Invalid book!. Please check the Book ID again.");
            }
            else if (_borrowCartRepository.Contains(tblBookDetail))
            {
                MessageBox.Show("This book is already in the borrowing list!");
                btnAdd.Enabled = false;
            }
            else
            {
                _borrowCartRepository.AddToCart(tblBookDetail);
                this.Close();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            TblBookDetail? bookDetail = _bookRepository.GetBookDetail(txtBookID.Text);
            if (bookDetail != null)
            {
                txtStatus.Text = bookDetail.Status == true ? "This book is available" : "This book is not available"; ;
                txtISBN.Text = bookDetail.IsbnNavigation.Isbn;
                txtTitle.Text = bookDetail.IsbnNavigation.Title;
                txtAuthor.Text = bookDetail.IsbnNavigation.Author;
                string categories = "";
                foreach (TblCategory category in bookDetail.IsbnNavigation.Categories)
                {
                    categories += category.CategoryName + "; ";
                }
                txtCategory.Text = categories;
                txtDescription.Text = bookDetail.IsbnNavigation?.Description;
                txtPeriod.Text = bookDetail.IsbnNavigation?.BookingPeriod.ToString() + " day(s).";
                if (bookDetail.Status == true)
                {
                    btnAdd.Enabled = true;
                }
                else
                {
                    btnAdd.Enabled = false;
                }
            }
            else
            {
                txtStatus.Text = "";
                txtISBN.Text = "";
                txtTitle.Text = "";
                txtAuthor.Text = "";
                txtCategory.Text = "";
                txtDescription.Text = "";
                txtPeriod.Text = "";
                btnAdd.Enabled = false;
            }
        }
    }
}
