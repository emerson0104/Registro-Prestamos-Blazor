using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrestamosBlazor.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        [Required(ErrorMessage = "Este Campo no puede estar vacio")]

        public string Nombres { get; set; }

        [Required(ErrorMessage = "Este Campo no puede estar vacio")]

        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este Campo no puede estar vacio")]

        public string Cedula { get; set; }

        [Required(ErrorMessage = "Este Campo no puede estar vacio")]

        public string Direccion { get; set; }
        [DataType(DataType.DateTime)]

        [Required(ErrorMessage = "El campo fecha no puede estar vacío.")]

        [DisplayFormat(DataFormatString = "{0:dd,mm, yyyy}")]
        public DateTime FechaNacimiento { get; set; }
        public decimal Balance { get; set; }
        public Personas()
        {
            PersonaId = 0;

            Nombres = string.Empty;

            Telefono = string.Empty;

            Cedula = string.Empty;

            Direccion = string.Empty;

            FechaNacimiento = DateTime.Now;

            Balance = 0;
        }

    }
}

