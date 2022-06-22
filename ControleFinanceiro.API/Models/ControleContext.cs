using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.API.Models
{
    public class ControleContext : DbContext
    {
        public ControleContext (DbContextOptions<ControleContext> options) : base(options)
        {
        }
        
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
    }
}