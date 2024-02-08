using System;
using System.Collections.Generic;

namespace krasotkaa.Context
{
    public partial class StatusOfOrder
    {
        public StatusOfOrder()
        {
            Orders = new HashSet<Order>();
        }

        public int StatusOfOrderId { get; set; }
        public string StatusOfOrderName { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
