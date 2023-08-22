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
    public partial class frmReturnList : Form
    {
        private readonly IBorrowReturnDetailRepository _repository;
        public frmReturnList(string memberID)
        {
            InitializeComponent();
            _repository = new BorrowReturnDetailRepository();
            var datasource = from ret in _repository.GetAll().Where(p => p.Borrow.MemberId == memberID && p.Return != null)
                             select new
                             {
                                 ret.Book.BookId,
                                 ret.Book.Isbn,
                                 ret.Borrow.BorrowDay,
                                 ret.Return.ReturnDay,
                                 ret.Book.IsbnNavigation.Title,
                                 ret.Book.IsbnNavigation.Author,
                                 ret.Book.IsbnNavigation.Description,
                                 Categories = string.Join(";", ret.Book.IsbnNavigation.Categories),
                                 ret.FineAmount,
                                 ret.FineReason,
                                 FineStatus = ret.FineStatus == true ? "Paid" : "Not Paid"
                             };
            dgvReturn.DataSource = new BindingSource() { DataSource = datasource };
        }
    }
}