using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblBorrowDetail
    {
        public long BookingId { get; set; }
        public string BookId { get; set; } = null!;
        public DateTime ExpiredDay { get; set; }
        public DateTime? ReturnDay { get; set; }
        public double Fine { get; set; }
        public string? Note { get; set; }

        public virtual TblBook Book { get; set; } = null!;
        public virtual TblBorrow Booking { get; set; } = null!;
    }
}
