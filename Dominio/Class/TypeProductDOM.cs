using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Class;
using Common.Class;
using Persistencia.Class;

namespace Dominio.Class
{
    public class TypeProductDOM
    {
        public static bool Add(TypeProductCOMMON pType)
        {
            return TypeProductPERSIS.Add(pType);
        }
    }
}
