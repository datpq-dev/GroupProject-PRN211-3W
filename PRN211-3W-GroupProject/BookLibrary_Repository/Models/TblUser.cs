using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblUser
    {
        public byte RoleId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public DateTime? DoB { get; set; }
        public string Gender { get; set; } = null!;
        public bool Status { get; set; }

        public virtual TblRole Role { get; set; } = null!;
        public virtual TblLibrarian? TblLibrarian { get; set; }
        public virtual TblMember? TblMember { get; set; }
    }
}
