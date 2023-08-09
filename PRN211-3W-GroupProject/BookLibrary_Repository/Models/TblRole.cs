using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblRole
    {
        public TblRole()
        {
            TblUsers = new HashSet<TblUser>();
        }

        public long RoleId { get; set; }
        public string? RoleName { get; set; }

        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
