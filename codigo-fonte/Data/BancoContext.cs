using Microsoft.EntityFrameworkCore;
using PUConstruir.Data.Map;
using PUConstruir.Models;

namespace PUConstruir.Data
{

    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<MaterialModel> Materiais { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ServicoModel> Servicos { get; set; }
        public DbSet<ProjetoModel> Projetos { get; set; }
        public DbSet<OrcamentoModel> Orcamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MaterialMap());

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProjetoModel>()
                .HasMany(p => p.Materiais)
                .WithMany(m => m.Projetos)
                .UsingEntity(j => j.ToTable("ProjetoMateriais"));

            modelBuilder.Entity<ProjetoModel>()
                .HasMany(p => p.Servicos)
                .WithMany(s => s.Projetos)
                .UsingEntity(j => j.ToTable("ProjetoServicos"));

            modelBuilder.Entity<OrcamentoModel>()
                .HasMany(o => o.Projetos)
                .WithMany(p => p.Orcamentos)
                .UsingEntity(j => j.ToTable("OrcamentoProjetos"));
        }
    }
}