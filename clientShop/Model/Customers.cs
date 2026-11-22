using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientShop.Model
{
    internal class Customers
    {
        public string CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool? Status { get; set; }
        public string City { get; set; }
        public int CustomerNum { get; set; }
    }
}
