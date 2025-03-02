using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HepsiApp.Domain.Entities;

namespace HepsiApp.Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);

            Brand brand1 = new()
            {
                Id = 1,
                Name = "X Marka",
                IsDeleted = false,
            };
            Brand brand2 = new()
            {
                Id = 2,
                Name = "Y Marka",
                IsDeleted = false,
            };
            Brand brand3 = new()
            {
                Id = 3,
                Name = "Z Marka",
                IsDeleted = true,
            };

            builder.HasData(brand1,brand2,brand3);
        }
    }
}
