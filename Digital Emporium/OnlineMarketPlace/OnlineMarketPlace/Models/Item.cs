using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineMarketPlace.Models
{
    public partial class Item 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double? AverageRating { get; set; }
        public int CategoryId { get; set; }
        public float UnitPrice { get; set; }
        public int SellerId { get; set; }
        public int Id { get; set; }
    }
}
