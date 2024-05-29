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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MaterialMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}