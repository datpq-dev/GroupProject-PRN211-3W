using BookLibrary_Repository.Models;
using BookLibrary_Repository.Repository;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BookLibrary
{
    public partial class frmReturnBookDetail : Form
    {
        private readonly IReturnCartRepository _returnCartRepository;
        private double lateFineAmount = 0;
        private double damageFineAmount = 0;
        private string lateFineReason = "";
        private string damageFineReason = "";
        public frmReturnBookDetail()
        {
            InitializeComponent();
            cbCondition.Enabled = false;
            _returnCartRepository = new ReturnCartRepository();
            cbBookID.DataSource = new BindingSource() { DataSource = _returnCartRepository.GetBorrowEntries().Select(p => p.BookId) };
            cbCondition.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string? bookID = cbBookID.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(bookID))
            {
                TblBorrowReturnDetail? detail = _returnCartRepository.GetBorrowEntries().FirstOrDefault(d => d.BookId == bookID);
                if (detail != null)
                {
                    double totalFine = (lateFineAmount + damageFineAmount) <= 2 * detail.Book.IsbnNavigation.Price ? (lateFineAmount + damageFineAmount) : 2 * detail.Book.IsbnNavigation.Price;
                    txtFineAmount.Text = totalFine.ToString();
                    rtbFineReason.Text = lateFineReason + "; " + damageFineReason;
                    _returnCartRepository.SetFine(bookID, totalFine, (lateFineReason + ";" + damageFineReason) == ";" ? "" : (lateFineReason + ";" + damageFineReason));
                    _returnCartRepository.ToggleEntry(bookID);
                }
            }
            this.Close();
        }

        private void cbBookID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? bookID = cbBookID.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(bookID))
            {
                TblBorrowReturnDetail? detail = _returnCartRepository.GetBorrowEntries().FirstOrDefault(d => d.BookId == bookID);
                if (detail != null)
                {
                    txtISBN.Text = detail.Book.IsbnNavigation.Isbn;
                    txtTitle.Text = detail.Book.IsbnNavigation.Title;
                    txtAuthor.Text = detail.Book.IsbnNavigation.Author;
                    txtDescription.Text = detail.Book.IsbnNavigation.Description;
                    txtCategory.Text = string.Join(";", detail.Book.IsbnNavigation.Categories.Select(cate => cate.CategoryName));
                    dtpDueDay.Value = detail.ExpiredDay;
                    if (detail.ExpiredDay < DateTime.Now)
                    {
                        TimeSpan differ = DateTime.Now.Date - detail.ExpiredDay.Date;
                        int days = differ.Days;
                        if (days > 0)
                        {
                            lateFineAmount = detail.Book.IsbnNavigation.Price * (1.0 / 30.0) * days;
                            lateFineReason = "Return late for " + days + " day(s)";
                        }
                    }
                    double totalFine = (lateFineAmount + damageFineAmount) <= 2 * detail.Book.IsbnNavigation.Price ? (lateFineAmount + damageFineAmount) : 2 * detail.Book.IsbnNavigation.Price;
                    txtFineAmount.Text = totalFine.ToString();
                    rtbFineReason.Text = lateFineReason + "; " + damageFineReason;
                    cbCondition.Enabled = true;
                }
                else
                {
                    txtISBN.Text = "";
                    txtTitle.Text = "";
                    txtAuthor.Text = "";
                    txtDescription.Text = "";
                    txtCategory.Text = "";
                    dtpDueDay.Value = DateTime.Now;
                    txtFineAmount.Text = "";
                    cbCondition.Enabled = false;
                    rtbFineReason.Text = "";
                }
            }
        }

        private void cbCondittion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? bookID = cbBookID.SelectedItem.ToString();
            if (string.IsNullOrEmpty(bookID))
            {
                return;
            }

            TblBorrowReturnDetail? detail = _returnCartRepository.GetBorrowEntries().FirstOrDefault(d => d.BookId == bookID);
            if (detail == null)
            {
                return;
            }
            if (cbCondition.SelectedItem.ToString() == "Damaged")
            {
                damageFineAmount = detail.Book.IsbnNavigation.Price;
                damageFineReason = "Book Damaged";
            }
            else
            {
                damageFineAmount = 0;
                damageFineReason = "";
            }
            double totalFine = (lateFineAmount + damageFineAmount) <= 2 * detail.Book.IsbnNavigation.Price ? (lateFineAmount + damageFineAmount) : 2 * detail.Book.IsbnNavigation.Price;
            txtFineAmount.Text = totalFine.ToString();
            rtbFineReason.Text = lateFineReason + "; " + damageFineReason;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
