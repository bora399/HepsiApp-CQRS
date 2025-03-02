using Bogus;
using HepsiApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApp.Persistence.Configurations
{
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Detail> builder)
        {
            Detail detail1 = new()
            {
                Id = 1,
                Title = "Detail",
                Description = "Detail Description",
                CategoryId = 1,
                IsDeleted = false,
            };
            Detail detail2 = new()
            {
                Id = 2,
                Title = "Detail 2",
                Description = "Detail Description 2",
                CategoryId = 3,
                IsDeleted = false,
            };
            Detail detail3 = new()
            {
                Id = 3,
                Title = "Detail 3",
                Description = "Detail Description 3",
                CategoryId = 4,
                IsDeleted = true,
            };

            builder.HasData(detail1, detail2, detail3);
        }
    }
}
