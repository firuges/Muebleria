using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Class
{
    public class CityCOMMON
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static CityCOMMON _Instance_City;
        public static CityCOMMON ObtenerInstancia()
        {
            if (_Instance_City == null)
            {
                _Instance_City = new CityCOMMON();
                _Instance_City.Id = 0;
            }

            return _Instance_City;
        }
    }
}
