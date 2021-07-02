using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class ColorItem : Table
    {
        public int ItemId { get; set; }
        public int ColorId { get; set; }
        public int? Quantity { get; set; }

        public virtual Color Color { get; set; }
        public virtual Item Item { get; set; }
    }
}
