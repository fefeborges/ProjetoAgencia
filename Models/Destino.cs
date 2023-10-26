using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgencia.Models
{
    [Table("Destino")]
    public class Destino
    {
        [Column("IdDestino")]
        [Display(Name = "Código do Destino")]
        public int Id { get; set; }

        [Column("NomeDestino")]
        [Display(Name = "Destino")]
        public string NomeDestino { get; set; } = string.Empty;
    }
}
