using AppStore.Models.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppStore.Models.Database;

public class SqliteContext : IdentityDbContext<AppUser>
{
    // Esto es lo mismo que colocar en la clase lo siguiente:
    // public class SqliteContext(DbContextOptions<SqliteContext> options) : base(options)
    public SqliteContext(DbContextOptions<SqliteContext> options) : base(options)
    {
    }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);



        modelBuilder.Entity<Libro>()
            .HasMany(l => l.Categorias)
            .WithMany(c => c.Libros)
            .UsingEntity<LibroCategoria>(
                j => j
                    .HasOne(lc => lc.Categoria)
                    .WithMany(c => c.LibroCategorias)
                    .HasForeignKey(lc => lc.CategoriaId),
                j => j
                    .HasOne(lc => lc.Libro)
                    .WithMany(l => l.LibroCategorias)
                    .HasForeignKey(lc => lc.LibroId),
                j =>
                {
                    j.HasKey(t => new { t.LibroId, t.CategoriaId });
                });
    }
    
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Libro> Libros { get; set; }
    public DbSet<LibroCategoria> LibroCategorias { get; set; }
}