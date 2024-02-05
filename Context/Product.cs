using System;
using System.Collections.Generic;

namespace krasotkaa.Context;

public partial class Product
{
    public Product()
    {
        Orders = new HashSet<Order>();
    }

    public string ProductArticleNumber { get; set; } = null!;
    public string ProductName { get; set; } = null!;
    public string ProductMeasurement { get; set; } = null!;
    public double ProductCost { get; set; }
    public double ProductMaxDiscount { get; set; }
    public int ProductManufacturer { get; set; }
    public int ProductProvider { get; set; }
    public int ProductCategory { get; set; }
    public double ProductDiscountAmount { get; set; }
    public int ProductQuantityInStock { get; set; }
    public string ProductDescription { get; set; } = null!;
    public string? ProductPhoto { get; set; }
    public int? ProductStatus { get; set; }

    public virtual CategoryOfProduct ProductCategoryNavigation { get; set; } = null!;
    public virtual Manufacture ProductManufacturerNavigation { get; set; } = null!;
    public virtual Provider ProductProviderNavigation { get; set; } = null!;
    public virtual StatusOfProduct? ProductStatusNavigation { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
}
