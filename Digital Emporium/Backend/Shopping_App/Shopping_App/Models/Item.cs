using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class Item : Table
    {
        public Item()
        {
            ColorItems = new HashSet<ColorItem>();
            FeaturedItems = new HashSet<FeaturedItem>();
            Images = new HashSet<Image>();
            Reviews = new HashSet<Review>();
            SaleItems = new HashSet<SaleItem>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double? AverageRating { get; set; }
        public int CategoryId { get; set; }
        public float UnitPrice { get; set; }
        public int SellerId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual ICollection<ColorItem> ColorItems { get; set; }
        public virtual ICollection<FeaturedItem> FeaturedItems { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<SaleItem> SaleItems { get; set; }
    }
}
