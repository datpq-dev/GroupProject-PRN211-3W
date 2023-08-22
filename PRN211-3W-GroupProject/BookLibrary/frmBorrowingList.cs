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
    public partial class frmBorrowingList : Form
    {
        private readonly BorrowReturnDetailRepository _repository;
        public frmBorrowingList(string memberID)
        {
            InitializeComponent();
            _repository = new BorrowReturnDetailRepository();
            var datasource = from borrowing in _repository.GetAll().Where(b => b.ReturnId == null && b.Borrow.MemberId == memberID)
                             select new
                             {
                                 borrowing.BookId,
                                 borrowing.Book.Isbn,
                                 borrowing.Borrow.BorrowDay,
                                 borrowing.ExpiredDay,
                                 borrowing.Book.IsbnNavigation.Title,
                                 borrowing.Book.IsbnNavigation.Author,
                                 borrowing.Book.IsbnNavigation.Description,
                                 Categories = string.Join(";", borrowing.Book.IsbnNavigation.Categories),
                             };
            dgbBorrowing.DataSource = new BindingSource() { DataSource = datasource };
        }
    }
}
