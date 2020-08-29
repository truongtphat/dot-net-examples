using MediatR;
using Ttp.EfCore.Web.Application.Models;

namespace Ttp.EfCore.Web.Application.Command
{
    public class AddProductCommand : IRequest<ProductModel>
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }
    }
}
