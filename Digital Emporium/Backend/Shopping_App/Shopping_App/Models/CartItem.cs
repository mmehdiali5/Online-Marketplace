using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class CartItem : Table
    {
        public int CustomerId { get; set; }
        public int ColorItemId { get; set; }
        public int Quantity { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
