using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class Color : Table
    {
        public Color()
        {
            ColorItems = new HashSet<ColorItem>();
        }

        public string Name { get; set; }

        public virtual ICollection<ColorItem> ColorItems { get; set; }
    }
}
