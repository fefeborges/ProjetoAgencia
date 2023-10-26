using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgencia.Models
{
    [Table("Estadia")]
    public class Estadia
    {
        [Column("IdEstadia")]
        [Display(Name = "Código da Estadia")]
        public int Id { get; set; }

        [Column("NomeEstadia")]
        [Display(Name = "Estadia")]
        public int NomeEstadia { get; set; }
    }
}
