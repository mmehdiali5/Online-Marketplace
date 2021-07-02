using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class Order : Table
    {
        public int CustomerId { get; set; }
        public int DeliveryAddressId { get; set; }
        public DateTime DeliveryDateTime { get; set; }
        public DateTime OrderDateTime { get; set; }
        public float DeliveryCost { get; set; }
        public string Status { get; set; }
        public float TotalCost { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Address DeliveryAddress { get; set; }
    }
}
