using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Maps
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(150);

            builder.Property(x => x.Subcategoria_1).IsRequired().HasMaxLength(150);

            builder.Property(x => x.Subcategoria_2).HasMaxLength(150);

            builder.Property(x => x.Subcategoria_3).HasMaxLength(150);
        }
    }
}
