using BookLibrary_Repository.Dao;
using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public class UserTable : IUserRepository
    {
        private readonly UserDBContext _context;
        public void CreateUser(TblUser user)
        => UserDBContext.Instance.AddUser(user);

        public void DeleteUser(string username)
        => UserDBContext.Instance.DeleteUser(username);
        public void UpdateUser(TblUser user)
        => UserDBContext.Instance.UpdateUser(user);
        public TblUser GetUser(string username)
              => UserDBContext.Instance.GetUserById(username);

        public IEnumerable<TblUser> GetUsers()
            => UserDBContext.Instance.GetAllUsers();

      
    }
}
