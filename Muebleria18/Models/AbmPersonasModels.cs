using Common.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace Muebleria18.Models
{
    public class AbmPersonasModels
    {
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime Born { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Telefono/Celular")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Cedula de Identidad")]
        public string Ci { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Direccion")]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Ciudad")]
        //public List<CityCOMMON> City { get; set; }
        public string City { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Categoria")]
        public UtilitiesCOMMON.CategoryPeople Category { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Repetir Contraseña")]
        public string Password2 { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Estado del Cliente")]
        public UtilitiesCOMMON.TypeClient  Type { get; set; }

        [DataType(DataType.Currency)]

        public string mensaje { get; set; }

        public List<PeopleCOMMON> LaListadePersonas { get; set; }
    }
}
