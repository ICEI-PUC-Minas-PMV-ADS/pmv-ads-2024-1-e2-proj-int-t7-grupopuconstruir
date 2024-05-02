using Microsoft.EntityFrameworkCore;
using PUConstruir.Models;

namespace PUConstruir.Data
{

    public class BancoContext : DbContext
    {
        public DbSet<MaterialModel> Materiais { get; set; }

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }


    }

}
