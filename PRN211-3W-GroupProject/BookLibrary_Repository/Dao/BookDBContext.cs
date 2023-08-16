using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Dao
{
    public class BookDBContext : LibrarySystemManagementContext
    {
        private static BookDBContext instance = null;
        private static readonly object instanceLock = new object();
        private BookDBContext() { }
        public static BookDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookDBContext();
                    }
                    return instance;
                }
            }
        }
        public TblBook GetBookById(int id)
        {
            return this.TblBooks.FirstOrDefault(b => b.BookId.Equals(id);
        }
        public IEnumerable<TblBook> GetAllBooks() 
        {
            return this.TblBooks.ToList();
        }
    }
}
