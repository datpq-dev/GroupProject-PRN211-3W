using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblBorrowReturnDetail
    {
        public int BorrowId { get; set; }
        public string BookId { get; set; } = null!;
        public DateTime ExpiredDay { get; set; }
        public int? ReturnId { get; set; }
        public string? FineReason { get; set; }
        public string? FineAmount { get; set; }
        public bool? FineStatus { get; set; }

        public virtual TblBookDetail Book { get; set; } = null!;
        public virtual TblBorrow Borrow { get; set; } = null!;
        public virtual TblReturn? Return { get; set; }
    }
}
