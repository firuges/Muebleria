using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Muebleria18.Models;

namespace Muebleria18.Controllers
{
    public class ABMController : Controller
    {
        // GET: ABM
        public ActionResult AltaPersona()
        {

            Muebleria18.Models.AbmPersonasModels pModel = new Models.AbmPersonasModels();
            pModel.mensaje = "";
            List<Persona> ListadePersonas = new List<Persona>();
            ListadePersonas = (List<Persona>)Session["LaLista"];
            pModel.LaListadePersonas = ListadePersonas;

            return View(pModel);
        }
    }
}