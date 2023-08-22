using BookLibrary_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
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
        public TblUser GetUserById(string username)
        {
            return this.TblUsers.FirstOrDefault(u => u.Username.Contains(username));
        }
        public IEnumerable<TblUser> GetAllUsers()
        {
            return this.TblUsers.Include(u => u.Role).ToList();// show all avai accounnt
        }
        public void UpdateUser(TblUser user)
        {
            var existingUser = this.TblUsers.FirstOrDefault(u => u.Username == user.Username);

            if (existingUser != null)
            {
                // Refresh the existingUser with the latest data from the database
                this.Entry(existingUser).Reload();

                // Update the existingUser with the new values
                existingUser.FirstName = user.FirstName;
                existingUser.LastName = user.LastName;
                existingUser.Password = user.Password;
                existingUser.Phone = user.Phone;

                // Save the changes
                this.SaveChanges();
            }
            else
            {
                // Handle the situation where the user doesn't exist
            }
        }
        /* var existingUser = this.TblUsers.FirstOrDefault(u => u.Username == user.Username);
         if (existingUser != null)
         {
             this.Entry(existingUser).State = EntityState.Modified;
         }
         this.TblUsers.Update(user);
         this.SaveChanges();
     }*/
        public void DeleteUser(string username)
        {
            var user = this.TblUsers.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                var memberRecords = this.TblMembers.Where(m => m.Username == username).ToList();

                if (memberRecords.Any())
                {
                    // Delete associated membership records first
                    this.TblMembers.RemoveRange(memberRecords);
                    this.SaveChanges();
                }

                
            }
            else if (user != null)
            {
                var librarianRecords = this.TblLibrarians.Where(l => l.Username == username).ToList();

                if (librarianRecords.Any())
                {
                    // Delete associated librarian records first
                    this.TblLibrarians.RemoveRange(librarianRecords);
                    this.SaveChanges();
                }
            }
            this.Entry(user).State = EntityState.Deleted;
            this.TblUsers.Remove(user);
            this.SaveChanges();


            /* var user = this.TblUsers.FirstOrDefault(u => u.Username == username) ?? this.TblUsers.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                this.Entry(user).State = EntityState.Deleted;
                this.TblUsers.Remove(user);
                this.SaveChanges();
            }*/
        }
            public void AddUser(TblUser user)
        {
            try
            {
                // Set the entity state to Added
                this.Entry(user).State = EntityState.Added;

                // Add the user to the DbSet and save changes
                this.TblUsers.Add(user);
                this.SaveChanges();
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error adding user: " + ex.Message);
                throw;
            }
        }
        public IEnumerable<TblRole> GetTblRoles()
            => this.TblRoles.ToList();
    }

 
}
/* private readonly UserDBContext _context;

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
 public static void UpdateInfo(int roleid, string name, string password,
        string fname, string lname, DateTime birthDay, string phone, string gender)
    {
        try
        {
            using (var context = new UserDBContext())
            {
                TblUser TblUser = context.TblUsers.FirstOrDefault(u => u.Username == name);
                if (TblUser != null)
                {
                    TblUser.RoleId = roleid;
                    TblUser.Username = name;
                    TblUser.Password = password;
                    TblUser.FirstName = fname;
                    TblUser.LastName = lname;
                    TblUser.Gender = gender;
                    TblUser.DoB = birthDay;
                    TblUser.Phone = phone;

                    context.SaveChanges();
                }
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
   public static TblUser CheckLogin(String username, String password)
    {
        TblUser TblUser = null;
        try
        {
            using (var context = new UserDBContext())
            {
                TblUser = context.TblUsers.FirstOrDefault(u => u.Username == username && u.Password == password);
            }
        }
        catch (Exception e)
        {
            using (var context = new UserDBContext())
            {
                TblUser = context.TblUsers.FirstOrDefault(u => u.Username == username && u.Password == password);
            }
        }
        return TblUser;
    }
    public static void ChangePassword(string username, string newPassword)
    {
        try
        {
            using (var context = new UserDBContext())
            {
                TblUser TblUser = context.TblUsers.FirstOrDefault(u => u.Username == username);
                if (TblUser != null)
                {
                    TblUser.Password = newPassword;
                    context.SaveChanges();
                }
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
 public static List<TblUser> GetTblUsers()
 {
     List<TblUser> TblUsers = new List<TblUser>();
     try
     {
         using (var context = new UserDBContext())
         {
             TblUsers = context.TblUsers.ToList();
         }
     }
     catch (Exception ex)
     {
         throw new Exception(ex.Message);
     }
     return TblUsers;
 }
 
 

 public static void CreateNewUser(int roleid, string name, string password,
     string fname, string lname, DateTime birthDay, string phone, string gender)
 {
     try
     {
         using (var context = new UserDBContext())
         {

             TblUser user = new TblUser
             {
                 RoleId = roleid,
                 Username = name,
                 Password = password,
                 FirstName = fname,
                 LastName = lname,
                 Gender = gender,
                 DoB = birthDay,
                 Phone = phone,




             };
             context.TblUsers.Add(user);
             context.SaveChanges();
         }
     }
     catch (Exception ex)
     {
         throw new Exception(ex.Message);
     }
 }
 public static TblUser GetTblUserByUsername(string username)
 {
     TblUser TblUser;
     try
     {
         using (var context = new UserDBContext())
         {
             TblUser = context.TblUsers.Where(u => u.Username == username).FirstOrDefault();
         }
     }
     catch (Exception e)
     {
         throw new Exception(e.Message);
     }
     return TblUser;
 }
 public void DeleteUser(string username)
 {
     var user = this.TblUsers.FirstOrDefault(u => u.Username == username) ?? this.TblUsers.FirstOrDefault(u => u.Username == username);
     if (user != null)
     {
         this.Entry(user).State = EntityState.Deleted;
         this.TblUsers.Remove(user);
         this.SaveChanges();
     }
 }

 public TblUser GetUserByUsernameAndPassword(string username, string password)
 {
     return this.TblUsers.FirstOrDefault(u => u.Username == username && u.Password == password);
 }
}
}*/
