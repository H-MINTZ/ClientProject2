using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientShop.Model
{
    internal class OederDetail
    {
        public int CodeOrder { get; set; }
        public int CodeProdect { get; set; }
        public int PriceAddition { get; set; }
        public string DiscibeAddition { get; set; }
        public bool Status { get; set; }
    }
}
