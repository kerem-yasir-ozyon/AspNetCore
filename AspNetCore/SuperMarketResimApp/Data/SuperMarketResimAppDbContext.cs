using Microsoft.EntityFrameworkCore;
using SuperMarketResimApp.Data.Entities;

namespace SuperMarketResimApp.Data
{
    public class SuperMarketResimAppDbContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public SuperMarketResimAppDbContext(DbContextOptions<SuperMarketResimAppDbContext> options): base(options)
        {
            
        }
    }
}
