using HepsiApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApp.Domain.Entities
{
    public class Brand : EntityBase
    {
        public string Name { get; set; }

        public Brand(string name)
        {
            Name = name;
        }

        public Brand()
        {
        }
    }
}