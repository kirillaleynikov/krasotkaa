using System;
using System.Collections.Generic;

namespace krasotkaa.Context
{
    public partial class PickPoint
    {
        public PickPoint()
        {
            Orders = new HashSet<Order>();
        }

        public int PickPointId { get; set; }
        public string PickPointAddress { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
