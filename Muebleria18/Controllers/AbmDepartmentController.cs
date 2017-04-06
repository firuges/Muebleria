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
    public class AbmDepartmentController: Controller
    {
        public ActionResult InsertDepartment()
        {

            Muebleria18.Models.AbmDepartmentModels pModel = new Models.AbmDepartmentModels();
            pModel.mensaje = "Bienvenido a mi ABM";
            List<DepartmentCOMMON> Departments = new List<DepartmentCOMMON>();
            //ListDepartment = (List<DepartmentCOMMON>)Session["LaLista"];
            DepartmentCOMMON unDpto = new DepartmentCOMMON();

            unDpto.Id = 1;
            unDpto.ListCities = new List<CityCOMMON>();
            unDpto.Name = "Colonia";
            Departments.Add(unDpto);
            unDpto = new DepartmentCOMMON();
            unDpto.Id = 2;
            unDpto.ListCities = new List<CityCOMMON>();
            unDpto.Name = "Montevideo";
            Departments.Add(unDpto);

            pModel.lstDepartmentModel = Departments;

            return View(pModel);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult InsertDepartment(AbmDepartmentModels pModel)
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
    }
}