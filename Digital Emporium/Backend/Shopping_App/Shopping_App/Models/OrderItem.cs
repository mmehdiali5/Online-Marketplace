using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class OrderItem : Table
    {
        public int OrderId { get; set; }
        public int SellerId { get; set; }
        public int ColorItemId { get; set; }
        public int Quantity { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
