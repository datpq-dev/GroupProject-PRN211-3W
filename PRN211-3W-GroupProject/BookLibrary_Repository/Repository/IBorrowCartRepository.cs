using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public interface IBorrowCartRepository
    {
        List<TblBookDetail> GetCart();
        void AddToCart(TblBookDetail item);
        void DeleteFromCart(string id);
        void ClearCart();
        bool Contains(TblBookDetail item);
    }
}
