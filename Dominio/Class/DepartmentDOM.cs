using Common.Class;
using Persistencia.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Class
{
    public class DepartmentDOM
    {
        public static bool Add(DepartmentCOMMON pDpart)
        {
            return DepartmentPERS.Add(pDpart);
        }
    }
}
