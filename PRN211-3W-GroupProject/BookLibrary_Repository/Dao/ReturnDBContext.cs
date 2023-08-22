using BookLibrary_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Dao
{
    public class ReturnDBContext
    {
        private static ReturnDBContext instance = null;
        private static object instanceLock = new object();
        private ReturnDBContext() { }
        public static ReturnDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ReturnDBContext();
                    }
                    return instance;
                }
            }
        }
        public List<TblReturn> GetReturns(string memberID)
        {
            List<TblReturn > returnList = new List<TblReturn>();
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    returnList = context.TblReturns.Include(p => p.TblBorrowReturnDetails).Where(p => p.MemberId.Equals(memberID)).ToList();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return returnList;
        }
        public TblReturn? GetReturn(int returnID) {
            TblReturn? tblReturn = null;
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    tblReturn = context.TblReturns.Include(p => p.TblBorrowReturnDetails).FirstOrDefault(p => p.ReturnId.Equals(returnID));
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblReturn;
        }
        public void CreateReturn(TblReturn tblReturn)
        {
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    context.TblReturns.Add(tblReturn);
                    context.SaveChanges();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
