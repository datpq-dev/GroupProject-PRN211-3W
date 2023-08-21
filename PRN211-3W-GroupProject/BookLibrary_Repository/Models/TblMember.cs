using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblMember
    {
        public TblMember()
        {
            TblBorrows = new HashSet<TblBorrow>();
            TblReturns = new HashSet<TblReturn>();
        }

        public string MemberId { get; set; } = null!;
        public string Username { get; set; } = null!;

        public virtual TblUser UsernameNavigation { get; set; } = null!;
        public virtual ICollection<TblBorrow> TblBorrows { get; set; }
        public virtual ICollection<TblReturn> TblReturns { get; set; }
    }
}
