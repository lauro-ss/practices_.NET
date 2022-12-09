using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Map
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.IdCategoria, "fk_produto_categoria_ind");

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(150);

            builder.Property(x => x.Quantidade).IsRequired();

            builder.Property(x => x.Status).IsRequired();

            builder.HasOne(x => x.IdCategoriaNavigation)
                .WithMany(p => p.Produtos)
                .HasForeignKey(x => x.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_produto_categoria");

        }
    }
}
