using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUConstruir.Models;

namespace PUConstruir.Data.Map
{
    public class MaterialMap : IEntityTypeConfiguration<MaterialModel>
    {
        public void Configure(EntityTypeBuilder<MaterialModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Usuario);

            builder.Property(p => p.Descricao).HasMaxLength(120);
            builder.Property(p => p.Um).HasMaxLength(10);
            builder.Property(p => p.ValorPadrao).HasPrecision(18);
            builder.Property(p => p.Altura).HasPrecision(18);
            builder.Property(p => p.Largura).HasPrecision(18);
            builder.Property(p => p.Comprimento).HasPrecision(18);
            builder.Property(p => p.Peso).HasPrecision(18);
            builder.Property(p => p.Cor).HasMaxLength(20);

        }
    }
}
