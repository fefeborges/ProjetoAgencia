using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgencia.Models
{
    [Table("Transporte")]
    public class Transporte
    {
        [Column("IdTransporte")]
        [Display(Name = "Código do Transporte")]
        public int Id { get; set; }

        [Column("NomeTransporte")]
        [Display(Name = "Transporte")]
        public string NomeTransporte { get; set; } = string.Empty;
    }
}
