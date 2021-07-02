using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class Payment : Table
    {
        public int PaymentTypeId { get; set; }
        public int OrderId { get; set; }

        public virtual PaymentType PaymentType { get; set; }
    }
}
