using Muebleria18.COMMON;
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
        public int Phone { get; set; }
        public int Ci { get; set; }
        public string Adress { get; set; }
        public cUtilidades.CategoryPeople CategoryPeople { get; set; }
    }
}
