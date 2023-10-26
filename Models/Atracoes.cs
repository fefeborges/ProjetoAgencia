using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgencia.Models
{
    [Table("Atracoes")]
    public class Atracoes
    {
        [Column("IdAtracoes")]
        [Display(Name = "Código das Atrações")]
        public int Id { get; set; }

        [Column("NomeAtracoes")]
        [Display(Name = "Atrações")]
        public string NomeAtracoes { get; set; } = string.Empty;

    }
}
