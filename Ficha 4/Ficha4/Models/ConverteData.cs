using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ficha4.Models
{
    public partial class ConverteData
    {
        int Id { get; set; }
        [Display(Name = "Moeda Inicial")]
        public int UnidadeInicial { get; set; }

        [Display(Name = "Moeda Final")]
        public int UnidadeFinal { get; set; }

        [Display(Name = "Valor Inicial")]
        public double ValorInicial { get; set; }

        [Display(Name = "Valor Final")]
        public double ValorFinal { get; set; }

        [Display(Name = "Taxa de Câmbio")]
        public double TaxaCambio { get; set; }
    }
}
