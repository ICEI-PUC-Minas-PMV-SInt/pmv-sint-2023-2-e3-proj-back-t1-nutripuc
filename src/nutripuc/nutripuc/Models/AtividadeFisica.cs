using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nutripuc.Models
{
    [Table("RegistroAtividadeFisica")]
    public class AtividadeFisica : Registro
    {
        [Required]
        [Display(Name = "Título")]
        public string TituloDaAtividade { get; set; }

        [Required]
        [Display(Name = "Atividade")]
        public string CategoriaDaAtividade { get; set; }

        [Required, Range(0, 10)]
        public int Intensidade { get; set; }

        [StringLength(200)]
        [Display(Name = "Observação")]
        public string Observacao { get; set; }

    }
}
