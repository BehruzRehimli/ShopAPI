using Microsoft.EntityFrameworkCore;
using Shop.Core.Entities;
using Shop.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class ShopDBContext:DbContext
    {
        public ShopDBContext(DbContextOptions<ShopDBContext> opt):base(opt)
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BrandConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
