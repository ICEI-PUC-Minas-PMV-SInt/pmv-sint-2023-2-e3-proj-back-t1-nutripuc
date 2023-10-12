using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nutripuc.Models
{
    [Table("RegistroAtividadeFisica")]
    public class AtividadeFisica : Registro
    {
        [Required]
        public string TituloDaAtividade { get; set; }

        [Required]
        public string CategoriaDaAtividade { get; set; }

        [Required, Range(0, 10)]
        public int Intensidade { get; set; }

        [StringLength(200)]
        public string Observacao { get; set; }

    }
}
