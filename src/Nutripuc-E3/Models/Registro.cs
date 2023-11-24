using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nutripuc_E3.Models
{
    [Table("Registros")]
    public class Registro
    {
        [Key, Required]

        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Data do Registro")]
        public DateTime DataDoRegistro { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Id do Usuário")]
        public Guid IdDoUsuario { get; set;}

        //Propriedade de navegação
        public AtividadeFisica AtividadeFisica { get; set; }

        public Alimentacao Alimentacao { get; set; }

        [ForeignKey("IdDoUsuario")]
        public Usuario Usuario { get; set; }
    }
}
