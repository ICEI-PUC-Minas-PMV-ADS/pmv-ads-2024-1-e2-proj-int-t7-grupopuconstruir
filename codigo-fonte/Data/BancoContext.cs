using Microsoft.EntityFrameworkCore;
using PUConstruir.Models;

namespace PUConstruir.Data
{

    public class BancoContext : DbContext
    {
        public DbSet<MaterialModel> Materiais { get; set; }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ProjetoModel> Projetos {get; set;}

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MaterialModel>(entity =>
            {
                entity.Property(p => p.Descricao).HasMaxLength(120);
                entity.Property(p => p.Um).HasMaxLength(10);
                entity.Property(p => p.ValorPadrao).HasPrecision(18);
                entity.Property(p => p.Altura).HasPrecision(18);
                entity.Property(p => p.Largura).HasPrecision(18);
                entity.Property(p => p.Comprimento).HasPrecision(18);
                entity.Property(p => p.Peso).HasPrecision(18);
                entity.Property(p => p.Cor).HasMaxLength(20);
            });



        }

    }
}
