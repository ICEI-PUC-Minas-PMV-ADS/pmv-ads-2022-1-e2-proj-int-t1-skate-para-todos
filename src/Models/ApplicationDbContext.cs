using Microsoft.EntityFrameworkCore;
using skateparatodos.Models;

namespace skateparatodos.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }
        public DbSet<DoacaoItem> DoacoesItens { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasAlternateKey(u => u.Email)
                .HasName("AlternateKey_Email");
        }
    }
}
