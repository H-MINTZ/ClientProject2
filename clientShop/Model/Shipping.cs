using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientShop.Model
{
    internal class Shipping
    {
        public int ShippingId { get; set; }
        public string ShippingDate { get; set; }
        public string StatusServer { get; set; }
        public bool? Status { get; set; }
    }
}
