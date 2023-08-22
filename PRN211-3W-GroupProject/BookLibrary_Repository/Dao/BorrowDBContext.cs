using BookLibrary_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Dao
{
    public class BorrowDBContext
    {
        private static BorrowDBContext instance = null;
        private static readonly object instanceLock = new object();
        private BorrowDBContext() { }
        public static BorrowDBContext Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BorrowDBContext();
                    }
                    return instance;
                }
            }
        }
        public List<TblBorrow> GetBorrows(String memberID)
        {
            List<TblBorrow> borrows = new List<TblBorrow>();
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    borrows = context.TblBorrows.Include(p => p.TblBorrowReturnDetails).Where(p=>p.MemberId.Equals(memberID)).ToList();
                }
            } catch (Exception ex) { 
                throw new Exception(ex.Message);
            }
            return borrows;
        }
        public TblBorrow? GetBorrow(int id)
        {
            TblBorrow? tblBorrow = null;
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    tblBorrow = context.TblBorrows.Include(p => p.TblBorrowReturnDetails).FirstOrDefault(p => p.BorrowId.Equals(id));
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblBorrow;
        }
        public void CreateBorrow(TblBorrow borrow)
        {
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    context.TblBorrows.Add(borrow);
                    context.SaveChanges();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
