using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientShop.Model
{
    internal class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
        public string Image { get; set; }
        public int? Discount { get; set; }
        public string StartDate { get; set; }
        public bool? Status { get; set; }

    }
}
