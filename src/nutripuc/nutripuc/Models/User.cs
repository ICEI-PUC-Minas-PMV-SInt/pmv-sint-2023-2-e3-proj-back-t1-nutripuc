using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nutripuc.Models
{
    [Table("Users")]
    public class User
    {
        [Key, Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Email válido é obrigatório")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória")]
        public string? Password { get; set; }
        
    }

}
