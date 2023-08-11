using System;
using System.Collections.Generic;

namespace BookLibrary_Repository.Models
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblBookInfos = new HashSet<TblBookInfo>();
        }

        public long CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<TblBookInfo> TblBookInfos { get; set; }
    }
}
