using BookLibrary_Repository.Dao;
using BookLibrary_Repository.Models;

namespace BookLibrary_Repository.Repository
{
    public class BorrowCartRepository : IBorrowCartRepository
    {
        public void AddToCart(TblBookDetail item)=> BorrowCartDAO.Instance.AddBook(item);

        public void ClearCart() => BorrowCartDAO.Instance.ClearCart();

        public void DeleteFromCart(string id) => BorrowCartDAO.Instance.RemoveBook(id);

        public List<TblBookDetail> GetCart() => BorrowCartDAO.Instance.GetCart();

        public bool Contains(TblBookDetail item) => BorrowCartDAO.Instance.Contains(item);
    }
}
