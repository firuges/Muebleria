
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Class
{
    public class EmployeeCOMMON : PeopleCOMMON
    {
        public DateTime DateJoin { get; set; }
        public decimal SalaryPerHour { get; set; }
        public int ExtraHours { get; set; }
        public UtilitiesCOMMON.TypeEmployee TypeEmployee { get; set; }
    }
}
