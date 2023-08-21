using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblBookDetail
    {
        public TblBookDetail()
        {
            TblBorrowReturnDetails = new HashSet<TblBorrowReturnDetail>();
        }

        public string BookId { get; set; } = null!;
        public string Isbn { get; set; } = null!;
        public bool Status { get; set; }

        public virtual TblBook IsbnNavigation { get; set; } = null!;
        public virtual ICollection<TblBorrowReturnDetail> TblBorrowReturnDetails { get; set; }
    }
}
