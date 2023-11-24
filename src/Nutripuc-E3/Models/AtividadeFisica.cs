using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nutripuc_E3.Models
{
    public class AtividadeFisica : Registro
    {
        [Required]
        [Display(Name = "Título do Registro")]
        public string TituloDoRegistro { get; set;}

        [Required]
        [Display(Name = "Atividade")]
        public string CategoriaDaAtividade { get; set;}

        [Required, Range(0,10)]
        public int Intensidade { get; set;}

        [StringLength(200)]
        [Display(Name = "Observação")]
        public string Observacao { get; set;}
    }
}
