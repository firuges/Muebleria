using Common.Class;
using Muebleria18.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;
namespace Muebleria18.Controllers
{
    public class RegistrosController : Controller
    {
        // GET: Registros
        public ActionResult addDepartment()
        {

            Muebleria18.Models.DepartmentModels pModel = new Models.DepartmentModels();
            pModel.mensaje = "Bienvenido a mi ABM";
            pModel.lstDepartmentModel = Dominio.Fachada.Department_SearchAll();

            return View(pModel);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult addDepartment(DepartmentModels pModel)
        {
            DepartmentCOMMON unDpto = new DepartmentCOMMON();
            unDpto.Name = pModel.Name;
            List<DepartmentCOMMON> theList = new List<DepartmentCOMMON>();
            if (Session["LaLista"] != null)
            {
                theList = (List<DepartmentCOMMON>)Session["LaLista"];

            }

            theList.Add(unDpto);
            Fachada Fachada = new Fachada();
            Fachada.Department_Add(unDpto);
            Session["LaLista"] = theList;
            #region Vaciar Textboxs

            pModel.mensaje = "Ingreso Correcto";
            #endregion
            return View(pModel);
        }

        public ActionResult AltaUsuario()
        {

            Muebleria18.Models.PersonaModels pModel = new Models.PersonaModels();
            pModel.mensaje = "Bienvenido a mi ABM";
            List<PeopleCOMMON> ListadePersonas = new List<PeopleCOMMON>();
            ListadePersonas = (List<PeopleCOMMON>)Session["LaLista"];
            pModel.LaListadePersonas = ListadePersonas;

            return View(pModel);
        }
    }
}