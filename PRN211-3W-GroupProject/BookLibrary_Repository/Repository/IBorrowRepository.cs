using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public interface IBorrowRepository
    {
        List<TblBorrow> GetBorrows(String memberID);
        TblBorrow? GetBorrow(int id);
        void CreateBorrow(TblBorrow borrow);
    }
}
