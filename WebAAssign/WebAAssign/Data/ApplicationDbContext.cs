using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAAssign.Models;

namespace WebAAssign.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryBrand> CategoryBrands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<discountRate> discountRates { get; set; }
        public DbSet<productDetail> productDetails { get; set; }
        public DbSet<productDiscountRate> productDiscountRates { get; set; }
        public DbSet<SysUser> SysUsers { get; set; }
        public DbSet<Visibility> Visibilities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DIT-MSI1845192\\SQLEXPRESS;Database=WEBAAssign;Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.Relational().TableName = entityType.DisplayName();
            }

            // one-to-many relationship between Category and CategoryBrand
            modelBuilder.Entity<CategoryBrand>()
               .HasOne(cb => cb.category)
               .WithMany(c => c.categoryBrands)
               .HasForeignKey(cb => cb.catId);

            // one-to-many relationship between Brand and CategoryBrand
            modelBuilder.Entity<CategoryBrand>()
               .HasOne(cb => cb.brand)
               .WithMany(c => c.categoryBrands)
               .HasForeignKey(cb => cb.brandId);

            // one-to-many relationship between Brand and Product
            modelBuilder.Entity<Product>()
               .HasOne(p => p.Brand)
               .WithMany(b => b.Products)
               .HasForeignKey(p => p.brandId);

            // one-to-many relationship between Category and Visibility
            modelBuilder.Entity<Category>()
               .HasOne(c => c.visibility)
               .WithMany(v => v.categories)
               .HasForeignKey(c => c.visId);

            // one-to-many relationship between discountRate and productDiscountRate
            modelBuilder.Entity<productDiscountRate>()
               .HasOne(pdr => pdr.discountRate)
               .WithMany(dr => dr.productDiscountRates)
               .HasForeignKey(pdr => pdr.discountId);

            // one-to-many relationship between Product and productDiscountRate
            modelBuilder.Entity<productDiscountRate>()
               .HasOne(pdr => pdr.Product)
               .WithMany(dr => dr.productDiscountRates)
               .HasForeignKey(pdr => pdr.prodId);


            // one-to-many relationship between Product and productDetails
            modelBuilder.Entity<productDetail>()
               .HasOne(pd => pd.product)
               .WithMany(p => p.productDetails)
               .HasForeignKey(pd => pd.prodId);
        }
    }
}
