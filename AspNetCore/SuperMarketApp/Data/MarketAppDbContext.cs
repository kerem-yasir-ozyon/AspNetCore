using Microsoft.EntityFrameworkCore;
using SuperMarketApp.Data.Entities;

namespace SuperMarketApp.Data
{
    public class MarketAppDbContext : DbContext
    {
        
        public MarketAppDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-EBR8KE7;Initial Catalog=SuperMarketDb;Integrated Security=true;Encrypt=False");
        }
        public DbSet<Urun> Urunler { get; set; }


    }
}
