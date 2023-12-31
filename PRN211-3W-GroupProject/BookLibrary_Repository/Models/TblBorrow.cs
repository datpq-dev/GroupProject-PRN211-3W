﻿using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblBorrow
    {
        public TblBorrow()
        {
            TblBorrowReturnDetails = new HashSet<TblBorrowReturnDetail>();
        }

        public int BorrowId { get; set; }
        public string MemberId { get; set; } = null!;
        public DateTime BorrowDay { get; set; }
        public string LibrarianId { get; set; } = null!;

        public virtual TblLibrarian Librarian { get; set; } = null!;
        public virtual TblMember Member { get; set; } = null!;
        public virtual ICollection<TblBorrowReturnDetail> TblBorrowReturnDetails { get; set; }
    }
}
