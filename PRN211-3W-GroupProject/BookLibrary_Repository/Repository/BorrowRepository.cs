using BookLibrary_Repository.Dao;
using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public class BorrowRepository : IBorrowRepository
    {
        public void CreateBorrow(TblBorrow borrow) =>BorrowDBContext.Instance.CreateBorrow(borrow);

        public TblBorrow? GetBorrow(int id) => BorrowDBContext.Instance.GetBorrow(id);

        public List<TblBorrow> GetBorrows(string memberID) => BorrowDBContext.Instance.GetBorrows(memberID);
    }
}
