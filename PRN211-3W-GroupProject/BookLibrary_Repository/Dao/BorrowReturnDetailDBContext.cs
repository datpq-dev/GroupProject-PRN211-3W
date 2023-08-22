using BookLibrary_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Dao
{
    public class BorrowReturnDetailDBContext
    {
        private static BorrowReturnDetailDBContext instance = null;
        private static readonly object instanceLock = new object();
        private BorrowReturnDetailDBContext() { }
        public static BorrowReturnDetailDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BorrowReturnDetailDBContext();
                    }
                    return instance;
                }
            }
        }
        public List<TblBorrowReturnDetail> GetAllDetails()
        {
            List<TblBorrowReturnDetail> tblBorrowReturnDetails = new List<TblBorrowReturnDetail>();
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    tblBorrowReturnDetails = context.TblBorrowReturnDetails.Include(p => p.Borrow).Include(p => p.Return).Include(p => p.Book).ThenInclude(p => p.IsbnNavigation).ThenInclude(p => p.Categories).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblBorrowReturnDetails;
        }
        public List<TblBorrowReturnDetail> GetBorrowDetails(int id)
        {
            List<TblBorrowReturnDetail> tblBorrowReturnDetails = new List<TblBorrowReturnDetail>();
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    tblBorrowReturnDetails = context.TblBorrowReturnDetails.Include(p => p.Borrow).Include(p => p.Return).Include(p => p.Book).ThenInclude(p => p.IsbnNavigation).ThenInclude(p => p.Categories).Where(p => p.BorrowId == id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblBorrowReturnDetails;
        }
        public void SaveBorrowDetail(TblBorrowReturnDetail tblBorrowReturnDetail)
        {
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    context.TblBorrowReturnDetails.Add(tblBorrowReturnDetail);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateBorrowDetail(TblBorrowReturnDetail tblBorrowReturnDetail)
        {
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    var tblBorrowReturnDetailSave = context.TblBorrowReturnDetails.Find(tblBorrowReturnDetail.BorrowId, tblBorrowReturnDetail.BookId);
                    if (tblBorrowReturnDetailSave != null)
                    {
                        tblBorrowReturnDetailSave.ReturnId = tblBorrowReturnDetail.ReturnId;
                        tblBorrowReturnDetailSave.FineAmount = tblBorrowReturnDetail.FineAmount;
                        tblBorrowReturnDetailSave.FineReason = tblBorrowReturnDetail.FineReason;
                        tblBorrowReturnDetailSave.FineStatus = false;
                        var tracker = context.TblBorrowReturnDetails.Attach(tblBorrowReturnDetailSave);
                        tracker.State = EntityState.Modified;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}