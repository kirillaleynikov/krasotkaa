using System;
using System.Collections.Generic;

namespace krasotkaa.Context
{
    public partial class StatusOfProduct
    {
        public StatusOfProduct()
        {
            Products = new HashSet<Product>();
        }

        public int StatusOfProductId { get; set; }
        public string StatusOfProductName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
