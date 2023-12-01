
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
namespace ruan.Models
{
   public class MyDbContext : DbContext
   {
       public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
       {
       }
       public DbSet<Carrinho> Carrinho {get; set;}
       public DbSet<Categoria> Categoria {get; set;}
       public DbSet<Produto> Produto {get; set;}
       public DbSet<Usuario> Usuario {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasOne( a => a.Carrinho).WithOne(a => a.Usuario).HasForeignKey<Carrinho>(c => c.UsuarioId);
        }
   }
}
