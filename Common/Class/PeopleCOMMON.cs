
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Class
{
    public class PeopleCOMMON
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Born { get; set; }
        public string Email { get; set; }
        
        public string Phone { get; set; }
        public string Ci { get; set; }
        public string address { get; set; }
        public CityCOMMON City { get; set; }
        public string CategoryPeople { get; set; }
    }
}
