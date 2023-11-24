using System.ComponentModel.DataAnnotations;

namespace Nutripuc_E3.Models
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
        public DateTime Horario { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Refeição do Lixo")]
        public bool RefeicaoDoLixo { get; set; } = false;
    }

    public enum TipoDeRefeicao
    {
        Desjejum,
        CafeDaManha,
        Almoco,
        Jantar,
        Ceia,
        Colacao,
        Lanche
    }
}
