using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class UserItem : Table
    {
        public UserItem()
        {
            Customers = new HashSet<Customer>();
            Sellers = new HashSet<Seller>();
        }

        public int AddressId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }
    }
}
