using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApp.Domain.Entities
{
    public class Detail
    {
        public Detail()
        {
        }

        public Detail(int id,string title, string description, int categoryId, Category category)
        {
            Id = id;
            Title = title;
            Description = description;
            CategoryId = categoryId;
            IsDeleted = IsDeleted;
        }
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required int CategoryId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Category Category { get; set; }
    }
}
