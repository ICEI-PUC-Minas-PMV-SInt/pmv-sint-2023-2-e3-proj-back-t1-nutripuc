using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nutripuc.Models
{
    [Table("Registros")]
    public class Registro
    {
        [Key, Required]
        public Guid Id { get; set; }

        [Required]
        public DateTime DataDoRegistro { get; set; } = DateTime.Now;

        public string UrlDaImagem { get; set; }

        [Required]
        public Guid IdDoUsuario { get; set; }

        // Propriedade de Navegação
        [ForeignKey("IdDoUsuario")]
        public Usuario Usuario { get; set; }

        // Propriedade de Navegação
        public AtividadeFisica? AtividadeFisica { get; set; }
        public Alimentacao? Alimentacao { get; set; }

    }
}