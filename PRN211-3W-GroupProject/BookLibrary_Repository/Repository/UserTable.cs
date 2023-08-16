﻿using BookLibrary_Repository.Dao;
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
        public TblUser GetUser(int id)
            => UserDBContext.Instance.GetUserById(id);           

        public IEnumerable<TblUser> GetUsers()
            => UserDBContext.Instance.GetAllUsers();
    }   
}