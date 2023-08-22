using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public interface IBorrowReturnDetailRepository
    {
        List<TblBorrowReturnDetail> GetAll();
        List<TblBorrowReturnDetail> GetBorrowReturnDetails(int borrowId);
        void SaveBorrowReturnDetail(TblBorrowReturnDetail borrowReturnDetail);
        void UpdateBorrowReturnDetail(TblBorrowReturnDetail tblBorrowReturnDetail);
    }
}
