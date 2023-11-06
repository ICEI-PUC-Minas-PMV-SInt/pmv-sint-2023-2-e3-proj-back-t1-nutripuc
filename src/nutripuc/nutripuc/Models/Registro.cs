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
        [Display(Name = "Data do Registro")]
        public DateTime DataDoRegistro { get; set; } = DateTime.Now;

        [Display(Name = "URL da Imagem")]
        public string UrlDaImagem { get; set; }

        [Required]
        [Display(Name = "Id do Usuário")]
        public Guid IdDoUsuario { get; set; }

        // Propriedade de Navegação
        [ForeignKey("IdDoUsuario")]
        public Usuario Usuario { get; set; }

        // Propriedade de Navegação
        public AtividadeFisica? AtividadeFisica { get; set; }
        public Alimentacao? Alimentacao { get; set; }

    }
}