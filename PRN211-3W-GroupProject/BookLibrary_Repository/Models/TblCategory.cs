using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            Isbns = new HashSet<TblBook>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<TblBook> Isbns { get; set; }
    }
}
