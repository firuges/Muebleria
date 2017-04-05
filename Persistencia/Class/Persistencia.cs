using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Class
{
    public class Persistencia
    {
        protected static string CadenaDeConexion
        {
            get
            {
                // DataSource:   A que Servidor me conecto
                // Initial Catalog = NombreBD
                // Trusted_Connection=yes es para autentificacion de Windows
                return "Data Source=.;Initial Catalog=Muebleria;Trusted_Connection=yes";
                //Conexion de usuario de windows
                //el punto despues del DATA Source=. es para la conexion por Defecto de Windows
            }
        }
    }
}
