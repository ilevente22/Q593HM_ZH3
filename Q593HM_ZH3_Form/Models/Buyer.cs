using System;
using System.Collections.Generic;

namespace Q593HM_ZH3_Form.Models
{
    public partial class Buyer
    {
        public Buyer()
        {
            Orders = new HashSet<Order>();
        }

        public int BuyerId { get; set; }
        public string? Name { get; set; }
        public string? Idnumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
