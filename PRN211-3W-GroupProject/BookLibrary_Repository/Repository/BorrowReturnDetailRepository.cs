using BookLibrary_Repository.Dao;
using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public class BorrowReturnDetailRepository : IBorrowReturnDetailRepository
    {
        public List<TblBorrowReturnDetail> GetAll() => BorrowReturnDetailDBContext.Instance.GetAllDetails();

        public List<TblBorrowReturnDetail> GetBorrowReturnDetails(int borrowId) => BorrowReturnDetailDBContext.Instance.GetBorrowDetails(borrowId);

        public void SaveBorrowReturnDetail(TblBorrowReturnDetail borrowReturnDetail) => BorrowReturnDetailDBContext.Instance.SaveBorrowDetail(borrowReturnDetail);

        public void UpdateBorrowReturnDetail(TblBorrowReturnDetail tblBorrowReturnDetail) => BorrowReturnDetailDBContext.Instance.UpdateBorrowDetail(tblBorrowReturnDetail);
    }
}
