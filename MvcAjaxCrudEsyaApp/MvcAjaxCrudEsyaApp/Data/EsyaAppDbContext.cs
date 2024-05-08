using Microsoft.EntityFrameworkCore;
using MvcAjaxCrudEsyaApp.Data.Entity;

namespace MvcAjaxCrudEsyaApp.Data
{
    public class EsyaAppDbContext : DbContext
    {
        public EsyaAppDbContext(DbContextOptions<EsyaAppDbContext>db) :base(db)
        {
            
        }
        public DbSet<Esya> Esyalar {  get; set; }
    }
}
