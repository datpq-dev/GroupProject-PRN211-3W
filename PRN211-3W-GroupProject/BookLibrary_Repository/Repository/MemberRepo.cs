using BookLibrary_Repository.Dao;
using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public class MemberRepo : IMemberRepo
    {
        public TblMember? GetMemberByID(string memberID) => MemberDBContext.Instance.GetMemberByID(memberID);

        public TblMember? GetMemberByUsername(string username) => MemberDBContext.Instance.GetMemberByUsername(username);
    }
}
