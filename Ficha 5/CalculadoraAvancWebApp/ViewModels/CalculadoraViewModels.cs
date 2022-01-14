using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using CalculadoraAvancWebApp.AppCode;

namespace CalculadoraAvancWebApp.ViewModels
{
    public class CalculadoraViewModels
    {

        public CalculadoraViewModels()
        {
            Digitos = DigitosDecimais.ListaDigitosDecimais();
        }

        [Display(Name = "Operador Direito")]
        [Required]
        public string OpDir { get; set; }

        [Display(Name = "Operador Esquerdo")]
        [Required]
        public string OpEsq { get; set; }

        [Display(Name = "Resultado")]
        public string Resultado { get; set; }

        [Display(Name = "Número de digitos")]
        public int NDigitos { get; set; }

        public SelectList Digitos { get; set; }
    }
}
