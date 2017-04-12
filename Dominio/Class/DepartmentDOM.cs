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
        public static bool Delete(DepartmentCOMMON pDpart)
        {
            return DepartmentPERS.Delete(pDpart);
        }
        public static bool Update(DepartmentCOMMON pDpart)
        {
            return DepartmentPERS.Update(pDpart);
        }
        public static List<DepartmentCOMMON> SearchAll()
        {
            return DepartmentPERS.SearchAll();
        }
    }
}
