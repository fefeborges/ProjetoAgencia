using Microsoft.EntityFrameworkCore;
using ProjetoAgencia.Models;

namespace ProjetoAgencia.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Destino> Destino { get; set; }
    }
}
