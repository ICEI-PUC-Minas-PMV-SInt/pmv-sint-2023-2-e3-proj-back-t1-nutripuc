using nutripuc.Models.enumerators;
using System.ComponentModel.DataAnnotations;

namespace nutripuc.Models
{
    public class Alimentacao : Registro
    {
        [Required]
        public TipoDeRefeicao TipoDeRefeicao { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public DateTime horario { get; set; } = DateTime.Now;

        [Required]
        public bool RefeicaoDoLixo { get; set; } = false;
    }
}
