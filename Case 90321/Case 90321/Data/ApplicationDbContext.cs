using DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Case_90321.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ClothingType> ClothingTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDiscount> ProductDiscounts { get; set; }
        public DbSet<ProductConfiguration> ProductConfigurations { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            FakeData fd = new FakeData();

            builder.Entity<ClothingType>().HasData(fd.ClothingTypes);
            builder.Entity<Product>().HasData(fd.Products);
        }
    }
}
