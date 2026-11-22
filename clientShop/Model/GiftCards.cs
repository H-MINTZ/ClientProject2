using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientShop.Model
{
    internal class GiftCards
    {
        public int GiftCardId { get; set; }
        public int? Amount { get; set; }
        public string ExpirationDate { get; set; }
        public bool? IsUsed { get; set; }
        public bool? Status { get; set; }
    }
}
