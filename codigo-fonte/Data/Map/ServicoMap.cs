using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PUConstruir.Models;

namespace PUConstruir.Data.Map
{
    public class ServicoMap : IEntityTypeConfiguration<ServicoModel>
    {
        public void Configure(EntityTypeBuilder<ServicoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Usuario);
        }
    }
}