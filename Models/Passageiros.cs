using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgencia.Models
{
    [Table("Passageiros")]
    public class Passageiros
    {
        [Column("IdPassageiros")]
        [Display(Name = "Código dos Passageiros")]
        public int Id { get; set; }

        [Column("NomePassageiros")]
        [Display(Name = "Passageiros")]
        public int NomePassageiros { get; set; }
    }
}
