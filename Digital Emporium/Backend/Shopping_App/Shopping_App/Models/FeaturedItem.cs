using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class FeaturedItem : Table
    {
        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
    }
}
