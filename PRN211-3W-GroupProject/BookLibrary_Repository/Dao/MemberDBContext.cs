using BookLibrary_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Dao
{
    public class MemberDBContext
    {
        private static MemberDBContext instance = null;
        private static object instanceLock = new object();
        private MemberDBContext() { }
        public static MemberDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDBContext();
                    }
                    return instance;
                }
            }
        }

        public TblMember? GetMemberByID(string memberID)
        {
            TblMember? tblMember = null;
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    tblMember = context.TblMembers.Include(m => m.UsernameNavigation).FirstOrDefault(m => m.MemberId.Equals(memberID));
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblMember;
        }
        public TblMember? GetMemberByUsername(string username)
        {
            TblMember? tblMember = null;
            try
            {
                using (var context = new LibrarySystemManagementContext())
                {
                    tblMember = context.TblMembers.Include(m=>m.UsernameNavigation).FirstOrDefault(m => m.Username.Equals(username));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblMember;
        }
    }
}
