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
        #region #### Products ####
        public static bool TypeProduct_Add(TypeProductCOMMON pType)
        {
            return TypeProductDOM.Add(pType);
        }
        #endregion
        #region ####  City And Department  ####
            public static bool Department_Add(DepartmentCOMMON pDpart)
            {
                return DepartmentDOM.Add(pDpart);
            }
            public static bool Department_Delete(DepartmentCOMMON pDpart)
            {
                return DepartmentDOM.Delete(pDpart);
            }
            public static bool Department_Update(DepartmentCOMMON pDpart)
            {
                return DepartmentDOM.Update(pDpart);
            }
        public static List<DepartmentCOMMON> Department_SearchAll()
        {
            return DepartmentDOM.SearchAll();
        }
        public static bool City_Delete(CityCOMMON pCity)
            {
                return CityDOM.Delete(pCity);
            }
            public static bool City_Update(CityCOMMON pCity)
            {
                return CityDOM.Update(pCity);
            }
        #endregion
    }
}
