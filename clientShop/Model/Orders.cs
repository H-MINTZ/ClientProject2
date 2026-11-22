using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientShop.Model
{
    internal class Orders
    {
        public int OrderId { get; set; }
        public int? CustomerNum { get; set; }
        public string OrderDate { get; set; }
        public int? TotalPrice { get; set; }
        public int? ShippingId { get; set; }
        public int? GiftCard { get; set; }
        public bool? Status { get; set; }
    }
}
