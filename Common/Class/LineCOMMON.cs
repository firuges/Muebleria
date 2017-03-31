using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Class
{
    public class LineCOMMON : FacturaCOMMON
    {
        public int Id { get; set; }
        public ProductCOMMON Product { get; set; }
    }
}
