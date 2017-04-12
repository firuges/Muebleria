using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Muebleria18.Models;
using Common.Class;

namespace Muebleria18.Controllers
{
    public class ABMController : Controller
    {
        // GET: ABM
        public ActionResult AltaPersona()
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