using Microsoft.EntityFrameworkCore;

namespace ProjetoAgencia.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Passageiros> Passageiros { get; set; }
        public DbSet<Estadia> Estadia { get; set; }
        public DbSet<Atracoes> Atracoes { get; set; }
        public DbSet<Destino> Destino { get; set; }
        public DbSet<Transporte> Transporte { get; set; }
        public DbSet<Cadastro> Cadastro { get; set; }
    }
}
