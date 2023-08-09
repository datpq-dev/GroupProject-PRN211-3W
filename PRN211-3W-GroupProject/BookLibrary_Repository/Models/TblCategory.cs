using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblBooks = new HashSet<TblBook>();
        }

        public long CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int? Quantity { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<TblBook> TblBooks { get; set; }
    }
}
