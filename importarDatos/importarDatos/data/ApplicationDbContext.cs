using Microsoft.EntityFrameworkCore;

namespace importarDatos.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Datos> Datos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=segundaprueba;user=root;",
                new MySqlServerVersion(new Version(8, 0, 21)));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Datos>()
                .HasKey(d => new { d.codigo_loc, d.consec_ctr });
        }
    }
}

