using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Class
{
    public class ProductCOMMON
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public int Stock { get; set; }
        public decimal PriceBase { get; set; }
        public ProviderCOMMON Provider { get; set; }
        public TypeProductCOMMON TypeProduct { get; set; }
        public decimal PriceSold { get; set; }
    }
}
