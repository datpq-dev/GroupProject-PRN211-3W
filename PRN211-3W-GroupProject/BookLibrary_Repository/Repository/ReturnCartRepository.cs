using BookLibrary_Repository.Dao;
using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public class ReturnCartRepository : IReturnCartRepository
    {
        public void ClearCart() => ReturnCartDAO.Instance.ClearCart();

        public List<TblBorrowReturnDetail> GetBorrowEntries() => ReturnCartDAO.Instance.getActiveEntry();

        public List<TblBorrowReturnDetail> GetReturnEntries() => ReturnCartDAO.Instance.getInactiveEntry();

        public void LoadDetailsByMemberID(string memberID) => ReturnCartDAO.Instance.GetReturnByMemberID(memberID);

        public void ToggleEntry(string bookID) => ReturnCartDAO.Instance.ToggleEntry(bookID);
        
        public void SetFine(string bookID, double fineAmount, string fineReason) => ReturnCartDAO.Instance.SetFine(bookID, fineAmount, fineReason);
    }
}
