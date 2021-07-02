using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class Address : Table
    {
        public Address()
        {
            Orders = new HashSet<Order>();
            Sellers = new HashSet<Seller>();
            UserItems = new HashSet<UserItem>();
        }

        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetAddress { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }
        public virtual ICollection<UserItem> UserItems { get; set; }
    }
}
