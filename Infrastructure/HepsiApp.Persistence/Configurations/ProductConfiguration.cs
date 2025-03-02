using Bogus;
using HepsiApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApp.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Product product1 = new()
            {
                Id = 1,
                Title = "Product Name 1",
                BrandId = 1,
                Description = "Product Description 1",
                Discount = 500,
                Price = 800,
                IsDeleted = false,
            };
            Product product2 = new()
            {
                Id = 2,
                Title = "Product Name 2",
                BrandId = 3,
                Description = "Product Description 2",
                Discount = 600,
                Price = 900,
                IsDeleted = false,
            };
            builder.HasData(product1, product2);      
        }
    }
}
