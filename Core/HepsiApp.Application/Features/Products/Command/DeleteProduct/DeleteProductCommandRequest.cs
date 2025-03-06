using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApp.Application.Features.Products.Command.DeleteProduct
{
    public class DeleteProductCommandRequest : IRequest
    {
        public int productId { get; set; }
    }
}
