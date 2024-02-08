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
        public int PickPointAddress { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
