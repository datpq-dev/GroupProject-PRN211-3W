using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblBookings = new HashSet<TblBooking>();
        }

        public long UserId { get; set; }
        public long RoleId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public DateTime? DoB { get; set; }
        public string? Gender { get; set; }
        public bool? Status { get; set; }

        public virtual TblRole Role { get; set; } = null!;
        public virtual ICollection<TblBooking> TblBookings { get; set; }
    }
}
