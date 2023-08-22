using BookLibrary_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Dao
{
    public class BookDetailDBContext
    {
        private static BookDetailDBContext? instance = null;
        private static readonly object instanceLock = new object();
        private BookDetailDBContext() { }
        public static BookDetailDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookDetailDBContext();
                    }
                    return instance;
                }
            }
        }
        public TblBookDetail? GetBookById(string id)
        {
            TblBookDetail? bookDetail = null;
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    bookDetail = context.TblBookDetails.Include(p => p.IsbnNavigation).ThenInclude(i => i.Categories).FirstOrDefault(p => p.BookId.Equals(id));
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookDetail;
        }
        public List<TblBookDetail> GetAllBooks() 
        {
            List<TblBookDetail> tblBookDetails = new List<TblBookDetail>();
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    tblBookDetails = context.TblBookDetails.Include(p => p.IsbnNavigation).ThenInclude(i => i.Categories).ToList();
                }
            } catch (Exception ex) { throw new Exception(ex.Message) ; }
            return tblBookDetails;
        }
        public void Update (TblBookDetail bookDetail)
        {
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    var tracker = context.TblBookDetails.Attach(bookDetail);
                    tracker.State = EntityState.Modified;
                    context.SaveChanges();
                }
            } catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
        }
    }
}
