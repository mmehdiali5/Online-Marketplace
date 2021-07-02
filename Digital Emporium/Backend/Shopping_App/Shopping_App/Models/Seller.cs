using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class Seller : Table
    {
        public Seller()
        {
            Items = new HashSet<Item>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int UserId { get; set; }
        public int ShopAddressId { get; set; }
        public int PaymentTypeId { get; set; }

        public virtual PaymentType PaymentType { get; set; }
        public virtual Address ShopAddress { get; set; }
        public virtual UserItem User { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
