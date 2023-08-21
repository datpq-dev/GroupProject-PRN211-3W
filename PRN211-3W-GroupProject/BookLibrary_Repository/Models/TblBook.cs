using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblBook
    {
        public TblBook()
        {
            TblBookDetails = new HashSet<TblBookDetail>();
            Categories = new HashSet<TblCategory>();
        }

        public string Isbn { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string? Description { get; set; }
        public int BookingPeriod { get; set; }
        public double Price { get; set; }
        public string BookIdprefix { get; set; } = null!;

        public virtual ICollection<TblBookDetail> TblBookDetails { get; set; }

        public virtual ICollection<TblCategory> Categories { get; set; }
    }
}
