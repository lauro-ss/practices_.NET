using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Maps
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {

        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.IdCategoria, "in_produto_categoria");

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(150);

            builder.Property(x => x.Valor).IsRequired().HasColumnType("numeric(10,2)");

            builder.Property(x => x.Status).IsRequired();

            builder.Property(x => x.Quantidade).IsRequired();

            builder.Property(x => x.Subcategoria).IsRequired().HasMaxLength(150);

            builder.HasOne(x => x.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(x => x.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_produto_categoria");
        }
    }
}
