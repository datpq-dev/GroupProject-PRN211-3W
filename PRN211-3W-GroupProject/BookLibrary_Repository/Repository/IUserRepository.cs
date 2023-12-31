﻿using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public interface IUserRepository
    {
        IEnumerable<TblUser> GetUsers();
        TblUser GetUser(string username);

        void CreateUser(TblUser user);
        void UpdateUser(TblUser user);
        void DeleteUser(string username);


    }
    }
