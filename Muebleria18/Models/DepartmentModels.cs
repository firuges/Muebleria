using Common.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;


namespace Muebleria18.Models
{
    public class DepartmentModels
    {
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Nombre del Departamento")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Departamentos")]

        public List<DepartmentCOMMON> lstDepartmentModel { get; set; }

        [DataType(DataType.Currency)]

        public string mensaje { get; set; }
        
    }
}