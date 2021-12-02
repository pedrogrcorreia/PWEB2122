using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ficha4.Models
{
    public class UnidadeMonetaria
    {
        public int Id { get; set; }

        [Display(Name = "Código")]
        [Required]
        public string Codigo { get; set; }

        [Display(Name = "Valor / Euro")]
        public double ValorPorEuro { get; set; }

        public DateTime? Data { get; set; }
    }
}
