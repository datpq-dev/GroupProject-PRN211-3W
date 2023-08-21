using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblReturn
    {
        public TblReturn()
        {
            TblBorrowReturnDetails = new HashSet<TblBorrowReturnDetail>();
        }

        public int ReturnId { get; set; }
        public string MemberId { get; set; } = null!;
        public DateTime ReturnDay { get; set; }
        public string LibrarianId { get; set; } = null!;

        public virtual TblLibrarian Librarian { get; set; } = null!;
        public virtual TblMember Member { get; set; } = null!;
        public virtual ICollection<TblBorrowReturnDetail> TblBorrowReturnDetails { get; set; }
    }
}
