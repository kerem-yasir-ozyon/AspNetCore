using Microsoft.EntityFrameworkCore;

namespace MvcUygulama.Context
{
    public class UygulamaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
        }
    }
}
