using System;
using System.Collections.Generic;

namespace Q593HM_ZH3_Web.Models
{
    public partial class Bread
    {
        public Bread()
        {
            Orders = new HashSet<Order>();
        }

        public int BreadId { get; set; }
        public string? ShortName { get; set; }
        public string? FullName { get; set; }
        public float? Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
