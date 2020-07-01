using MediatR;
using Ttp.Web.EfCoreInMemory.Application.Models;

namespace Ttp.Web.EfCoreInMemory.Application.Command
{
    public class AddProductCommand : IRequest<ProductModel>
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }
    }
}
