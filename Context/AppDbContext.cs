using MacBurgers.Models;
using Microsoft.EntityFrameworkCore;

namespace MacBurgers.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches {  get; set; }

    }
}
