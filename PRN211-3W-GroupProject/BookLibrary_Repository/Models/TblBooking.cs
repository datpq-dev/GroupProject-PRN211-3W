using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblBooking
    {
        public long BookingId { get; set; }
        public long BookId { get; set; }
        public long UserId { get; set; }
        public DateTime? BookingDay { get; set; }
        public DateTime? ExpiredDay { get; set; }

        public virtual TblBook Book { get; set; } = null!;
        public virtual TblUser User { get; set; } = null!;
    }
}
