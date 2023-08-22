using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public interface IReturnCartRepository
    {
        public void LoadDetailsByMemberID(string memberID);
        public void ToggleEntry(string bookID);
        public List<TblBorrowReturnDetail> GetBorrowEntries();
        public List<TblBorrowReturnDetail> GetReturnEntries();
        public void ClearCart();
        public void SetFine(string bookID, double fineAmount, string fineReason);
    }
}
