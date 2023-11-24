using nutripuc.Models.enumerators;
using System.ComponentModel.DataAnnotations;

namespace nutripuc.Models
{
    public class Alimentacao : Registro
    {
        [Required]
        [Display(Name = "Tipo de Refeição")]
        public TipoDeRefeicao TipoDeRefeicao { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required]
        [Display(Name = "Horário")]
        public DateTime horario { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Refeição do Lixo")]
        public bool RefeicaoDoLixo { get; set; } = false;
    }
}
