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

        public Detail(int Id,string title, string description, int categoryId, Category category)
        {
            Id = Id;
            Title = title;
            Description = description;
            CategoryId = categoryId;
            IsDeleted = IsDeleted;
            CreatedDate = CreatedDate;
        }
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required int CategoryId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public required DateTime CreatedDate { get; set; }
        public Category Category { get; set; }
    }
}
