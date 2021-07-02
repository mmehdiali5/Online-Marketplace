using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class Review : Table
    {
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; }
        public int? Rating { get; set; }
        public DateTime DateTime { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Item Item { get; set; }
    }
}
