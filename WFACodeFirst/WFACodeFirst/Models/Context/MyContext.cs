using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFACodeFirst.Models.Entities;

namespace WFACodeFirst.Models.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasOptional(x => x.AppUserProfile).WithRequired(x => x.AppUser);

            modelBuilder.Entity<OrderDetail>().Ignore(x => x.Id);
            modelBuilder.Entity<OrderDetail>().HasKey(x => new
            {
                x.OrderId,
                x.ProductId
            });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }



    }
}
