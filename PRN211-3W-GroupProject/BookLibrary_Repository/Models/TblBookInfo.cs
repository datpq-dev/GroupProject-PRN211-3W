using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblBookInfo
    {
        public TblBookInfo()
        {
            TblBooks = new HashSet<TblBook>();
        }

        public string Isbn { get; set; } = null!;
        public long CategoryId { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string? Description { get; set; }
        public int BookingPeriod { get; set; }
        public double Price { get; set; }
        public string BookIdprefix { get; set; } = null!;

        public virtual TblCategory Category { get; set; } = null!;
        public virtual ICollection<TblBook> TblBooks { get; set; }
    }
}
