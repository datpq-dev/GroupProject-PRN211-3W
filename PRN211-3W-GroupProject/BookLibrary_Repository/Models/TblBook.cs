using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblBook
    {
        public TblBook()
        {
            TblBorrowDetails = new HashSet<TblBorrowDetail>();
        }

        public string BookId { get; set; } = null!;
        public string Isbn { get; set; } = null!;
        public string? Description { get; set; }
        public bool Status { get; set; }

        public virtual TblBookInfo IsbnNavigation { get; set; } = null!;
        public virtual ICollection<TblBorrowDetail> TblBorrowDetails { get; set; }
    }
}
