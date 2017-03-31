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
        public static bool Categoria_Agregar(TypeProductCOMMON pCategoria)
        {
            return Dominio.Clases.CategoriaDOM.Agregar(pCategoria);
        }
    }
}
