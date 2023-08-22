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
    public partial class frmReturn : Form
    {
        private readonly IMemberRepo _memberRepo;
        private readonly IReturnCartRepository _returnCartRepository;
        private readonly IReturnRepository _returnRepository;
        private readonly IBorrowReturnDetailRepository _brDetailRepository;

        private TblMember? _blMember = null;
        private string librarianID;
        public frmReturn(string librarianID)
        {
            InitializeComponent();
            _memberRepo = new MemberRepo();
            _returnCartRepository = new ReturnCartRepository();
            _returnRepository = new ReturnRepository();
            _brDetailRepository =new BorrowReturnDetailRepository();
            this.librarianID = librarianID;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (_blMember == null)
            {
                String memberID = txtMemberID.Text;
                TblUser? user = _memberRepo.GetMemberByID(memberID)?.UsernameNavigation;
                if (user != null)
                {
                    txtMemberName.Text = user.FirstName + " " + user.LastName;
                    txtGender.Text = user.Gender;
                    _blMember = user.TblMember;
                    btnVerify.Text = "Change";
                    txtMemberID.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Can not find Member with MemberID " + memberID);
                }
                _returnCartRepository.LoadDetailsByMemberID(memberID);
            }
            else
            {
                _blMember = null;
                txtMemberID.Text = "";
                txtMemberName.Text = "";
                txtGender.Text = "";
                txtMemberID.Enabled = true;
                btnVerify.Text = "Verify";
                _returnCartRepository.ClearCart();
                dgvReturnList.Rows.Clear();
            }
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (dgvReturnList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to remove from the list");
                return;
            }
            string? bookID = dgvReturnList.SelectedRows[0]?.Cells[0]?.Value.ToString();
            if (bookID == null)
            {
                MessageBox.Show("Please select a book to remove from the list");
                return;
            }
            _returnCartRepository.ToggleEntry(bookID);
            var datasource = from brDetail in _returnCartRepository.GetReturnEntries()
                             select new
                             {
                                 BookID = brDetail.BookId,
                                 ISBN = brDetail.Book.IsbnNavigation.Isbn,
                                 Title = brDetail.Book.IsbnNavigation.Title,
                                 Author = brDetail.Book.IsbnNavigation.Author,
                                 Description = brDetail.Book.IsbnNavigation.Description,
                                 Category = string.Join(";", brDetail.Book.IsbnNavigation.Categories.Select(cate => cate.CategoryName)),
                                 Fine = brDetail.FineAmount,
                                 FineReason = brDetail.FineReason
                             };
            dgvReturnList.DataSource = new BindingSource() { DataSource = datasource };

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (_blMember == null)
            {
                MessageBox.Show("You must enter Member ID first");
                return;
            }

            if (_returnCartRepository.GetBorrowEntries().Count == 0)
            {
                MessageBox.Show("This user don't have any more borrow books");
                return;
            }
            frmReturnBookDetail frmReturnBookDetail = new frmReturnBookDetail();
            frmReturnBookDetail.ShowDialog();
            var datasource = from brDetail in _returnCartRepository.GetReturnEntries()
                             select new
                             {
                                 BookID = brDetail.BookId,
                                 ISBN = brDetail.Book.IsbnNavigation.Isbn,
                                 Title = brDetail.Book.IsbnNavigation.Title,
                                 Author = brDetail.Book.IsbnNavigation.Author,
                                 Description = brDetail.Book.IsbnNavigation.Description,
                                 Category = string.Join(";", brDetail.Book.IsbnNavigation.Categories.Select(cate => cate.CategoryName)),
                                 Fine = brDetail.FineAmount,
                                 FineReason = brDetail.FineReason
                             };
            dgvReturnList.DataSource = new BindingSource() { DataSource = datasource };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<TblBorrowReturnDetail> list = _returnCartRepository.GetReturnEntries();
            if (_returnCartRepository.GetReturnEntries().Count == 0)
            {
                MessageBox.Show("There is nothing to return, please add some book");
                return;
            }
            TblReturn tblReturn = new TblReturn()
            {
                LibrarianId = librarianID,
                MemberId = _blMember.MemberId,
                ReturnDay = DateTime.Now,
            };
            _returnRepository.CreateReturn(tblReturn);
            foreach (var item in list)
            {
                item.ReturnId = tblReturn.ReturnId;
                _brDetailRepository.UpdateBorrowReturnDetail(item);
            }
            MessageBox.Show("Success");
            _returnCartRepository.ClearCart();
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _returnCartRepository.ClearCart();
            this.Close();
        }
    }
}
