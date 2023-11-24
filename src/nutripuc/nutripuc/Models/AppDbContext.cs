using Microsoft.EntityFrameworkCore;
using nutripuc.Controllers;

namespace nutripuc.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Registro> Registros { get; set; }

        public DbSet<AtividadeFisica> RegistrosDeAtividadeFisica { get; set; }
        public DbSet<Alimentacao> RegistrosDeAlimentacao { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=nutripuc-backend;Trusted_Connection=True;MultipleActiveResultSets=true");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aqui você pode colocar configurações adicionais, caso necessário
            modelBuilder.Entity<Usuario>()
                        .HasIndex(u => u.Email)
                        .IsUnique();

            modelBuilder.Entity<AtividadeFisica>()
                        .ToTable("AtividadeFisica");

            modelBuilder.Entity<Alimentacao>()
                        .ToTable("Alimentacao");
        }

    }
}
