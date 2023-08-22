using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Dao
{
    public class BorrowCartDAO
    {
        private static List<TblBookDetail> borrowCart = null;
        private static BorrowCartDAO instance = null;
        private static readonly object instanceLock = new object();
        private BorrowCartDAO()
        {
            borrowCart = new List<TblBookDetail>();
        }
        public static BorrowCartDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BorrowCartDAO();
                    }
                }
                return instance;
            }
        }
        public List<TblBookDetail> GetCart()
        {
            return borrowCart;
        }
        public void AddBook(TblBookDetail book)
        {
            borrowCart.Add(book);
        }
        public void RemoveBook(string id)
        {
            foreach (TblBookDetail book in borrowCart)
            {
                if (book.BookId == id)
                {
                    borrowCart.Remove(book);
                    return;
                }
            }
        }
        public void ClearCart()
        {
            borrowCart.Clear();
        }
        public bool Contains(TblBookDetail tblBookDetail)
        {
            foreach (TblBookDetail book in borrowCart)
            {
                if (book.BookId== tblBookDetail.BookId)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
