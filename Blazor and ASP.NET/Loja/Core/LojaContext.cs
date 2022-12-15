using Core.Maps;
using Microsoft.EntityFrameworkCore;

namespace Core
{
#nullable disable
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Produto> Categoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
