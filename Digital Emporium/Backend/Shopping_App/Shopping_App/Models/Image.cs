using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class Image : Table
    {
        public int ItemId { get; set; }
        public string Path { get; set; }

        public virtual Item Item { get; set; }
    }
}
