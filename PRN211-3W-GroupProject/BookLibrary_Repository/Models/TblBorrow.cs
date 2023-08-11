using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblBorrow
    {
        public TblBorrow()
        {
            TblBorrowDetails = new HashSet<TblBorrowDetail>();
        }

        public long BookingId { get; set; }
        public long UserId { get; set; }
        public DateTime BookingDay { get; set; }

        public virtual TblUser User { get; set; } = null!;
        public virtual ICollection<TblBorrowDetail> TblBorrowDetails { get; set; }
    }
}
