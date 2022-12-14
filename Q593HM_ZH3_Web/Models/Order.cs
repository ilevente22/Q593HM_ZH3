using System;
using System.Collections.Generic;

namespace Q593HM_ZH3_Web.Models
{
    public partial class Order
    {
        public int OrderSk { get; set; }
        public int BuyerFk { get; set; }
        public int BreadFk { get; set; }
        public int? Pcs { get; set; }

        public virtual Bread BreadFkNavigation { get; set; } = null!;
        public virtual Buyer BuyerFkNavigation { get; set; } = null!;
    }
}
