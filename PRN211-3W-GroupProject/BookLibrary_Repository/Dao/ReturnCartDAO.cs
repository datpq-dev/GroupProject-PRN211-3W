using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Dao
{
    public class ReturnCartDAO
    {
        private static Dictionary<TblBorrowReturnDetail, bool> returnCart = null;
        private static ReturnCartDAO instance = null;
        private static readonly object instanceLock = new object();
        private ReturnCartDAO()
        {
            returnCart = new Dictionary<TblBorrowReturnDetail,bool>();
        }
        public static ReturnCartDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ReturnCartDAO();
                    }
                }
                return instance;
            }
        }
        public void GetReturnByMemberID(string memberID)
        {
            List<TblBorrowReturnDetail> returnList = BorrowReturnDetailDBContext.Instance.GetAllDetails().Where(p => p.ReturnId == null && p.Borrow.MemberId==memberID).ToList();
            foreach (TblBorrowReturnDetail detail in returnList)
            {
                returnCart.Add(detail, true);
            }
        }

        public List<TblBorrowReturnDetail> getActiveEntry()
        {
            List<TblBorrowReturnDetail> activeEntries = new List<TblBorrowReturnDetail>();
            foreach (TblBorrowReturnDetail detail in returnCart.Keys.ToList())
            {
                if (returnCart[detail])
                {
                    activeEntries.Add(detail);
                }
            }
            return activeEntries;
        }

        public List<TblBorrowReturnDetail> getInactiveEntry()
        {
            List<TblBorrowReturnDetail> activeEntries = new List<TblBorrowReturnDetail>();
            foreach (TblBorrowReturnDetail detail in returnCart.Keys.ToList())
            {
                if (!returnCart[detail])
                {
                    activeEntries.Add(detail);
                }
            }
            return activeEntries;
        }

        public void ToggleEntry(string bookID)
        {
            foreach (TblBorrowReturnDetail detail in returnCart.Keys.ToList()) {
                if (detail.BookId.Equals(bookID))
                {
                    returnCart[detail] = !returnCart[detail];
                    break;
                }
            }
        }

        public void SetFine(string bookID, double fineAmount, string fineReason)
        {
            foreach (TblBorrowReturnDetail detail in returnCart.Keys.ToList())
            {
                if (detail.BookId.Equals(bookID))
                {
                    bool detailStatus = returnCart[detail];
                    returnCart.Remove(detail);
                    detail.FineAmount = fineAmount.ToString();
                    detail.FineReason = fineReason;
                    returnCart.Add(detail, detailStatus);
                    break;
                }
            }
        }

        public void ClearCart()
        {
            returnCart.Clear();
        }
    }
}
