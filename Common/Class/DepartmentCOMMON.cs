using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Class
{
    public class DepartmentCOMMON
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CityCOMMON> ListCities { get; set; }
    }
}
