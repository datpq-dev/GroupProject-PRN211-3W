using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblBook
    {
        public TblBook()
        {
            TblBookings = new HashSet<TblBooking>();
        }

        public long BookId { get; set; }
        public long CategoryId { get; set; }
        public string? BookName { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }

        public virtual TblCategory Category { get; set; } = null!;
        public virtual ICollection<TblBooking> TblBookings { get; set; }
    }
}
