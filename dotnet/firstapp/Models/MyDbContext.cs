using Microsoft.EntityFrameworkCore;

namespace firstapp.Models
{
   public class MyDbContext : DbContext
   {
       public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
       {
       }

       public DbSet<Usuario> Usuario {get; set;}
       public DbSet<Pessoa> Pessoa {get; set;}
       public DbSet<Aluno> Aluno {get; set;}
       public DbSet<Professor> Professor {get; set;}
   }
}