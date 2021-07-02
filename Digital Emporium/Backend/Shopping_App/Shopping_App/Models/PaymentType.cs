using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class PaymentType : Table
    {
        public PaymentType()
        {
            Payments = new HashSet<Payment>();
            Sellers = new HashSet<Seller>();
        }

        public string Name { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }
    }
}
