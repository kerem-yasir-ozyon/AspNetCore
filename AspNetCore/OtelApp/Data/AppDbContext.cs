using Microsoft.EntityFrameworkCore;
using OtelApp.Data.Entities;

namespace OtelApp.Data
{
    public class AppDbContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Catalog=OtelDb;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;");
        //}

        public AppDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Otel>().Property(o => o.Adi).HasMaxLength(25);
            modelBuilder.Entity<Otel>().Property(o => o.Aciklama).HasMaxLength(100);
            modelBuilder.Entity<Otel>().Property(o => o.Telefon).HasMaxLength(11);
            modelBuilder.Entity<OtelOda>().HasKey(od => new {od.OdaId,od.OtelId});
        }
        public DbSet<Otel> Otels { get; set; }

        public DbSet<OtelTuru> OtelTurus { get; set; }

        public DbSet<OtelOda> Odalar { get; set; }

        public DbSet<OtelKapasite> OtelKapasiteler { get; set; }
        public DbSet<Ulke> Ulkeler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }

        
    }
}
