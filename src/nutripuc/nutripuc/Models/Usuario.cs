using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nutripuc.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Email válido é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória")]
        public string Senha { get; set; }

        // Propriedade de Navegação
        public ICollection<Registro> Registros { get; set; }

        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        admin,
        user
    }
}
