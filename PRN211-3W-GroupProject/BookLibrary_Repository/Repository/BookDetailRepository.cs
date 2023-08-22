using BookLibrary_Repository.Dao;
using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public class BookDetailRepository : IBookDetailRepository
    {
        public List<TblBookDetail> GetAll() => BookDetailDBContext.Instance.GetAllBooks();

        public TblBookDetail? GetBookDetail(string id) => BookDetailDBContext.Instance.GetBookById(id);

        public void UpdateBook(TblBookDetail book) => BookDetailDBContext.Instance.Update(book);
    }
}
