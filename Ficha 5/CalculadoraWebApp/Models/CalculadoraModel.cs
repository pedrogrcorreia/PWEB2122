using System.ComponentModel.DataAnnotations;

namespace CalculadoraAvancWebApp.Models
{
    public class CalculadoraModel
    {
        [Display(Name = "Operador Direito")]
        [Required]
        public string OpDir { get; set; }
        
        [Display(Name = "Operador Esquerdo")]
        [Required]
        public string OpEsq { get; set; }
        
        [Display(Name = "Resultado")]
        public string Resultado { get; set; }
    }
}
