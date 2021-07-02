using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping_App.Models
{
    public partial class Category : Table
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }

        public string Name { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
