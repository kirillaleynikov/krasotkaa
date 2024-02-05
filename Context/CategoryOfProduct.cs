using System;
using System.Collections.Generic;

namespace krasotkaa.Context
{
    public partial class CategoryOfProduct
    {
        public CategoryOfProduct()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
