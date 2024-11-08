using Microsoft.EntityFrameworkCore;

namespace ApiEmpresa.Models
{
    public class Conexiones : DbContext
    {
        public Conexiones(DbContextOptions<Conexiones> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; } = null!;

        // Definir explícitamente las claves primarias
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .HasKey(p => p.id_producto);

            base.OnModelCreating(modelBuilder);
        }
    }
}
