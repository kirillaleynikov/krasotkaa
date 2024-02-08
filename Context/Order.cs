using System;
using System.Collections.Generic;

namespace krasotkaa.Context
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public string OrderComposition { get; set; } = null!;
        public int OrderAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public double OrderCost { get; set; }
        public int OrderPickPoint { get; set; }
        public string OrderClientFio { get; set; } = null!;
        public string OrderCodeForGet { get; set; } = null!;
        public int OrderStatus { get; set; }

        public virtual Product OrderCompositionNavigation { get; set; } = null!;
        public virtual PickPoint OrderPickPointNavigation { get; set; } = null!;
        public virtual StatusOfOrder OrderStatusNavigation { get; set; } = null!;
    }
}
