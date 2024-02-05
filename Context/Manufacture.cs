using System;
using System.Collections.Generic;

namespace krasotkaa.Context
{
    public partial class Manufacture
    {
        public Manufacture()
        {
            Products = new HashSet<Product>();
        }

        public int ManufactureId { get; set; }
        public string ManufactureName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
