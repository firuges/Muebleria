using Common.Class;
using Muebleria18.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Muebleria18.Controllers
{
    public class AbmDepartmentController: Controller
    {
        public ActionResult InsertDepartment()
        {

            Muebleria18.Models.AbmDepartmentModels pModel = new Models.AbmDepartmentModels();
            pModel.mensaje = "Bienvenido a mi ABM";
            List<DepartmentCOMMON> ListDepartment = new List<DepartmentCOMMON>();
            //ListDepartment = (List<DepartmentCOMMON>)Session["LaLista"];
            DepartmentCOMMON unDpto = new DepartmentCOMMON();

            unDpto.Id = 1;
            unDpto.ListCities = new List<CityCOMMON>();
            unDpto.Name = "Colonia";
            ListDepartment.Add(unDpto);
            unDpto = new DepartmentCOMMON();
            unDpto.Id = 2;
            unDpto.ListCities = new List<CityCOMMON>();
            unDpto.Name = "Montevideo";
            ListDepartment.Add(unDpto);

            pModel.ListDepartment = ListDepartment;

            return View(pModel);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult InsertDepartment(AbmDepartmentModels pModel)
        {
            DepartmentCOMMON unDpto = new DepartmentCOMMON();
            unDpto.Id = 1;
            unDpto.Name = pModel.Name.ToString();
            List<DepartmentCOMMON> theList = new List<DepartmentCOMMON>();
            if (Session["LaLista"] != null)
            {
                theList = (List<DepartmentCOMMON>)Session["LaLista"];

            }

            theList.Add(unDpto);
            Session["LaLista"] = theList;
            #region Vaciar Textboxs

            pModel.mensaje = "Ingreso de Persona Correctamente";
            #endregion
            return View(pModel);
        }
    }
}