﻿using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public interface IMemberRepo
    {
        TblMember? GetMemberByID(string memberID);
        TblMember? GetMemberByUsername(string username);
    }
}