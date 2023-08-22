﻿using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public interface IReturnRepository
    {
        List<TblReturn> GetReturns(string memberID);
        TblReturn? GetReturn(int returnID);
        void CreateReturn(TblReturn tblReturn);
    }
}