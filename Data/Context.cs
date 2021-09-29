using API_Pneus.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API_Pneus.Data
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        
<<<<<<< HEAD
=======
        public DbSet<AppUser> User { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Carrinho> Carrinho { get; set; }
<<<<<<< Updated upstream
        
=======
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
>>>>>>> Stashed changes


>>>>>>> 51d46da069e7855072cb1e9c8a39f4d6fb529ab7
    }
}



