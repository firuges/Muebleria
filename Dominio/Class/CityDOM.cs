using Common.Class;
using Persistencia.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Class
{
    public class CityDOM
    {
        public static bool Delete(CityCOMMON pCity)
        {
            return CityPERS.Delete(pCity);
        }
        public static bool Update(CityCOMMON pCity)
        {
            return CityPERS.Update(pCity);
        }
    }
}
