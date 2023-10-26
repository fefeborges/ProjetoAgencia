using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgencia.Models
{
    [Table("Cadastro")]
    public class Cadastro
    {
        [Column("IdCadastro")]
        [Display(Name = "Código do Cadastro")]
        public int Id { get; set; }

        [Column("NomePessoa")]
        [Display(Name = "Nome")]
        public string NomePessoa { get; set; } = string.Empty;

        [ForeignKey("DestinoId")]
        public int DestinoId { get; set; }
        public Destino? Destino { get; set; }

        [ForeignKey("EstadiaId")]
        public int EstadiaId { get; set; }
        public Estadia? Estadia { get; set; }

        [Column("NomeContato")]
        [Display(Name = "Contato")]
        public int NomeContato { get; set; }
    }
}
