using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Class
{
    public class ClientCOMMON : PeopleCOMMON
    {
        public string Password { get; set; }
        public DateTime DateJoin { get; set; }
        public DateTime LastLogin { get; set; }
        public String ClientTypeStatus { get; set; }
    }
}
