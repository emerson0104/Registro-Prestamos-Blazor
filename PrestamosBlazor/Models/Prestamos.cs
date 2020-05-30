using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrestamosBlazor.Models
{
    public class Prestamos
    {[Key]
        [Required(ErrorMessage = "El campo no puede estar vacío")]
        public int PrestamoId { get; set; }
        [DataType(DataType.DateTime)]

        [Required(ErrorMessage = "El campo Fecha no puede estar vacío")]
        [DisplayFormat(DataFormatString = "{0:dd,mm, yyyy}")]
        public DateTime Fecha { get; set; }
        [Range(1, 1000000, ErrorMessage = "Debe elegir una persona")]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "El campo concepto no puede estar vacio")]

        public string Concepto { get; set; }
        [Required(ErrorMessage = "El campo no puede estar vacio")]

        [Range(1, 100000000, ErrorMessage = "El rango es de 1 a 1000000.")]

        public decimal Monto { get; set; }

        [Required(ErrorMessage = "El campo balance no puede estar vacio")]
        public decimal Balance { get; set; }

        public Prestamos()

        {

            PrestamoId = 0;

            Fecha = DateTime.Now;

            PersonaId = 0;

            Concepto = string.Empty;

            Monto = 0;

            Balance = 0;

        }
    }
}
