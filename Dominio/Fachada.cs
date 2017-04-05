using Dominio.Class;
using Common.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dominio
{
    public class Fachada
    {
        public static bool TypeProduct_ADD(TypeProductCOMMON pType)
        {
            return TypeProductDOM.Add(pType);
        }
    }
}
