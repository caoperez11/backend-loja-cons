using backend_loja_cons.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend_loja_cons;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions options): base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Marca>? Marcas { get; set; }
    public DbSet<Producto>? Productos { get; set; }
    public DbSet<Empresa>? Empresa { get; set; }
    
    
}