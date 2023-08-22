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
    public partial class frmBorrow : Form
    {
        private readonly IBorrowCartRepository _cartRepository;
        private readonly IBookDetailRepository _bookDetailRepository;
        private readonly IMemberRepo _memberRepo;
        private readonly IBorrowRepository _borrowRepository;
        private readonly IBorrowReturnDetailRepository _borrowReturnDetailRepository;
        private readonly string librarianID;
        public frmBorrow(string librarianID)
        {
            InitializeComponent();
            _cartRepository = new BorrowCartRepository();
            _bookDetailRepository = new BookDetailRepository();
            _memberRepo = new MemberRepo();
            _borrowRepository = new BorrowRepository();
            _borrowReturnDetailRepository = new BorrowReturnDetailRepository();
            this.librarianID = librarianID;
        }

        private void updateDgv()
        {
            var datasource = from book in _cartRepository.GetCart()
                             select new
                             {
                                 BookID = book.BookId,
                                 ISBN = book.Isbn,
                                 Title = book.IsbnNavigation.Title,
                                 Author = book.IsbnNavigation.Author,
                                 Description = book.IsbnNavigation.Description,
                                 Category = string.Join(";", book.IsbnNavigation.Categories.Select(cate => cate.CategoryName)),
                                 BookingPeriod = book.IsbnNavigation.BookingPeriod
                             };
            dgvBorrowDetail.DataSource = new BindingSource() { DataSource = datasource };
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmBorrowBookDetail detail = new frmBorrowBookDetail();
            detail.ShowDialog();
            this.Show();
            updateDgv();
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            string? id = dgvBorrowDetail.SelectedRows[0].Cells[0].Value.ToString();
            if (id == null)
            {
                return;
            }
            _cartRepository.DeleteFromCart(id);
            updateDgv();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _cartRepository.ClearCart();
            this.Close();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            String memberID = txtMemberID.Text;
            TblUser? user = _memberRepo.GetMemberByID(memberID)?.UsernameNavigation;
            if (user != null)
            {
                txtMemberName.Text = user.FirstName + " " + user.LastName;
                txtGender.Text = user.Gender;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String memberID = txtMemberID.Text;
            TblUser? user = _memberRepo.GetMemberByID(memberID)?.UsernameNavigation;
            if (user == null) { MessageBox.Show("Please enter valid MemberID"); }
            else if (_cartRepository.GetCart().Count <= 0) { MessageBox.Show("There is no book in the booking list"); }
            else
            {
                //verify that all book in cart is available
                bool check = true;
                foreach (var tblBookDetail in _cartRepository.GetCart())
                {
                    TblBookDetail? bookVerify = _bookDetailRepository.GetBookDetail(tblBookDetail.BookId);
                    if (bookVerify == null || bookVerify.Status != true)
                    {
                        MessageBox.Show("Book" + tblBookDetail.BookId + " is no longer available!. Please select another book");
                        _cartRepository.DeleteFromCart(tblBookDetail.BookId);
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    var now = DateTime.Now;
                    TblBorrow tblBorrow = new TblBorrow()
                    {
                        BorrowDay = now,
                        MemberId = memberID,
                        LibrarianId = librarianID
                    };
                    _borrowRepository.CreateBorrow(tblBorrow);
                    foreach (var tblBookDetail in _cartRepository.GetCart())
                    {
                        TblBorrowReturnDetail tblBorrowReturnDetail = new TblBorrowReturnDetail()
                        {
                            BorrowId = tblBorrow.BorrowId,
                            BookId = tblBookDetail.BookId,
                            ExpiredDay = now.AddDays(tblBookDetail.IsbnNavigation.BookingPeriod)
                        };
                        _borrowReturnDetailRepository.SaveBorrowReturnDetail(tblBorrowReturnDetail);

                        TblBookDetail? bookDetail = _bookDetailRepository.GetBookDetail(tblBookDetail.BookId);

                        bookDetail.Status = false;

                        _bookDetailRepository.UpdateBook(bookDetail);
                    }
                    _cartRepository.ClearCart();
                    MessageBox.Show("Borrow information has been saved");
                    this.Close();
                }
            }
        }
    }
}
