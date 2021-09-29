using API_Pneus.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Data
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        
        public DbSet<AppUser> User { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Carrinho> Carrinho { get; set; }
        


    }
}
