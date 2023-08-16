using BookLibrary_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Dao
{
    public class UserDBContext : LibrarySystemManagementContext
    {
        private static UserDBContext instance = null;
        private static readonly object instanceLock = new object();
        private UserDBContext() 
        {
            InitalizeContext();
        }
        protected virtual void InitalizeContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public static UserDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDBContext();
                    }
                    return instance;
                }
            }
        }
        public TblUser GetUserById(int id)
        {
            return this.TblUsers.FirstOrDefault(u => u.UserId.Equals(id));
        }
        public IEnumerable<TblUser> GetAllUsers() 
        {
            return this.TblUsers.Include(u => u.RoleId).ToList();// show all avai accounnt
        }
        public void UpdateUser(TblUser user)
        {
            var existingUser = this.TblUsers.FirstOrDefault(u => u.UserId == user.UserId);
            if (existingUser != null)
            {
                this.Entry(existingUser).State = EntityState.Modified;
            }
            this.TblUsers.Update(user);
            this.SaveChanges();
        }
        public void DeleteUser(int id)
        {
            var user = this.TblUsers.FirstOrDefault(u => u.UserId==id) ?? this.TblUsers.FirstOrDefault(u => u.UserId==id);
            if (user != null)
            {
                this.Entry(user).State = EntityState.Deleted;
                this.TblUsers.Remove(user);
                this.SaveChanges();
            }
        }
        public void AddUser(TblUser user)
        {
            this.TblUsers.Add(user);
            this.SaveChanges();
        }
        public IEnumerable<TblRole> GetTblRoles()
            => this.TblRoles.ToList();
    }
}
