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
        }
    }
}
