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

        [ForeignKey("PassageirosId")]
        public int PassageirosId { get; set; }
        public Passageiros? Passageiros { get; set; }

        [ForeignKey("TransporteId")]
        public int TransporteId { get; set; }
        public Transporte? Transporte { get; set; }

        [ForeignKey("AtracoesId")]
        public int AtracoesId { get; set; }
        public Atracoes? Atracoes { get; set; }

        [Column("NomeContato")]
        [Display(Name = "Contato")]
        public int NomeContato { get; set; }
    }
}
