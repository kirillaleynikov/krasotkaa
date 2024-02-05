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
        public int PickPointIndex { get; set; }
        public string PickPointCity { get; set; } = null!;
        public string PickPointStreet { get; set; } = null!;
        public string PickPointHouse { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
