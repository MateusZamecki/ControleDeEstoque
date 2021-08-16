using Microsoft.EntityFrameworkCore;

namespace EstudandoHttpPostEGet.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Usuario> Usuarios{ get;set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}